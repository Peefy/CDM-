using System;
using System.Collections.Generic;
using System.Text;


namespace CDM.Configs
{
    /// <summary>
    /// 需要的读CDM的地址 地址减1读
    /// </summary>
    public static class AddressConfig
    {
        public static ushort Density { get; } = 249;
        public static ushort Temperature { get; } = 251;
        public static ushort BitsDefine { get; } = 125;
        public static ushort K0 { get; } = 4001;
        public static ushort K1 { get; } = 4003;
        public static ushort K2 { get; } = 4005;
        public static ushort K18 { get; } = 4007;
        public static ushort K19 { get; } = 4009;

        public static ushort DensityUnit { get; } = 40;
        public static ushort TemperatureUnit { get; } = 41;

        public static ushort DensityCoefficient { get; } = 283;

        public static ushort DriveGain { get; } = 291;

        public static ushort A37 { get; } = 424;

        public static ushort A38 { get; } = 434;

    }
}
