namespace ModelGenerate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Tables = new System.Windows.Forms.ListBox();
            this.ddl_DatabaseBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.localhostBox = new System.Windows.Forms.Label();
            this.txt_Connect = new System.Windows.Forms.Button();
            this.bt_Gnerate = new System.Windows.Forms.Button();
            this.bt_ChoosePlace = new System.Windows.Forms.Button();
            this.txt_Place = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rd_PartTables = new System.Windows.Forms.RadioButton();
            this.rd_AllTables = new System.Windows.Forms.RadioButton();
            this.txt_Prefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Tables
            // 
            this.lb_Tables.FormattingEnabled = true;
            this.lb_Tables.ItemHeight = 15;
            this.lb_Tables.Location = new System.Drawing.Point(7, 24);
            this.lb_Tables.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Tables.Name = "lb_Tables";
            this.lb_Tables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Tables.Size = new System.Drawing.Size(309, 799);
            this.lb_Tables.TabIndex = 7;
            this.lb_Tables.SelectedIndexChanged += new System.EventHandler(this.lb_Tables_SelectedIndexChanged);
            // 
            // ddl_DatabaseBox
            // 
            this.ddl_DatabaseBox.FormattingEnabled = true;
            this.ddl_DatabaseBox.Location = new System.Drawing.Point(163, 72);
            this.ddl_DatabaseBox.Margin = new System.Windows.Forms.Padding(4);
            this.ddl_DatabaseBox.Name = "ddl_DatabaseBox";
            this.ddl_DatabaseBox.Size = new System.Drawing.Size(434, 23);
            this.ddl_DatabaseBox.TabIndex = 40;
            this.ddl_DatabaseBox.SelectedIndexChanged += new System.EventHandler(this.ddl_DatabaseBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "数据库列表:";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(700, 25);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(132, 25);
            this.txt_Pwd.TabIndex = 38;
            this.txt_Pwd.Text = "123";
            // 
            // PasswordBox
            // 
            this.PasswordBox.AutoSize = true;
            this.PasswordBox.Location = new System.Drawing.Point(631, 28);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(52, 15);
            this.PasswordBox.TabIndex = 37;
            this.PasswordBox.Text = "密码：";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(465, 25);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(132, 25);
            this.txt_UserName.TabIndex = 36;
            this.txt_UserName.Text = "sa";
            // 
            // UserNameBox
            // 
            this.UserNameBox.AutoSize = true;
            this.UserNameBox.Location = new System.Drawing.Point(390, 28);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(67, 15);
            this.UserNameBox.TabIndex = 35;
            this.UserNameBox.Text = "登录名：";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(163, 25);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(200, 25);
            this.txt_IP.TabIndex = 34;
            this.txt_IP.Text = ".";
            // 
            // localhostBox
            // 
            this.localhostBox.AutoSize = true;
            this.localhostBox.Location = new System.Drawing.Point(20, 32);
            this.localhostBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.localhostBox.Name = "localhostBox";
            this.localhostBox.Size = new System.Drawing.Size(31, 15);
            this.localhostBox.TabIndex = 33;
            this.localhostBox.Text = "IP:";
            // 
            // txt_Connect
            // 
            this.txt_Connect.Location = new System.Drawing.Point(862, 21);
            this.txt_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Connect.Name = "txt_Connect";
            this.txt_Connect.Size = new System.Drawing.Size(122, 29);
            this.txt_Connect.TabIndex = 32;
            this.txt_Connect.Text = "连接";
            this.txt_Connect.UseVisualStyleBackColor = true;
            this.txt_Connect.Click += new System.EventHandler(this.txt_Connect_Click);
            // 
            // bt_Gnerate
            // 
            this.bt_Gnerate.BackColor = System.Drawing.Color.White;
            this.bt_Gnerate.Location = new System.Drawing.Point(163, 241);
            this.bt_Gnerate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Gnerate.Name = "bt_Gnerate";
            this.bt_Gnerate.Size = new System.Drawing.Size(611, 54);
            this.bt_Gnerate.TabIndex = 31;
            this.bt_Gnerate.Text = "一 键 生 成";
            this.bt_Gnerate.UseVisualStyleBackColor = false;
            this.bt_Gnerate.Click += new System.EventHandler(this.bt_Gnerate_Click);
            // 
            // bt_ChoosePlace
            // 
            this.bt_ChoosePlace.Location = new System.Drawing.Point(862, 194);
            this.bt_ChoosePlace.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ChoosePlace.Name = "bt_ChoosePlace";
            this.bt_ChoosePlace.Size = new System.Drawing.Size(122, 30);
            this.bt_ChoosePlace.TabIndex = 30;
            this.bt_ChoosePlace.Text = "选择位置";
            this.bt_ChoosePlace.UseVisualStyleBackColor = true;
            this.bt_ChoosePlace.Click += new System.EventHandler(this.bt_ChoosePlace_Click);
            // 
            // txt_Place
            // 
            this.txt_Place.Enabled = false;
            this.txt_Place.Location = new System.Drawing.Point(163, 198);
            this.txt_Place.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Place.Name = "txt_Place";
            this.txt_Place.Size = new System.Drawing.Size(611, 25);
            this.txt_Place.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "文件存放位置：";
            // 
            // rd_PartTables
            // 
            this.rd_PartTables.AutoSize = true;
            this.rd_PartTables.Location = new System.Drawing.Point(825, 77);
            this.rd_PartTables.Margin = new System.Windows.Forms.Padding(4);
            this.rd_PartTables.Name = "rd_PartTables";
            this.rd_PartTables.Size = new System.Drawing.Size(73, 19);
            this.rd_PartTables.TabIndex = 27;
            this.rd_PartTables.Text = "部分表";
            this.rd_PartTables.UseVisualStyleBackColor = true;
            // 
            // rd_AllTables
            // 
            this.rd_AllTables.AutoSize = true;
            this.rd_AllTables.Checked = true;
            this.rd_AllTables.Location = new System.Drawing.Point(672, 76);
            this.rd_AllTables.Margin = new System.Windows.Forms.Padding(4);
            this.rd_AllTables.Name = "rd_AllTables";
            this.rd_AllTables.Size = new System.Drawing.Size(73, 19);
            this.rd_AllTables.TabIndex = 26;
            this.rd_AllTables.TabStop = true;
            this.rd_AllTables.Text = "所有表";
            this.rd_AllTables.UseVisualStyleBackColor = true;
            // 
            // txt_Prefix
            // 
            this.txt_Prefix.Location = new System.Drawing.Point(163, 132);
            this.txt_Prefix.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Prefix.Name = "txt_Prefix";
            this.txt_Prefix.Size = new System.Drawing.Size(611, 25);
            this.txt_Prefix.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "命名空间：";
            // 
            // txt_log
            // 
            this.txt_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_log.Enabled = false;
            this.txt_log.ForeColor = System.Drawing.Color.Red;
            this.txt_log.Location = new System.Drawing.Point(12, 16);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(350, 480);
            this.txt_log.TabIndex = 41;
            this.txt_log.Text = "";
            // 
            // txt_Model
            // 
            this.txt_Model.Enabled = false;
            this.txt_Model.Location = new System.Drawing.Point(7, 16);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Model.Multiline = true;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(609, 480);
            this.txt_Model.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Prefix);
            this.groupBox1.Controls.Add(this.ddl_DatabaseBox);
            this.groupBox1.Controls.Add(this.rd_AllTables);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rd_PartTables);
            this.groupBox1.Controls.Add(this.txt_Pwd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.txt_Place);
            this.groupBox1.Controls.Add(this.bt_ChoosePlace);
            this.groupBox1.Controls.Add(this.UserNameBox);
            this.groupBox1.Controls.Add(this.bt_Gnerate);
            this.groupBox1.Controls.Add(this.txt_IP);
            this.groupBox1.Controls.Add(this.txt_Connect);
            this.groupBox1.Controls.Add(this.localhostBox);
            this.groupBox1.Location = new System.Drawing.Point(352, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 323);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Model);
            this.groupBox2.Location = new System.Drawing.Point(352, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 502);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成model预览";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_log);
            this.groupBox3.Location = new System.Drawing.Point(984, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 502);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_Tables);
            this.groupBox4.Location = new System.Drawing.Point(12, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 831);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据库表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1387, 773);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model实体生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Tables;
        private System.Windows.Forms.ComboBox ddl_DatabaseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label PasswordBox;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label UserNameBox;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label localhostBox;
        private System.Windows.Forms.Button txt_Connect;
        private System.Windows.Forms.Button bt_Gnerate;
        private System.Windows.Forms.Button bt_ChoosePlace;
        private System.Windows.Forms.TextBox txt_Place;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd_PartTables;
        private System.Windows.Forms.RadioButton rd_AllTables;
        private System.Windows.Forms.TextBox txt_Prefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

