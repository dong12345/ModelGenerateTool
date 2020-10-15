using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ModelGenerate
{
    public class SqlHelper
    {
        public static List<DbTable> GetAllDataBaseName(string connection)
        {
            List<DbTable> list = new List<DbTable>();
            string cmdText = "select name from Master.sys.SysDatabases order by name  ";
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    IDataReader dataReader = sqlCommand.ExecuteReader();
                    list.Clear();
                    while (dataReader.Read())
                    {
                        list.Add(new DbTable
                        {
                            value = dataReader["name"].ToString(),
                            key = dataReader["name"].ToString()
                        });
                    }
                    dataReader.Close();
                }
            }
            catch (Exception)
            {
                throw new AggregateException("获得数据库连接居然不传数据库类型，你想上天吗？");
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Dispose();
                }
            }
            return list;
        }

        public static Dictionary<string, string> GetAllTableName(string connection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string cmdText = "select * from sysobjects where xtype='u' order by name";
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    IDataReader dataReader = sqlCommand.ExecuteReader();
                    dictionary.Clear();
                    while (dataReader.Read())
                    {
                        dictionary.Add(dataReader["name"].ToString(), dataReader["name"].ToString());
                    }
                    dataReader.Close();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Dispose();
                }
            }
            return dictionary;
        }

        public static List<CompleteField> GetColumnCompleteField(string connection, string TableName)
        {
            List<CompleteField> list = new List<CompleteField>();
            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string cmdText = "SELECT   c.name,  c.user_type_id,  c.max_length,  c.is_nullable,  remark = ex.value  FROM       sys.columns c    LEFT OUTER JOIN       sys.extended_properties ex    ON       ex.major_id = c.object_id      AND ex.minor_id = c.column_id       AND ex.name = 'MS_Description'    WHERE       OBJECTPROPERTY(c.object_id, 'IsMsShipped')=0        AND OBJECT_NAME(c.object_id) = '" + TableName + "'   ORDER       BY OBJECT_NAME(c.object_id), c.column_id";
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    list.Add(new CompleteField
                    {
                        name = sqlDataReader[0].ToString(),
                        xType = sqlDataReader[1].ToString(),
                        length = sqlDataReader[2].ToString(),
                        isNullAble = sqlDataReader[3].ToString(),
                        remark = ((sqlDataReader[4] == null) ? "" : sqlDataReader[4].ToString())
                    });
                }
            }
            catch (Exception)
            {
            }
            sqlConnection.Close();
            return list;
        }

        public static string GetType(string xtype)
        {
            switch (xtype)
            {
                case "34":
                    return "image";

                case "35":
                    return "string";

                case "36":
                    return "uniqueidentifier";

                case "48":
                    return "tinyint";

                case "52":
                    return "smallint";

                case "56":
                    return "int";

                case "58":
                    return "smalldatetime";

                case "59":
                    return "real";

                case "60":
                    return "money";

                case "61":
                    return "DateTime";

                case "62":
                    return "float";

                case "98":
                    return "sql_variant";

                case "99":
                    return "ntext";

                case "104":
                    return "bool";

                case "106":
                    return "decimal";

                case "108":
                    return " numeric";

                case "122":
                    return "smallmoney";

                case "127":
                    return "bigint";

                case "165":
                    return "varbinary";

                case "167":
                    return "string";

                case "173":
                    return "binary";

                case "175":
                    return "char";

                case "189":
                    return "timestamp";

                case "231":
                    return "string";

                case "239":
                    return "nchar";

                default:
                    return "";
            }
        }
    }
}