using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace 流量计检定上位机.CDM.Sqlite
{
    public class ComWithSqlite
    {
        public string TableName { get; set; } = "GatherSave";
        public string DatabaseName { get; set; } = "MySQLData";
        SQLiteConnection conn;

        public ComWithSqlite()
        {
            conn = null;

            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/" + DatabaseName + ".db";
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建  
            var data = new GatherSave();
            string sql = $"CREATE TABLE IF NOT EXISTS {TableName}({data.CreateTableToString()});";//建表语句  
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表  
            //conn.Close();
        }

        public void InsertData<T>(T data)  where T : BaseSqliteModel
        {
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            cmdInsert.CommandText = $"INSERT INTO {TableName} VALUES({data.ValuesTableToString()})";
            cmdInsert.ExecuteNonQuery();
        }

        public string FindData(string time)
        {
            var str = "";
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            cmdInsert.CommandText = $"SELECT * FROM {TableName} ";
            cmdInsert.ExecuteNonQuery();

            SQLiteDataReader dataReader = cmdInsert.ExecuteReader();
            while (dataReader.Read())
            {
                if(dataReader["GatherTime"].ToString().Contains(time) == true)
                    str += $"{dataReader["GatherTime"]}  {dataReader["Density"]}  {dataReader["Temperature"]}  {dataReader["Gain"]}   \r\n" ;
            }
            return str;
        }

        public void Close() => conn?.Close();

    }
}
