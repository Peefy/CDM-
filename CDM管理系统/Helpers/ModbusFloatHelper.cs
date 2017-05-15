using System;
using System.Collections.Generic;
using System.Text;

namespace CDM.Helpers
{
    public static class ModbusFloatHelper
    {
        public static float UshortToFloat(ushort[] datas, int index,int digits)
        {
            List<byte> tmp = new List<byte>();
            tmp.AddRange(BitConverter.GetBytes(datas[index]));
            tmp.AddRange(BitConverter.GetBytes(datas[index + 1]));
            var result = BitConverter.ToSingle(tmp.ToArray(), 0);
            result = (float)(Math.Round(result, digits));
            return result;
        }

        public static ushort[] FloatToUshort(float data)
        {
            byte[] bytes = BitConverter.GetBytes(data);
            ushort[] goal = new ushort[2];
            goal[0] = BitConverter.ToUInt16(bytes, 0);
            goal[1] = BitConverter.ToUInt16(bytes, 2);
            return goal;          
        }

    }
}
