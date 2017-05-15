using System;
using System.Collections.Generic;
using System.Text;

namespace CDM.Models
{
    class SaveData
    {
        public DateTime Time { get; set; }
        public float Data { get; set; }
        public static List<SaveData> List = new List<SaveData>();

        public SaveData(DateTime time,float data)
        {
            Time = time;
            Data = data;
        }

        public static List<Sqlite.GatherSave> ListSave = new List<Sqlite.GatherSave>();

    }
}
