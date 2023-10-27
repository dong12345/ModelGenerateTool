using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelGenerate
{
    public partial class Form1 : Form
    {
        private readonly string Delimiter = "\\";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bt_Gnerate_Click(object sender, EventArgs e)
        {
            bt_Gnerate.Enabled = false;
            if (lb_Tables.Items.Count == 0)
            {
                MessageBox.Show("请选择数据库");
                bt_Gnerate.Enabled = true;
                return;
            }
            //else if (txt_Prefix.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("命名空间不能为空");
            //    bt_Gnerate.Enabled = true;
            //    return;
            //}
            else if (txt_Place.Text.Trim() == string.Empty)
            {
                MessageBox.Show("文件存放位置不能为空");
                bt_Gnerate.Enabled = true;
                return;
            }
            else
            {
                Regex regex = new Regex("^([a-zA-Z]:\\\\)?[^\\/\\:\\*\\?\\\"\\<\\>\\|\\,]*$");
                Match match = regex.Match(txt_Place.Text);
                if (!match.Success)
                {
                    MessageBox.Show("非法的文件保存路径，请重新选择或输入！");
                    return;
                }
                WriteMessage("Model生成中....");
                if (rd_AllTables.Checked)
                {
                    object selectedItem = ddl_DatabaseBox.SelectedItem;
                    DbTable dbTable = selectedItem as DbTable;
                    string key = dbTable.key;
                    string value = dbTable.value;
                    if (key != "0" && key != "")
                    {
                        await GenerateCS(value);
                    }
                    else
                    {
                        MessageBox.Show("请选择数据库！");
                        bt_Gnerate.Enabled = true;
                        return;
                    }
                }
                else
                {
                    object selectedItem2 = ddl_DatabaseBox.SelectedItem;
                    DbTable dbTable2 = selectedItem2 as DbTable;
                    string key2 = dbTable2.key;
                    string value2 = dbTable2.value;
                    if (key2 != "0" && key2 != "")
                    {
                        string text = $"Integrated Security=false;Data Source={txt_IP.Text.Trim()};User ID={txt_UserName.Text.Trim()};Password={txt_Pwd.Text.Trim()};Initial Catalog={value2};Connect Timeout=30";
                        ListBox.SelectedObjectCollection selectedItems = lb_Tables.SelectedItems;
                        if (selectedItems != null)
                        {
                            foreach (object item2 in selectedItems)
                            {
                                GenerateEntity(text, lb_Tables.GetItemText(item2), txt_Place.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择数据库！");
                        bt_Gnerate.Enabled = true;
                        return;
                    }
                }
                WriteMessage("Model生成成功");
                bt_Gnerate.Enabled = true;
            }
        }

        /// <summary>
        /// 点击连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Connect_Click(object sender, EventArgs e)
        {
            txt_Connect.Enabled = false;
            if (txt_IP.Text.Trim() == "")
            {
                MessageBox.Show("IP地址不能为空!");
                txt_Connect.Enabled = true;
                return;
            }
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("登录名不能为空!");
                txt_Connect.Enabled = true;
                return;
            }
            if (txt_Pwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空!");
                txt_Connect.Enabled = true;
                return;
            }

            try
            {
                WriteMessage("数据库连接中...");
                string connection = $"Integrated Security=false;Data Source={txt_IP.Text.Trim()};User ID={txt_UserName.Text.Trim()};Password={txt_Pwd.Text.Trim()};Connect Timeout=30";
                List<DbTable> allDataBaseName = SqlHelper.GetAllDataBaseName(connection);
                allDataBaseName.Insert(0, new DbTable
                {
                    key = "0",
                    value = "-请选择数据库-"
                });
                ddl_DatabaseBox.DataSource = allDataBaseName;
                ddl_DatabaseBox.DisplayMember = "Value";
                ddl_DatabaseBox.ValueMember = "Key";
                WriteMessage("数据库连接成功");
                txt_Connect.Enabled = true;
            }
            catch (Exception ex)
            {
                WriteMessage($"数据库连接失败:{ex.Message}");
                txt_Connect.Enabled = true;
            }

        }

        /// <summary>
        /// 切换数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ddl_DatabaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object selectedItem = ddl_DatabaseBox.SelectedItem;
                DbTable dbTable = selectedItem as DbTable;
                string key = dbTable.key;
                string value = dbTable.value;
                if (key != "0" && key != "")
                {
                    //this.txt_log.Clear();
                    WriteMessage("数据库表获取中...");
                    string connection = $"Integrated Security=false;Data Source={txt_IP.Text.Trim()};User ID={txt_UserName.Text.Trim()};Password={txt_Pwd.Text.Trim()};Initial Catalog={value};Connect Timeout=30";
                    var allTableName = await GetTableDic(value, connection);
                    lb_Tables.DataSource = new BindingSource(allTableName, null);
                    lb_Tables.DisplayMember = "key";
                    lb_Tables.DisplayMember = "value";
                    WriteMessage("数据库表获取成功");
                }
            }
            catch (Exception ex)
            {
                WriteMessage(ex.Message);
            }
        }

        /// <summary>
        /// 选择存储位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ChoosePlace_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "浏览文件夹";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK || folderBrowserDialog.ShowDialog() == DialogResult.Yes)
            {
                txt_Place.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private Task<Dictionary<string, string>> GetTableDic(string value, string connection)
        {
            return Task.Run(() =>
            {
                Dictionary<string, string> allTableName = SqlHelper.GetAllTableName(connection);
                return allTableName;
            });
        }

        private Task GenerateCS(string value)
        {
            return Task.Run(async () =>
           {
               string connection = $"Integrated Security=false;Data Source={txt_IP.Text.Trim()};User ID={txt_UserName.Text.Trim()};Password={txt_Pwd.Text.Trim()};Initial Catalog={value};Connect Timeout=30";
               var allTableName = await GetTableDic(value, connection);
               if (allTableName?.Any() ?? false)
               {
                   foreach (KeyValuePair<string, string> item in allTableName)
                   {
                       GenerateEntity(connection, item.Value, txt_Place.Text);
                   }
               }
           });
        }

        /// <summary>
        /// 生成实体
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="tableName"></param>
        /// <param name="outputPath"></param>
        private void GenerateEntity(string conn, string tableName, string outputPath)
        {
            GenerateModelPath(tableName, outputPath, out string path);
            WriteAndSave(path, GetModel(conn, tableName));
        }

        /// <summary>
        /// 生成实体路径
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="outputPath"></param>
        /// <param name="path"></param>
        private void GenerateModelPath(string tableName, string outputPath, out string path)
        {
            //string text = outputPath + Delimiter + "Models";
            string text = outputPath;
            if (!Directory.Exists(text))
            {
                Directory.CreateDirectory(text);
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(text);
            stringBuilder.Append(Delimiter);
            stringBuilder.Append(tableName);
            stringBuilder.Append(".cs");
            path = stringBuilder.ToString();
        }

        /// <summary>
        /// 生成文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        private static void WriteAndSave(string fileName, string content)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(content);
                    streamWriter.Flush();
                    streamWriter.Close();
                    fileStream.Close();
                }
            }
        }

        public string GetModel(string conn, string tableName)
        {
            var prefix = txt_Prefix.Text.Trim();
            List<CompleteField> columnCompleteField = SqlHelper.GetColumnCompleteField(conn, tableName);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("using System;\r\n");
            //stringBuilder.Append("using SysTem.CommponentModel.DataAnnotations;\r\n");
            //stringBuilder.Append("using " + prefix + ";\r\n");
            stringBuilder.Append("namespace " + prefix + "\r\n");
            stringBuilder.Append("{\r\n");
            stringBuilder.Append("    public partial class " + tableName + "\r\n");
            stringBuilder.Append("    {\r\n");
            foreach (CompleteField item in columnCompleteField)
            {
                stringBuilder.Append("        /// <summary>\r\n");
                stringBuilder.Append("        ///  " + item.remark + "\r\n");
                stringBuilder.Append("        /// <summary>\r\n");
                stringBuilder.Append("        public " + SqlHelper.GetType(item.xType) + " " + item.name + " { get; set; }\r\n");
                stringBuilder.Append("\r\n");
            }
            stringBuilder.Append("     }\r\n");
            stringBuilder.Append("}\r\n");
            return stringBuilder.ToString();
        }

        private void WriteMessage(string msg)
        {
            this.txt_log.AppendText(string.Format("{0}{1}", msg, Environment.NewLine));
        }

        private void lb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object selectedItem = ddl_DatabaseBox.SelectedItem;
                DbTable dbTable = selectedItem as DbTable;
                string key = dbTable.key;
                string value = dbTable.value;
                if (key != "0" && key != "")
                {
                    string connectionStr = $"Integrated Security=false;Data Source={txt_IP.Text.Trim()};User ID={txt_UserName.Text.Trim()};Password={txt_Pwd.Text.Trim()};Initial Catalog={value};Connect Timeout=30";
                    OutputCode(connectionStr);
                }
            }
            catch (Exception ex)
            {
                WriteMessage(ex.Message);
            }
        }

        private void OutputCode(string conn)
        {
            string text = lb_Tables.Text;
            txt_Model.Text = GetModel(conn, text);
        }
    }
}