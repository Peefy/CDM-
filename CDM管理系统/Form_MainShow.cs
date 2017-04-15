using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;
using Modbus;
using System.Net;
using SocketCom;
using Modbus.Device;
using System.IO.Ports;

using CCWin.SkinControl;

namespace 流量计检定上位机
{
    public partial class Form_MainShow : CCWin.CCSkinMain
    {
        #region 变量

        Form_Main formMain;

        Size FormSetParaSize = new Size(715, 620);
        Size FormNomalSize = new Size(490, 620);
        Size FormAboutSize = new Size(490, 710);

        CDM.ZedGraghUtils zedGraphUtilsDes;
        CDM.ZedGraghUtils zedGraphUtilsTem;
        CDM.ChartParameters paras = new CDM.ChartParameters();
        CDM.Model.SerialPortConfig serialPortConfig = new CDM.Model.SerialPortConfig();
        //create a new SerialPort object with default settings.
        SerialPort serialPort = new SerialPort(); 
        //Modbus Rtu Master
        ModbusSerialMaster master;

        CDM.Para paraDensity;
        CDM.Para paraTem;
        CDM.Para paraYiBiaoXiShu = new CDM.Para() {Up = 1.2,Down = 0.8 };

        public SkinTextBox LabelYMax => labelYmax;
        public SkinTextBox LabelYMin => labelYmin;
        public SkinTextBox DesDown => desDown;
        public SkinTextBox DesUp => desUp;
        public SkinTextBox TemDown => temDown;
        public SkinTextBox TemUp => temUp;
        public TabControl TabControl => tabControl1;

        #endregion
        #region 主窗体初始化
        public Form_MainShow(Form_Main formmain)
        {
            formMain = formmain;
            InitializeComponent();
            zedGraphUtilsDes = new CDM.ZedGraghUtils(zedGraphControl1,this);
            zedGraphUtilsTem = new CDM.ZedGraghUtils(zedGraphControl2,this);
        }

