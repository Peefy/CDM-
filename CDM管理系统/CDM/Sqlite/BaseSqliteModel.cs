using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;

namespace 流量计检定上位机.CDM.Sqlite
{
    public class BaseSqliteModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }

        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual string CreateTableToString()
        {
            return "";
        }

        public virtual string ValuesTableToString()
        {
            return "";
        }

    }
}
