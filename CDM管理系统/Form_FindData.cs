using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 流量计检定上位机
{
    public partial class Form_FindData : CCWin.CCSkinMain
    {
        public static int Count = 0;
        int FindCount = 0;
        int CountShow = 1;

        public Form_FindData()
        {
            InitializeComponent();
            this.labelTime.Text = DateTime.Now.ToString();
            Count++;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        string getMonthStr(decimal val)
        {
            if (val < 10)
                return "0" + val.ToString();
            else
                return val.ToString();
        }

        string getDayStr(decimal val)
        {
            if (val < 10)
                return "0" + val.ToString();
            else
                return val.ToString();
        }

        private void Form_FindData_Load(object sender, EventArgs e)
        {
            nmupYear.Value = DateTime.Now.Year;
            nmudMonth.Value = DateTime.Now.Month;
            nmudDay.Value = DateTime.Now.Day;

            for (int i = 0; i < 12; ++i)
            {
                rowlabel = new List<Label>();
                for (int j = 0; j < xpoint.Length; ++j)
                {
                    Label labData = new Label();
                    PanelShowDema.Controls.Add(labData);
                    labData.Size = new Size(100, 13);
                    labData.Location = new Point(xpoint[j], i * 15 + 55);
                    labData.Text = "无数据";
                    rowlabel.Add(labData);
                }
                listlabel.Add(rowlabel);
            }

        }

        FileInfo[] dirInfo;
        private void btnStartFind_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string savePath = Directory.GetParent(path).FullName + "\\Log\\" + nmupYear.Value
                + nmudMonth.Value + nmudDay.Value;
            FindCount = 0;
            if (Directory.Exists(savePath) == false)
            {
                labelFindCount.Text = "共查询到" + FindCount + "条记录";
                MessageBox.Show("没查询到任何记录！\r\n" + "请保存数据");
                labelSaveTime.Text = "保存时间：";
                nmudCountShow.Value = 1;nmudCountShow.Maximum = 1;
                CountShow = 1;
                for (int i = 0; i < 12; ++i)
                {
                    for (int j = 0; j < xpoint.Length; ++j)
                    {
                        listlabel[i][j].Text = "无数据";
                    }
                }
                dirInfo = null;
                return;
            }
            DirectoryInfo theFolder = new DirectoryInfo(savePath);
            dirInfo = theFolder.GetFiles();
            foreach(FileInfo NextFile in dirInfo)
            {
                 FindCount++;
            }
            if (FindCount == 0)
            {
                labelFindCount.Text = "共查询到" + FindCount + "条记录";
                MessageBox.Show("没查询到任何记录！");
                labelSaveTime.Text = "保存时间：" ;
                nmudCountShow.Value = 1; nmudCountShow.Maximum = 1;
                CountShow = 1;
                for (int i = 0; i < 12; ++i)
                {
                    for (int j = 0; j < xpoint.Length; ++j)
                    {
                        listlabel[i][j].Text = "无数据";
                    }
                }
            }
            else
            {
                labelFindCount.Text = "共查询到" + FindCount + "条记录";
                MessageBox.Show("共查询到" + FindCount + "记录\r\n当前显示第一条");
                nmudCountShow.Maximum = FindCount;
                nmudCountShow_ValueChanged(sender, e);
            }
            
        }

        int[] xpoint = { 40, 140, 240, 340, 440, 540, 640 };
        List<List<Label>> listlabel = new List<List<Label>>();
        List<List<Label>> listlabelZhenduan = new List<List<Label>>();
        List<Label> rowlabel;
        List<DemarcateMotionSave> list =  new List<DemarcateMotionSave>();
        private void nmudCountShow_ValueChanged(object sender, EventArgs e)
        {
            if(sender != null)
                CountShow = (int)nmudCountShow.Value;
            list.Clear() ;
            string saveTime;
            if(dirInfo != null)
            {
                string filePath = dirInfo[CountShow - 1].FullName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    saveTime = r.ReadString();
                    for(int i = 0;i<12 ;++i)
                    {
                        DemarcateMotionSave demamotion = new DemarcateMotionSave();
                        #region 读取的数据或字符串
                        demamotion.FlowDema = r.ReadSingle();
                        demamotion.StanPulseCount = r.ReadInt32();
                        demamotion.StanFlowSum = r.ReadSingle();
                        demamotion.WorkPulseCount = r.ReadInt32();
                        demamotion.WorkFlowSum = r.ReadSingle();
                        demamotion.Error = r.ReadSingle();
                        demamotion.MeterFactor = r.ReadSingle();
                        #endregion
                        list.Add(demamotion);
                    }
                    r.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }

                labelSaveTime.Text = "保存时间：" + saveTime;
                for (int i = 0; i < 12; ++i)
                {
                    for (int j = 0; j < xpoint.Length; ++j)
                    {
                        listlabel[i][j].Text = Math.Round( list[i].Para[j],3).ToString();
                    }
                }
            }
        }

        private void btnShang_Click(object sender, EventArgs e)
        {
            if (FindCount == 0)
                return;
            CountShow++;
            if (CountShow > FindCount)
                CountShow = 1;
            nmudCountShow.Value = CountShow;
            nmudCountShow_ValueChanged(null, null);
        }

        private void btnXia_Click(object sender, EventArgs e)
        {
            if (FindCount == 0)
                return;
            CountShow--;
            if (CountShow < 1)
                CountShow = FindCount;
            nmudCountShow.Value = CountShow;
            nmudCountShow_ValueChanged(null, null);
        }

        private void Form_FindData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Count--;
        }

        #region ReportAndExcel

        public void MenuItemGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if(listlabel[1][1].Text != "无数据")
                {
                    new ExportReporter(list).Export(saveFileDialog);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void MenuItemGenerateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listlabel[1][1].Text != "无数据")
                    new ExportExcel(list).Export(saveFileDialog);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

    }
}
