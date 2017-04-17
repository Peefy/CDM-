using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM
{
    public class ChartParameters
    {

        float ymax = 20.1f;
        float ymin = 0.1f;

        public float YMax
        {
            get
            {
                return ymax;
            }
            set
            {
                ymax = value;
            }
        }
        public float YMin
        {
            get
            {
                return ymin;
            }
            set
            {
                ymin = value;
            }
        }

        public float XMin { get; set; }
        public float XMax { get; set; }
        public string TotalTitle { get; set; } = "Title";
        public string XTitle { get; set; } = "采样时间/s";
        public string YTitle { get; set; } = "变量";
        public string CurveName { get; set; } = "密度";
    }
}
