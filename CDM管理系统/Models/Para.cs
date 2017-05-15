using System;
using System.Collections.Generic;
using System.Text;

namespace CDM.Models
{
    public class Para
    {

        float _value;

        public float Value
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

        public float Up { get; set; }
        public float Down { get; set; }

        public bool IsInRange { get; set; } = true;

    }
}
