using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;

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

        public string ProLinkPath { get; set; } = "";

        public int BaudRateFromIndex
        {
            get
            {
                switch (BaudRateIndex)
                {
                    case 0: return 115200;
                    case 1: return 9600;
                    default: return 9600;
                }
            }
        }

        public StopBits StopBitsFromIndex
        {
            get
            {
                switch (StopBitsIndex)
                {
                    case 0: return StopBits.None;
                    case 1: return StopBits.One;
                    case 2: return StopBits.Two;
                    case 3: return StopBits.OnePointFive;
                    default: return StopBits.One;
                }
            }
        }

        public int DataBitsFromIndex
        {
            get
            {
                switch(DataBitsIndex)
                {
                    case 0:return 6;
                    case 1: return 7;
                    case 2:return 8;
                    case 3:return 9;
                    default:return 8;
                }
            }
        }

        public Parity ParityFromIndex
        {
            get
            {
                switch (ParityIndex)
                {
                    case 0: return Parity.None;
                    case 1: return Parity.Even;
                    case 2: return Parity.Odd;
                    default: return Parity.Even;
                }
            }
        }
    }
}
