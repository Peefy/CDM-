using System;
using System.Collections.Generic;
using System.Text;

namespace CDM管理系统.CDM.Helpers
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
    }
}
