using System;
using System.IO;
using System.Windows.Forms;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using CDM.Utils;

namespace CDM.Models
{
    class ExportExcel
    {
        const string ExcelSaveFilter = "生成excel（*.xls）|*.xls";
        //string strHeaderText = "采集数据";

        public int ColumnCount { get; private set; } = 5;

        public bool IsFindData { get; set; }

        public void Export(SaveFileDialog saveFileDialog)
        {
            try
            {
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Filter = ExcelSaveFilter;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var savePath = saveFileDialog.FileName;
                    using (MemoryStream ms = Export(true))
                    {
                        using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                        {
                            byte[] data = ms.ToArray();
                            fs.Write(data, 0, data.Length);
                            fs.Flush();
                        }
                    }
                    MessageBox.Show("生成Excel成功！");
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void ExportPath(string fileName)
        {
            var fullFileName = fileName + ".xls";
            var startPath = Application.StartupPath;
            var savePath = startPath + "\\ExcelData\\" ;
            if (Directory.Exists(savePath) == false) Directory.CreateDirectory(savePath);
            using (MemoryStream ms = Export(true))
            {
                using (FileStream fs = new FileStream(savePath + fullFileName, FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
            }
        }

        MemoryStream Export(bool isPrivate)
        {
            HSSFWorkbook workBook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workBook.CreateSheet();

            #region 右击文件属性信息
            {
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();

                dsi.Company = "DuGu";
                workBook.DocumentSummaryInformation = dsi;

                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Author = "DuGu";
                si.ApplicationName = "DuGu_NPOI_" + AppInfo.GetName();
                si.LastAuthor = "DuGu";
                si.Comments = "DuGu";
                si.Title = "DuGu";
                si.Subject = "DemarcateResults";
                si.CreateDateTime = DateTime.Now;
                workBook.SummaryInformation = si;

            }
            #endregion

            HSSFCellStyle dateStyle = (HSSFCellStyle)workBook.CreateCellStyle();
            HSSFDataFormat format = (HSSFDataFormat)workBook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            int[] arrColWidth = { 20, 20, 20, 20, 20, 20, 20, 20 };
            #region 表头样式
            HSSFRow headerRow;
            HSSFCellStyle headStyle = (HSSFCellStyle)workBook.CreateCellStyle();
            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            HSSFFont font = (HSSFFont)workBook.CreateFont();
            #endregion

            headerRow = (HSSFRow)sheet.CreateRow(0);
            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            font.FontHeightInPoints = 15;
            font.Boldweight = 400;
            headStyle.SetFont(font);

            headerRow.CreateCell(0).SetCellValue("日期");
            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            headerRow.GetCell(0).CellStyle = headStyle;

            headerRow.CreateCell(1).SetCellValue("时间");
            headerRow.GetCell(1).CellStyle = headStyle;

            headerRow.CreateCell(2).SetCellValue($"密度({SaveData.DesUnitText})");
            headerRow.GetCell(2).CellStyle = headStyle;

            headerRow.CreateCell(3).SetCellValue($"温度({SaveData.TemUnitText})");
            headerRow.GetCell(3).CellStyle = headStyle;

            headerRow.CreateCell(4).SetCellValue("驱动增益(%)");
            headerRow.GetCell(4).CellStyle = headStyle;

            //headerRow.CreateCell(4).SetCellValue("K1");
            //headerRow.GetCell(4).CellStyle = headStyle;

            //headerRow.CreateCell(5).SetCellValue("K2");
            //headerRow.GetCell(5).CellStyle = headStyle;
            var list = IsFindData == false ?SaveData.ListSave : SaveData.ListSaveFind;
            for (int i = 0; i < list.Count; ++i)
            {
                headerRow = (HSSFRow)sheet.CreateRow(i + 1);
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                font.FontHeightInPoints = 15;
                font.Boldweight = 400;
                headStyle.SetFont(font);

                var data = list[i].GatherTime.Split('_');

                headerRow.CreateCell(0).SetCellValue(data[0]);
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
                headerRow.GetCell(0).CellStyle = headStyle;

                headerRow.CreateCell(1).SetCellValue(data[1]);
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
                headerRow.GetCell(1).CellStyle = headStyle;
               
                headerRow.CreateCell(2).SetCellValue(double.Parse(list[i].Density));
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
                headerRow.GetCell(2).SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                headerRow.GetCell(2).CellStyle = headStyle;

                headerRow.CreateCell(3).SetCellValue(double.Parse(list[i].Temperature));
                headerRow.GetCell(3).SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                headerRow.GetCell(3).CellStyle = headStyle;

                headerRow.CreateCell(4).SetCellValue(double.Parse(list[i].K0));
                headerRow.GetCell(4).SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                headerRow.GetCell(4).CellStyle = headStyle;

                //headerRow.CreateCell(4).SetCellValue(CDM.MiDuData.ListSave[i].K1);
                //headerRow.GetCell(4).CellStyle = headStyle;

                //headerRow.CreateCell(5).SetCellValue(CDM.MiDuData.ListSave[i].K2);
                //headerRow.GetCell(5).CellStyle = headStyle;

            }
            sheet.SetColumnWidth(0, 20 * 256);
            sheet.SetColumnWidth(1, 20 * 256);
            sheet.SetColumnWidth(2, 30 * 256);
            sheet.SetColumnWidth(3, 30 * 256);
            sheet.SetColumnWidth(4, 20 * 256);
            using (MemoryStream ms = new MemoryStream())
            {
                workBook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                return ms;
            }
        }

    }
}
