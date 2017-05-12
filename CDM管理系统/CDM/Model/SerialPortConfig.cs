using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;

namespace 流量计检定上位机.CDM.Model
{
    public class SerialPortConfig
    {
        public int BaudRateIndex { get; set; } = 3;
        public int StopBitsIndex { get; set; } = 0;
        public int DataBitsIndex { get; set; } = 2;
        public int ParityIndex { get; set; } = 1;
        public decimal BiaoAddressValue { get; set; } = 1;
        public int ProtocolIndex { get; set; } = 0;

        public bool IsOpen { get; set; }
        public bool IsListening { get; set; }

        public string ProLinkPath { get; set; } = "";

        public int DesValueAddress { get; set; } = 100;
        public int TemValueAddress { get; set; } = 200;

        public float K0Value { get; set; } = 1.12f;
        public float K1Value { get; set; } = 0.95f;
        public float K2Value { get; set; } = 1.09f;

        public int BaudRateFromIndex
        {
            get
            {
                switch (BaudRateIndex)
                {
                    case 0: return 1200;
                    case 1: return 2400;
                    case 2: return 4800;
                    case 3: return 9600;
                    case 4: return 19200;
                    case 5: return 38400;
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
                    case 0: return StopBits.One;
                    case 1: return StopBits.Two;
                    case 2: return StopBits.OnePointFive;
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
                    case 1:return 7;
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
