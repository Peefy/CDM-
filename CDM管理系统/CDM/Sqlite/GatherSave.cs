using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM.Sqlite
{
    public class GatherSave : BaseSqliteModel
    {
        public string GatherTime { get; set; } = "True";
        public string Density { get; set; }
        public string Temperature { get; set; }
        public string K0 { get; set; }
        public string K1 { get; set; }
        public string K2 { get; set; }

        public override string CreateTableToString()
        {
            return nameof(ID) + " integer, " +
                nameof(Name) + " varchar(30), " +
                nameof(GatherTime) + " varchar(10), " +
                nameof(Density) + " varchar(20), " +
                nameof(Temperature) + " varchar(10), " +
                nameof(K0) + " varchar(30), " +
                nameof(K1) + " varchar(30), " +
                nameof(K2) + " varchar(10)";


        }

        public override string ValuesTableToString()
        {
            return ID.ToString() + ", " +
                $"'{Name}', " +
                $"'{GatherTime}', " +
                $"'{Density}', " +
                $"'{Temperature}', " +
                $"'{K0}', " +
                $"'{K1}', " +
                $"'{K2}'";

        }
    }
}
