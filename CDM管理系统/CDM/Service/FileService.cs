using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 流量计检定上位机.CDM.Service
{
    public class FileService
    {
        static string savePath = "C:\\Program Files\\dugu\\CDM";
        static string userConfigFileName = "\\\\user.uni";

        public static void SaveUserConfig(CDM.ZedGraghUtils des,CDM.ZedGraghUtils tem,Model.SerialPortConfig ser)
        {
            //try
            //{
            if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
            FileStream fs = new FileStream(savePath + userConfigFileName, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);

            w.Write(des.YMax);
            w.Write(des.YMin);
            w.Write(des.DataUp);
            w.Write(des.DataDown);

            w.Write(tem.YMax);
            w.Write(tem.YMin);
            w.Write(tem.DataUp);
            w.Write(tem.DataDown);

            w.Write(ser.BaudRateIndex);
            w.Write(ser.StopBitsIndex);
            w.Write(ser.DataBitsIndex);
            w.Write(ser.ParityIndex);
            w.Write(ser.BiaoAddressValue);

            w.Write(ser.ProLinkPath);

            w.Write(ser.DesValueAddress);
            w.Write(ser.TemValueAddress);

            w.Flush();
            w.Close();
            fs.Close();
            //}
            //catch (Exception es)
            //{
            //    throw (es);
            //}
        }

        public static void ReadUserConfig(CDM.ZedGraghUtils des, CDM.ZedGraghUtils tem,Model.SerialPortConfig ser)
        {           
            try
            {
                if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
                FileStream fs = new FileStream(savePath + userConfigFileName, FileMode.Open);
                using (BinaryReader r = new BinaryReader(fs))
                {
                    des.YMax = r.ReadDouble();
                    des.YMin = r.ReadDouble();
                    des.DataUp = r.ReadDouble();
                    des.DataDown = r.ReadDouble();

                    des.DataUpDragRenew = des.DataUp;
                    des.DataDownDragRenew = des.DataDown;

                    tem.YMax = r.ReadDouble();
                    tem.YMin = r.ReadDouble();
                    tem.DataUp = r.ReadDouble();
                    tem.DataDown = r.ReadDouble();

                    tem.DataUpDragRenew = tem.DataUp;
                    tem.DataDownDragRenew = tem.DataDown;

                    ser.BaudRateIndex = r.ReadInt32();
                    ser.StopBitsIndex = r.ReadInt32();
                    ser.DataBitsIndex = r.ReadInt32();
                    ser.ParityIndex = r.ReadInt32();
                    ser.BiaoAddressValue = r.ReadDecimal();

                    ser.ProLinkPath = r.ReadString();

                    ser.DesValueAddress = r.ReadInt32();
                    ser.TemValueAddress = r.ReadInt32();

                }
                fs.Close();
            }
            catch (Exception es)
            {

            }
        }

    }
}