        public void Init()
        {
            #region Init
            #region FormInit
            this.WindowState = FormWindowState.Maximized;
            #endregion
            #region Serialinit
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comcmb.Items.Clear();
            comcmb.Items.AddRange(ports);
            comcmb.SelectedIndex = comcmb.Items.Count > 0 ? 0 : -1;
            #endregion
            #region ZedGraphInit
            zedGraphUtilsDes.Init(new CDM.ChartParameters()
            {
                YTitle = "密度",
                CurveName = "密度",
                TotalTitle = "密度曲线",
                YMin = 500,
                YMax = 1000,
            });
            zedGraphUtilsTem.Init(new CDM.ChartParameters()
            {
                YTitle = "温度",
                CurveName = "温度",
                TotalTitle = "温度曲线",
                YMin = 0,
                YMax = 100,
            });
            timerDraw.Enabled = true;

            #endregion            
            #region FileInit
            CDM.Service.FileService.ReadUserConfig(zedGraphUtilsDes, zedGraphUtilsTem,serialPortConfig);
            zedGraphUtilsDes.RenewDataUpDown();
            zedGraphUtilsTem.RenewDataUpDown();
            #endregion            
            #region DataInit

            flowUnitsComboBox.SelectedIndex = 0;
            MainTabControl.SelectedIndex = 0;
            baudComboBox.SelectedIndex = serialPortConfig.BaudRateIndex;
            stopBitsComboBox.SelectedIndex = serialPortConfig.StopBitsIndex;
            dataBitsComboBox.SelectedIndex = serialPortConfig.DataBitsIndex;
            parityComboBox.SelectedIndex = serialPortConfig.ParityIndex;
            biaoAddressTextbox.Value = serialPortConfig.BiaoAddressValue;

            #endregion
            Thread.Sleep(300);
            #region MiduListInit
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, 1.2f));
            #endregion
            #endregion
        }
        #endregion
        #region MenuView
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        #endregion

        #region FormEvent

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            MainTabControl.Width = Width - 10;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            labelVersion.Text = AppInfo.GetVersionInfo();
       
        }

        public void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (master != null)
            {
                master.Dispose();
                master = null;
            }
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClosingSaveData();
            CDM.Service.FileService.SaveUserConfig(zedGraphUtilsDes, zedGraphUtilsTem,serialPortConfig);
            base.OnFormClosing(e);
        }

        private void ClosingSaveData()
        {
            serialPortConfig.BaudRateIndex = baudComboBox.SelectedIndex;
            serialPortConfig.StopBitsIndex = stopBitsComboBox.SelectedIndex ;
            serialPortConfig.DataBitsIndex  = dataBitsComboBox.SelectedIndex;
            serialPortConfig.ParityIndex = parityComboBox.SelectedIndex;
            serialPortConfig.BiaoAddressValue = biaoAddressTextbox.Value;
        }

        #endregion
        #region ReportAndExcel

        public void MenuItemGenerateReport_Click(object sender, EventArgs e)
        {

        }

        public void MenuItemGenerateExcel_Click(object sender, EventArgs e)
        {

            if(CDM.MiDuData.List.Count == 0)
            {
                MessageBox.Show("没有数据将不予生成");
                return;
            }
            try
            {
                new CDM.ExportExcel().Export(saveFileDialog);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region Print

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = new System.Drawing.Printing.PrintDocument();
            printDialog.ShowDialog();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printToolStripMenuItem_Click(sender, e);
        }

        #endregion
        #region About

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Size.Height < FormAboutSize.Height || this.Size.Width < FormAboutSize.Width)
                this.Size = FormAboutSize;
            labelVersion.Text = AppInfo.GetVersionInfo();
            //groupAbout.Visible = true;
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            //groupAbout.Visible = false;
        }


        #endregion        
        #region ParaSet

        public void SetFlowMeterStad_Click(object sender, EventArgs e)
        {
            
        }

        public void SetFlowMeterWork_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnFlowMeterParaCancel_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        #region ParaSave

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void OpenFile(object sender, EventArgs e)
        {
       
        }



        #endregion
        #region RecievaedTextBox

        private void textRecieved_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string txt = " Received:" + "\r\n" + "";
                //textRecieved.Text = txt;
            }
        }

        #endregion
        #region 标定控制

        public void btnStartDema_Click(object sender, EventArgs e)
        {

        }

        public void btnStopDema_Click(object sender, EventArgs e)
        {

        }

        public void 诊断信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void 诊断结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void btnClearCountShow_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region 保存查询数据
        Form_FindData formFindData;
        public void 查询数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Form_FindData.Count == 0)
            {
                formFindData = new Form_FindData();
                formFindData.MdiParent = formMain;
                formFindData.ControlBox = false;
                formFindData.Show();
            }

        }

        public void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region SerialPort

        bool SerialPortClosing,Listening;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort.IsOpen)
                {
                    SerialPortClosing = true;
                    while (Listening)
                        Application.DoEvents();
                    serialPort.Close();
                    timerGetData.Enabled = false;
                    SerialPortClosing = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(serialPort.IsOpen == false)
            {
                          
                try
                {
                    serialPort.PortName = comcmb.Text;
                    serialPort.BaudRate = 9600;  
                    //serialPort.DataBits = 8;
                    //serialPort.Parity = Parity.None;
                    //serialPort.StopBits = StopBits.None;
                    serialPort.Open();
                    master = ModbusSerialMaster.CreateRtu(serialPort);                 
                    master.Transport.Retries = 0;   //don't have to do retries
                    master.Transport.ReadTimeout = 300; //milliseconds
                    timerGetData.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("串口打开失败！\r\n" + "可能原因:" + ex.Message);
                }
            }
            btnConnect.Text = serialPort.IsOpen ? "关闭" : "打开";
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                if(ports.Length == 0)
                {
                    MessageBox.Show("没有可用的串口，请检查硬件连接");
                }
                Array.Sort(ports);
                comcmb.Items.Clear();
                comcmb.Items.AddRange(ports);
                comcmb.SelectedIndex = comcmb.Items.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Timer

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            zedGraphUtilsDes.TimeDraw(float.Parse(labelMidu.Text));
            zedGraphUtilsTem.TimeDraw(12);
        }

        private void btnStartCurve_Click(object sender, EventArgs e)
        {
            zedGraphUtilsDes.Start();
            timerDraw.Enabled = true;
        }

        private void btnStopCurve_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
        }

        private void btnClearCurve_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            zedGraphUtilsDes.Clear();
            timerDraw.Enabled = true;
        }

        private void btnChangeUpDown_Click(object sender, EventArgs e)
        {
            float ymax, ymin,desdown,desup,temdown,temup,miduxishu;
            try
            {
                ymax = float.Parse(labelYmax.Text);
                ymin = float.Parse(labelYmin.Text);
                desdown = float.Parse(desDown.Text);
                desup = float.Parse(desUp.Text);
                temdown = float.Parse(temDown.Text);
                temup = float.Parse(temUp.Text);
                miduxishu = float.Parse(MiDuXiShuTextBox.Text);
            }
            catch
            {
                MessageBox.Show("输入的数不合规范,请重新输入");
                return;
            }
            paraYiBiaoXiShu.Value = miduxishu;
            if(paraYiBiaoXiShu.IsInRange == false)
            {
                MessageBox.Show($"密度仪表系数的范围在{paraYiBiaoXiShu.Down}到{paraYiBiaoXiShu.Up}之间");
                MiDuXiShuTextBox.Text = paraYiBiaoXiShu.Value.ToString();
                paraYiBiaoXiShu.IsInRange = true;
            }
            paras.YMax = ymax; paras.YMin = ymin;
            
            if (tabControl1.SelectedIndex == 1)
            {
                zedGraphUtilsTem.RenewYScale(paras);
                zedGraphUtilsTem.RenewDataUpDown(temup, temdown);
            }
            if (tabControl1.SelectedIndex == 0)
            {
                zedGraphUtilsDes.RenewYScale(paras);
                zedGraphUtilsDes.RenewDataUpDown(desup, desdown);
            }

        }

        private void flowUnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as SkinComboBox;
            flowUnitsLabel.Text = CDM.FlowUnits.ToTalStrings[comboBox.SelectedIndex];

        }

        private void labelYmax_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeUpDown_Click(null, null);
            }
        }

        private void labelYmin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeUpDown_Click(null, null);
            }
        }

        private void Form_MainShow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeUpDown_Click(null, null);
            }
        }

        private void Form_MainShow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeUpDown_Click(null, null);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = sender as TabControl;
            if(tab.SelectedIndex == 0)
            {
                zedGraphUtilsDes.ReNewFormUpDown();
            }
            else if(tab.SelectedIndex == 1)
            {
                zedGraphUtilsTem.ReNewFormUpDown();
            }
        }

        private void YiBiaoParaSettingButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void hideLineDesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as SkinCheckBox;
            if (check.Checked == true)
                zedGraphUtilsDes.HideUpDownLine();
            else
                zedGraphUtilsDes.RenewDataUpDown();
            zedGraphUtilsDes.IsHideUpDownLine = check.Checked;
        }

        private void hideLineTemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as SkinCheckBox;
            if (check.Checked == true)
                zedGraphUtilsTem.HideUpDownLine();
            else
                zedGraphUtilsTem.RenewDataUpDown();
            zedGraphUtilsTem.IsHideUpDownLine = check.Checked;
        }

        private void renewLineTemButton_Click(object sender, EventArgs e)
        {
            zedGraphUtilsTem.RenewUpDownLine();
        }

        private void renewLineDesButton_Click(object sender, EventArgs e)
        {
            zedGraphUtilsDes.RenewUpDownLine();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {
            try
            {
                byte slaveID = 1;
                ushort startAddress = 0;
                ushort numofPoints = 2;
                ushort[] holdingregister = master.ReadHoldingRegisters(slaveID, startAddress, numofPoints);
                byte[] bytes= { };
                for (int i = 0; i < numofPoints; i++)
                {
                    byte[] byteTemp;
                    byteTemp = BitConverter.GetBytes(holdingregister[i]);
                    bytes = BitConverterHelper.BytesConnect(bytes, byteTemp);
                }
                float val = BitConverterHelper.ToSingle(bytes, 0);
                val = (float)(Math.Round(val, 3));
                labelMidu.Text = val.ToString();
                CDM.MiDuData.List.Add(new CDM.MiDuData(DateTime.Now, val));
            }
            catch (Exception exception)
            {
                //Connection exception
                //No response from server.
                //The server maybe close the com port, or response timeout.
                if (exception.Source.Equals("System"))
                {
                    Console.WriteLine(DateTime.Now.ToString() + " " + exception.Message);
                }
                //The server return error code.
                //You can get the function code and exception code.
                if (exception.Source.Equals("nModbusPC"))
                {
                    string str = exception.Message;
                    int FunctionCode;
                    string ExceptionCode;

                    str = str.Remove(0, str.IndexOf("\r\n", StringComparison.Ordinal) + 17);
                    FunctionCode = Convert.ToInt16(str.Remove(str.IndexOf("\r\n", StringComparison.Ordinal)));
                    Console.WriteLine("Function Code: " + FunctionCode.ToString("X"));

                    str = str.Remove(0, str.IndexOf("\r\n", StringComparison.Ordinal) + 17);
                    ExceptionCode = str.Remove(str.IndexOf("-", StringComparison.Ordinal));
                    switch (ExceptionCode.Trim())
                    {
                        case "1":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal function!");
                            break;
                        case "2":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data address!");
                            break;
                        case "3":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data value!");
                            break;
                        case "4":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Slave device failure!");
                            break;
                    }
                }
            }          
        }
        #endregion


    }
}
