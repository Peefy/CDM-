using CDM.Configs;
using CDM.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace CDM.Service
{
    public class FileService
    {
        const string ParaSaveFilter = "参数保存文件（*.para）|*.para";

        static string savePath = "C:\\Program Files\\dugu\\CDMV1";
        static string userConfigFileName = "\\\\user.uni";

        public static void SaveUserConfig(ZedGraghUtils des,ZedGraghUtils tem,
            ZedGraghUtils drg,SerialPortConfig ser)
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

            w.Write(ser.K0Value);
            w.Write(ser.K1Value);
            w.Write(ser.K2Value);

            w.Write(ser.ProtocolIndex);
            w.Write(ser.DesUnitsSelectIndex);
            w.Write(ser.TemUnitsSelectIndex);

            w.Write(drg.YMax);
            w.Write(drg.YMin);
            w.Write(drg.DataUp);
            w.Write(drg.DataDown);

            w.Flush();
            w.Close();
            fs.Close();
            //}
            //catch (Exception es)
            //{
            //    throw (es);
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="des"></param>
        /// <param name="tem"></param>
        /// <param name="ser"></param>
        public static void ReadUserConfig(ZedGraghUtils des, ZedGraghUtils tem
            ,ZedGraghUtils drg,SerialPortConfig ser)
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

                    ser.K0Value = r.ReadSingle();
                    ser.K1Value = r.ReadSingle();
                    ser.K2Value = r.ReadSingle();

                    ser.ProtocolIndex = r.ReadInt32();
                    ser.DesUnitsSelectIndex = r.ReadInt32();
                    ser.TemUnitsSelectIndex = r.ReadInt32();

                    drg.YMax = r.ReadDouble();
                    drg.YMin = r.ReadDouble();
                    drg.DataUp = r.ReadDouble();
                    drg.DataDown = r.ReadDouble();

                    drg.DataUpDragRenew = drg.DataUp;
                    drg.DataDownDragRenew = drg.DataDown;

                }
                fs.Close();
            }
            catch (Exception es)
            {

            }
        }

        // no
        public static void SavePara(ZedGraghUtils des, 
            ZedGraghUtils tem, SerialPortConfig ser, 
            ZedGraghUtils drg,SaveFileDialog saveFileDialog)
        {
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Filter = ParaSaveFilter;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fst = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件
                fst.Close();
                var savePath = saveFileDialog.FileName.ToString(); //获得文件路径           
                try
                {
                    FileStream fs = new FileStream(savePath, FileMode.Create);
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

                    w.Write(ser.K0Value);
                    w.Write(ser.K1Value);
                    w.Write(ser.K2Value);

                    w.Write(ser.ProtocolIndex);
                    w.Write(ser.DesUnitsSelectIndex);
                    w.Write(ser.TemUnitsSelectIndex);

                    w.Write(drg.YMax);
                    w.Write(drg.YMin);
                    w.Write(drg.DataUp);
                    w.Write(drg.DataDown);

                    w.Flush();
                    w.Close();
                    fs.Close();
                    MessageBox.Show("保存参数成功！");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }
        
        public static bool LoadPara(ZedGraghUtils des, ZedGraghUtils tem, 
            ZedGraghUtils drg,SerialPortConfig ser, OpenFileDialog openFileDialog)
        {
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = ParaSaveFilter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resultFile = openFileDialog.FileName;
                if (File.Exists(resultFile))
                {
                    try
                    {
                        FileStream fs = new FileStream(resultFile, FileMode.Open);
                        BinaryReader r = new BinaryReader(fs);

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

                        ser.K0Value = r.ReadSingle();
                        ser.K1Value = r.ReadSingle();
                        ser.K2Value = r.ReadSingle();

                        ser.ProtocolIndex = r.ReadInt32();
                        ser.DesUnitsSelectIndex = r.ReadInt32();
                        ser.TemUnitsSelectIndex = r.ReadInt32();

                        drg.YMax = r.ReadDouble();
                        drg.YMin = r.ReadDouble();
                        drg.DataUp = r.ReadDouble();
                        drg.DataDown = r.ReadDouble();

                        drg.DataUpDragRenew = drg.DataUp;
                        drg.DataDownDragRenew = drg.DataDown;

                        r.Close();
                        fs.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                }
                return false;
            }
            return false;
        }



    }
}
