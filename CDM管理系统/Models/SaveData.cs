using System;
using System.Collections.Generic;
using System.Text;

namespace CDM.Models
{
    class SaveData
    {
        public DateTime Time { get; set; }
        public float Data { get; set; }
        public SaveData(DateTime time,float data)
        {
            Time = time;
            Data = data;
        }

        public static string DesUnitText { get; set; } = "";
        public static string TemUnitText { get; set; } = "";

        public static List<Sqlite.GatherSave> ListSave = new List<Sqlite.GatherSave>();
        public static List<Sqlite.GatherSave> ListSaveFind = new List<Sqlite.GatherSave>();
    }
}
