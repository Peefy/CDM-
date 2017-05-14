using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM
{
    /// <summary>
    /// 
    /// </summary>
    public class ParaUnits
    {
        /// <summary>
        /// 
        /// </summary>
        public static string[] DesToTalStrings { get; set; } =
        {
            "千克/立方米",
            "克/升",
            "克/毫升",
            "千克/升",
            "克/立方厘米",
        };

        public static Dictionary<int, string> DesTable = new Dictionary<int, string>
        {
            {90, "特殊重量单位" },
            {91, "克/立方厘米" },
            {92, "千克/立方米" },
            {93, "磅/加仑 " },
            {94, "磅/立方英尺"},
            {95, "克/毫升" },
            {96, "千克/升" },
            {97, "克/升" },
            {98, "磅/立方英寸" },
            {99, "短吨/立方码" },
            {104, "Degrees API" },
        };

        public static Dictionary<int, string> TemTable = new Dictionary<int, string>
        {
            {32, "摄氏度" },
            {33, "华氏度" },
            {34, "朗肯度" },
            {35, "卡尔文" },
        };

        /// <summary>
        /// 
        /// </summary>
        public static string[] TemToTalStrings { get; set; } =
        {
            "摄氏度",
            "华氏度",
            "朗肯度",
            "卡尔文",
        };

    }
}
