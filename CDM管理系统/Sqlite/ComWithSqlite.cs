using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace CDM.Sqlite
{
    public class ComWithSqlite
    {
        public string TableNameGather { get; set; } = "GatherSave";
        public string DatabaseNameGatner { get; set; } = "MySQLData";
        SQLiteConnection connGather;

        public string TableNameUser { get; set; } = "UserModel";
        public string DatabaseNameUser { get; set; } = "MySQLDataUser";
        SQLiteConnection connUser;

        public ComWithSqlite()
        {
            connGather = null;
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/" + DatabaseNameGatner + ".db";
            connGather = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            connGather.Open();//打开数据库，若文件不存在会自动创建  
            var data = new GatherSave();
            string sql = $"CREATE TABLE IF NOT EXISTS {TableNameGather}({data.CreateTableToString()});";//建表语句  
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, connGather);
            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表  
            //conn.Close();
            connUser = null;
            dbPath = "Data Source =" + Environment.CurrentDirectory + "/" + DatabaseNameUser + ".db";
            connUser = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            connUser.Open();//打开数据库，若文件不存在会自动创建  
            var dataUser = new GatherSave();
            sql = $"CREATE TABLE IF NOT EXISTS {TableNameUser}({data.CreateTableToString()});";//建表语句  
            cmdCreateTable = new SQLiteCommand(sql, connGather);
            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表  
        }

        public void InsertData<T>(T data)  where T : BaseSqliteModel
        {
            SQLiteCommand cmdInsert = new SQLiteCommand(connGather);
            cmdInsert.CommandText = $"INSERT INTO {TableNameGather} VALUES({data.ValuesTableToString()})";
            cmdInsert.ExecuteNonQuery();
        }

        public string FindData(string time)
        {
            var str = "";
            SQLiteCommand cmdInsert = new SQLiteCommand(connGather);
            cmdInsert.CommandText = $"SELECT * FROM {TableNameGather} ";
            cmdInsert.ExecuteNonQuery();
            SQLiteDataReader dataReader = cmdInsert.ExecuteReader();
            while (dataReader.Read())
            {
                if(dataReader["GatherTime"].ToString().Contains(time) == true)
                    str += $"{dataReader["GatherTime"]}|{dataReader["Density"]}|{dataReader["Temperature"]}|{dataReader["K0"]}|{dataReader["K1"]}|{dataReader["K2"]}&" ;
            }
            return str;
        }

        public string FindData(DateTime startTime,DateTime endTime)
        {
            var str = "";
            SQLiteCommand cmdInsert = new SQLiteCommand(connGather);
            cmdInsert.CommandText = $"SELECT * FROM {TableNameGather} ";
            cmdInsert.ExecuteNonQuery();
            var startTimeStr = startTime.ToString("yyyy/MM/dd");
            var endTimeStr = endTime.ToString("yyyy/MM/dd");
            SQLiteDataReader dataReader = cmdInsert.ExecuteReader();
            while (dataReader.Read())
            {
                var timeFindStr = dataReader["GatherTime"].ToString();
                var dateFindStr = timeFindStr.Split('_');
                if (startTimeStr.CompareTo(dateFindStr[0]) != 1 && endTimeStr.CompareTo(dateFindStr[0]) != -1) 
                    str += $"{dataReader["GatherTime"]}|{dataReader["Density"]}|{dataReader["Temperature"]}|{dataReader["K0"]}|{dataReader["K1"]}|{dataReader["K2"]}&";
            }
            return str;
        }

        public void Close()
        {
            connGather?.Close();
            connUser?.Close();
        }

    }
}
