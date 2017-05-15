using System;
using System.Collections.Generic;
using System.Text;

namespace CDM.Sqlite
{
    public class UserModel : BaseSqliteModel
    {
        public string UserName { get; set; } = "dugu";
        public string Password { get; set; } = "123";
        public string ReservedWord { get; set; } = "dugu";

        public override string CreateTableToString()
        {
            return nameof(ID) + " integer, " +
                nameof(Name) + " varchar(30), " +
                nameof(UserName) + " varchar(30), " +
                nameof(Password) + " varchar(30)," +
                nameof(ReservedWord) + " varchar(30),";
        }

        public override string ValuesTableToString()
        {
            return ID.ToString() + ", " +
                $"'{Name}', " +
                $"'{UserName}', " +
                $"'{Password}', " +
                $"'{ReservedWord}'";
        }
    }
}
