using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机.CDM
{
    public class Para
    {

        double _value;

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value > Up)
                {
                    _value = Up;
                    IsInRange = false;
                }
                else if(value < Down)
                {
                    _value = Down;
                    IsInRange = false;
                }
                else
                {
                    _value = value;
                    IsInRange = true;
                }
            }
        }

        public double Up { get; set; }
        public double Down { get; set; }

        public bool IsInRange { get; set; } = true;

    }
}
