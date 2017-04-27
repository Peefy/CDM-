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
        public string Gain { get; set; }
        public string DisplaySort { get; set; }

        public override string CreateTableToString()
        {
            return nameof(ID) + " integer, " +
                nameof(Name) + " varchar(30), " +
                nameof(GatherTime) + " varchar(10), " +
                nameof(Density) + " varchar(20), " +
                nameof(Temperature) + " varchar(10), " +
                nameof(Gain) + " varchar(30), " +
                nameof(DisplaySort) + " varchar(10)";


        }

        public override string ValuesTableToString()
        {
            return ID.ToString() + ", " +
                $"'{Name}', " +
                $"'{GatherTime}', " +
                $"'{Density}', " +
                $"'{Temperature}', " +
                $"'{Gain}', " +
                $"'{DisplaySort}'";

        }
    }
}
