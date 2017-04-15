using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM.Model
{
    public class SerialPortConfig
    {
        public int BaudRateIndex { get; set; } = 1;
        public int StopBitsIndex { get; set; } = 1;
        public int DataBitsIndex { get; set; } = 2;
        public int ParityIndex { get; set; } = 1;
        public decimal BiaoAddressValue { get; set; } = 1;

        public bool IsOpen { get; set; }
        public bool IsListening { get; set; }

    }
}
