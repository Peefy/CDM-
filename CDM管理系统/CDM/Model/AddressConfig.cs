using System;
using System.Collections.Generic;
using System.Text;


namespace 流量计检定上位机.CDM.Model
{
    /// <summary>
    /// 需要的读CDM的地址
    /// </summary>
    public static class AddressConfig
    {
        public static ushort Density = 249;
        public static ushort Temperature = 251;
        public static ushort K0 = 4001;
        public static ushort K1 = 4003;
        public static ushort K2 = 4005;
        public static ushort K18 = 4007;
        public static ushort K19 = 4009;
    }
}
