using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

using Modbus.Device;
using CCWin.SkinControl;
using System.Collections.Generic;

using CDM管理系统;
using CDM.Utils;
using CDM.Configs;
using CDM.Helpers;
using CDM.Models;

namespace 流量计检定上位机
{
    public partial class Form_MainShow : CCWin.CCSkinMain

    {
        #region 变量

        Form_Main formMain;

        Size FormSetParaSize = new Size(715, 620);
        Size FormNomalSize = new Size(490, 620);
        Size FormAboutSize = new Size(490, 710);

        ZedGraghUtils zedGraphUtilsDes;
        ZedGraghUtils zedGraphUtilsTem;
        ZedGraghUtils zedGraphUtilsDriveGain;

        ChartParameters paras = new ChartParameters();
        SerialPortConfig serialPortConfig = new SerialPortConfig();

        Para paraDensity = new Para() { Value = 1,Up = 100000,Down = 0};
        Para paraTem = new Para() { Value = 1 ,Up = 100000,Down = 0};
        Para paraDriveGain = new Para() { Value = 1, Up = 100000, Down = 0 };

        Para K0_XiShu = new Para() {Up = 1.2f,Down = 0.8f };
        Para K1_XiShu = new Para() { Up = 1.3f, Down = 0.7f };
        Para K2_XiShu = new Para() { Up = 1.4f, Down = 0.6f };

        CDM.Sqlite.ComWithSqlite ComWithSqliteServer;

        List<CDM.Sqlite.GatherSave> SaveDatas;

        //create a new SerialPort object with default settings.
        SerialPort serialPort = new SerialPort(); 
        //Modbus Rtu Master
        ModbusSerialMaster master;

        public SkinTextBox LabelYMax => labelYmax;
        public SkinTextBox LabelYMin => labelYmin;
        public SkinTextBox DesDown => desDown;
        public SkinTextBox DesUp => desUp;
        public SkinTextBox TemDown => temDown;
        public SkinTextBox TemUp => temUp;
        public SkinTextBox DrgDown => drgDown;
        public SkinTextBox DrgUp => drgUp;

        public ZedGraghUtils ZedGraphUtilsDes => zedGraphUtilsDes;
        public ZedGraghUtils ZedGraphUtilsTem => zedGraphUtilsTem;
        public ZedGraghUtils ZedGraphUtilsDriveGain => zedGraphUtilsDriveGain;

        public TabControl TabControl => tabControl1;
        public bool GraphEnable => timerDraw.Enabled;
        public bool CurveFollow => curveCheckBox.Checked;

        public double TimeDraw_s => timerDraw.Interval / 1000.0;

        public byte SlaveAddress => (byte)(biaoAddressTextbox.Value);

        #endregion
        #region 主窗体初始化
        public Form_MainShow(Form_Main formmain)
        {
            formMain = formmain;
            InitializeComponent();
            ComWithSqliteServer = new CDM.Sqlite.ComWithSqlite();
            zedGraphUtilsDes = new ZedGraghUtils(zedGraphControl1,this);
            zedGraphUtilsTem = new ZedGraghUtils(zedGraphControl2, this)
            {
                DataDown = 10,
                DataUp = 50,
            };
            zedGraphUtilsDriveGain = new ZedGraghUtils(zedGraphControl3, this)
            {
                DataDown = 0.5f,
                DataUp = 3,
            };
            SaveDatas = new List<CDM.Sqlite.GatherSave>();

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
            zedGraphUtilsDes.Init(new ChartParameters()
            {
                YTitle = "密度",
                CurveName = "密度",
                TotalTitle = "密度曲线",
                YMin = 500,
                YMax = 1000,
            });
            zedGraphUtilsTem.Init(new ChartParameters()
            {
                YTitle = "温度",
                CurveName = "温度",
                TotalTitle = "温度曲线",
                YMin = 0,
                YMax = 100,
            });
            zedGraphUtilsDriveGain.Init(new ChartParameters()
            {
                YTitle = "驱动增益",
                CurveName = "驱动增益",
                TotalTitle = "驱动增益曲线",
                YMin = 0,
                YMax = 4,
            });
            //timerDraw.Enabled = true;

            #endregion            
            #region FileInit
            CDM.Service.FileService.ReadUserConfig(zedGraphUtilsDes, zedGraphUtilsTem,
                zedGraphUtilsDriveGain,serialPortConfig);

            #endregion            
            #region DataInit

            paraDensity.Value = 1;
            paraTem.Value = 1;

            DateTime timeNow = DateTime.Now;
            nmupYear.Value = timeNow.Year;
            nmupMonth.Value = timeNow.Month;
            nmupDay.Value = timeNow.Day;
            nmupHour.Value = timeNow.Hour;
            mnupMin.Value = timeNow.Minute;

            //flowUnitsComboBox.SelectedIndex = 0;
            MainTabControl.SelectedIndex = 0;

            OpenFileRenewData();

            #endregion
            Thread.Sleep(200);
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

        public void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_UserConfig(ComWithSqliteServer).ShowDialog();
        }

        public void 串口连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSerialConfigForm();          
        }

        string comName = "";
        private void ShowSerialConfigForm()
        {
            if(serialPortConfig.PortIsOpen == false)
            {
                var form = new Form_SerialConfig(serialPortConfig);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    baudComboBox.SelectedIndex = serialPortConfig.BaudRateIndex;
                    stopBitsComboBox.SelectedIndex = serialPortConfig.StopBitsIndex;
                    dataBitsComboBox.SelectedIndex = serialPortConfig.DataBitsIndex;
                    parityComboBox.SelectedIndex = serialPortConfig.ParityIndex;
                    protocolComboBox.SelectedIndex = serialPortConfig.ProtocolIndex;
                    comName = form.ComText;
                    btnConnect_Click(null, null);
                }
            }         
            else 
            {
                master = null;
                serialPort?.Close();
                serialPort?.Dispose();
                timerDraw.Enabled = false;
                timerSave.Enabled = false;
                labelConnect.Text = "未连接";
                pictureBoxConnect.BackColor = Color.Red;
                serialPortConfig.PortIsOpen = false;
                labelStatus.Text = "端口关闭";
                MessageBox.Show("断开连接!");
            }

        }

        public void 参数设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (master != null && serialPortConfig.PortIsOpen == true)
                new Form_ParaSetting(master, SlaveAddress).ShowDialog();
            else
                MessageBox.Show("仪表还未连接或者端口未打开!");
        }

        #endregion
        #region FormEvent

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            MainTabControl.Width = Width - 10;
            //panelLocation3.Location = new Point(MainTabControl.Width / 2 - panelLocation3.Width / 2, 
              //  MainTabControl.Height / 2 - panelLocation3.Height / 2);
            panelLocation2.Location = new Point(MainTabControl.Width / 2 - panelLocation2.Width / 2,
                MainTabControl.Height / 2 - panelLocation2.Height / 2);
            panelLocation1.Location = new Point(MainTabControl.Width / 2 - panelLocation1.Width / 2,
                MainTabControl.Height / 2 - panelLocation1.Height / 2);
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
            if (ComWithSqliteServer != null)
            {
                ComWithSqliteServer.Close();
                ComWithSqliteServer = null;
            }

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ShowSerialConfigForm();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClosingSaveData();
            CDM.Service.FileService.SaveUserConfig(zedGraphUtilsDes, zedGraphUtilsTem,
                zedGraphUtilsDriveGain,serialPortConfig);
            base.OnFormClosing(e);
        }

        private void ClosingSaveData()
        {
            serialPortConfig.BaudRateIndex = baudComboBox.SelectedIndex;
            serialPortConfig.StopBitsIndex = stopBitsComboBox.SelectedIndex ;
            serialPortConfig.DataBitsIndex  = dataBitsComboBox.SelectedIndex;
            serialPortConfig.ParityIndex = parityComboBox.SelectedIndex;
            serialPortConfig.ProtocolIndex = protocolComboBox.SelectedIndex;
            serialPortConfig.BiaoAddressValue = biaoAddressTextbox.Value;
            serialPortConfig.ProLinkPath = exEXEPathTextBox.Text;
            serialPortConfig.DesUnitsSelectIndex = flowUnitsComboBox.SelectedIndex;
            serialPortConfig.TemUnitsSelectIndex = temUnitsComboBox.SelectedIndex;
            serialPortConfig.K0Value = K0_XiShu.Value;
            serialPortConfig.K1Value = K1_XiShu.Value;
            serialPortConfig.K2Value = K2_XiShu.Value;

            serialPortConfig.DesValueAddress =
                AddressConfig.Density;
            serialPortConfig.TemValueAddress =
                AddressConfig.Temperature;

        }

        private void OpenFileRenewData()
        {
            zedGraphUtilsDes.RenewDataUpDown();
            zedGraphUtilsTem.RenewDataUpDown();
            zedGraphUtilsDriveGain.RenewDataUpDown();
            baudComboBox.SelectedIndex = serialPortConfig.BaudRateIndex;
            stopBitsComboBox.SelectedIndex = serialPortConfig.StopBitsIndex;
            dataBitsComboBox.SelectedIndex = serialPortConfig.DataBitsIndex;
            parityComboBox.SelectedIndex = serialPortConfig.ParityIndex;
            protocolComboBox.SelectedIndex = serialPortConfig.ProtocolIndex;
            biaoAddressTextbox.Value = serialPortConfig.BiaoAddressValue;
            exEXEPathTextBox.Text = serialPortConfig.ProLinkPath;

            flowUnitsComboBox.SelectedIndex = serialPortConfig.DesUnitsSelectIndex;
            temUnitsComboBox.SelectedIndex = serialPortConfig.TemUnitsSelectIndex;

            K0_XiShu.Value = serialPortConfig.K0Value;
            K1_XiShu.Value = serialPortConfig.K1Value;
            K2_XiShu.Value = serialPortConfig.K2Value;

            //K0_TextBox.Text = K0_XiShu.Value.ToString();
            //K1_TextBox.Text = K1_XiShu.Value.ToString();
            //K2_TextBox.Text = K2_XiShu.Value.ToString();



        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            //base.OnMouseWheel(e);
        }

        #endregion
        #region ReportAndExcel

        public void MenuItemGenerateReport_Click(object sender, EventArgs e)
        {

        }

        public void MenuItemGenerateExcel_Click(object sender, EventArgs e)
        {

            if(SaveData.ListSave.Count == 0)
            {
                MessageBox.Show("没有数据将不予生成");
                return;
            }
            try
            {
                //new Thread(new ThreadStart(() =>
                //{
                    new ExportExcel().Export(saveFileDialog);
                //})).Start();
            }
            catch (Exception ex)
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
            CDM.Service.FileService.SavePara(zedGraphUtilsDes, zedGraphUtilsTem 
                ,serialPortConfig,zedGraphUtilsDriveGain, saveFileDialog);
        }

        public void OpenFile(object sender, EventArgs e)
        {
            if( CDM.Service.FileService.LoadPara(zedGraphUtilsDes, zedGraphUtilsTem, 
                zedGraphUtilsDriveGain,serialPortConfig, openFileDialog) == true)
            {
                OpenFileRenewData();
                btnChangeUpDown_Click(null, null);
                MessageBox.Show("读取参数成功!");
            }
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
        public void 查询数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        public void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosingSaveData();
        }

        #endregion
        #region SerialPort

        bool SerialPortClosing;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            try
            {
                if(serialPort.IsOpen)
                {
                    SerialPortClosing = true;
                    timerGetData.Enabled = false;
                    master.Dispose();
                    serialPort.Close();
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
                    
                    serialPort.PortName = comName;
                    serialPort.BaudRate = serialPortConfig.BaudRateFromIndex;  
                    serialPort.DataBits = serialPortConfig.DataBitsFromIndex;
                    serialPort.Parity = serialPortConfig.ParityFromIndex;    
                    serialPort.StopBits = serialPortConfig.StopBitsFromIndex;//一般是1位停止位
                    serialPort.Open();
                    if (protocolComboBox.SelectedIndex == 0)
                        master = ModbusSerialMaster.CreateRtu(serialPort);
                    else
                        master = ModbusSerialMaster.CreateAscii(serialPort);
                    master.Transport.Retries = 0;   
                    master.Transport.ReadTimeout = 300; //milliseconds
                    timerGetData.Enabled = true;
                    labelStatus.Text = "端口打开成功！";
                    labelConnect.Text = "已连接";
                    pictureBoxConnect.BackColor = Color.Lime;
                    serialPortConfig.PortIsOpen = true;
                    //timerDraw.Enabled = true;
                    //timerSave.Enabled = true;
                    MessageBox.Show("串口打开成功！");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"串口打开失败！\r\n可能原因:{ex.Message}");
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

            ClosingSaveData();
            if(serialPort.IsOpen == false)
            {
                timerDraw.Enabled = false;
                timerSave.Enabled = false;
                labelConnect.Text = "未连接";
                pictureBoxConnect.BackColor = Color.Red;
                serialPortConfig.PortIsOpen = false;
                labelStatus.Text = "端口关闭";
                btnOpenConnect.Text = serialPortConfig.PortIsOpen ? "断开连接" : "仪表连接";
            }
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {         
            zedGraphUtilsDes.TimeDraw(paraDensity.Value);
            zedGraphUtilsTem.TimeDraw(paraTem.Value);
            zedGraphUtilsDriveGain.TimeDraw(paraDriveGain.Value);
            desWarningFlag.BackColor =
                zedGraphUtilsDes.IsWarning == true ? Color.Red : Color.Lime;
            temWarningFlag.BackColor =
                zedGraphUtilsTem.IsWarning == true ? Color.Red : Color.Lime;
            drgWarningFlag.BackColor =
                zedGraphUtilsDriveGain.IsWarning == true ? Color.Red : Color.Lime;
        }

        private void btnStartCurve_Click(object sender, EventArgs e)
        {
            zedGraphUtilsDes.Start();
            timerDraw.Enabled = true;
        }

        bool enableDraw = true;
        private void btnStopCurve_Click(object sender, EventArgs e)
        {
            var btn = sender as SkinButton;
            enableDraw = !enableDraw;
            btn.Text = enableDraw == true ? "暂停实时曲线" : "开始实时曲线";
            zedGraphUtilsDes.EnableDraw = enableDraw;
            zedGraphUtilsTem.EnableDraw = enableDraw;
            zedGraphUtilsDriveGain.EnableDraw = enableDraw;
        }

        private void btnClearCurve_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            zedGraphUtilsDes.Clear();
            zedGraphUtilsTem.Clear();
            zedGraphUtilsDriveGain.Clear();
            timerDraw.Enabled = true;
        }

        private void btnChangeUpDown_Click(object sender, EventArgs e)
        {
            float ymax, ymin,desdown,desup,temdown,temup,drgdown,drgup,k0,k1,k2;
            try
            {
                ymax = float.Parse(labelYmax.Text);
                ymin = float.Parse(labelYmin.Text);
                desdown = float.Parse(desDown.Text);
                desup = float.Parse(desUp.Text);
                temdown = float.Parse(temDown.Text);
                temup = float.Parse(temUp.Text);
                drgdown = float.Parse(drgDown.Text);
                drgup = float.Parse(drgUp.Text);
                //k0 = float.Parse(K0_TextBox.Text);
                //k1 = float.Parse(K1_TextBox.Text);
                //k2 = float.Parse(K2_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("输入的数不合规范,请重新输入");
                return;
            }
            //K0_XiShu.Value = k0;
            if(K0_XiShu.IsInRange == false)
            {
                MessageBox.Show($"K0系数的范围在{K0_XiShu.Down}到{K0_XiShu.Up}之间");
                //K0_TextBox.Text = K0_XiShu.Value.ToString();
                K0_XiShu.IsInRange = true;
            }

            //K1_XiShu.Value = k1;
            if (K1_XiShu.IsInRange == false)
            {
                MessageBox.Show($"K1系数的范围在{K1_XiShu.Down}到{K1_XiShu.Up}之间");
                //K1_TextBox.Text = K1_XiShu.Value.ToString();
                K1_XiShu.IsInRange = true;
            }

            //K2_XiShu.Value = k2;
            if (K2_XiShu.IsInRange == false)
            {
                MessageBox.Show($"K2系数的范围在{K2_XiShu.Down}到{K2_XiShu.Up}之间");
                //K2_TextBox.Text = K2_XiShu.Value.ToString();
                K2_XiShu.IsInRange = true;
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
            if (tabControl1.SelectedIndex == 2)
            {
                zedGraphUtilsDriveGain.RenewYScale(paras);
                zedGraphUtilsDriveGain.RenewDataUpDown(drgup, drgdown);
            }
            //ModbusSetK012();

        }

        private void ModbusSetK012()
        {

            if(serialPort.IsOpen == true)
            {
                ushort[] sendUShort = { };
                ushort[] ushorts = BitConverterHelper.SingleToUShort(K0_XiShu.Value);
                sendUShort = BitConverterHelper.UShortConnect(sendUShort, ushorts);
                ushorts = BitConverterHelper.SingleToUShort(K1_XiShu.Value);
                sendUShort = BitConverterHelper.UShortConnect(sendUShort, ushorts);
                ushorts = BitConverterHelper.SingleToUShort(K2_XiShu.Value);
                sendUShort = BitConverterHelper.UShortConnect(sendUShort, ushorts);

                try
                {
                    master?.WriteMultipleRegisters(SlaveAddress,
                      (ushort)(AddressConfig.K0 - 1), sendUShort);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            

            }

        }

        private void flowUnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as SkinComboBox;
            var index = comboBox.SelectedIndex;
            ushort[] desUnitCode = { 92, 97, 95, 96, 91 };
            master?.WriteMultipleRegisters(SlaveAddress, 
                (ushort)(AddressConfig.DensityUnit - 1),
                new ushort[] { desUnitCode[index] });
            nmupYear.Select();
            
        }


        private void temUnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as SkinComboBox;
            var index = comboBox.SelectedIndex;
            ushort[] temUnitCode = { 32, 33, 34, 35 };
            master?.WriteMultipleRegisters(SlaveAddress, 
                (ushort)(AddressConfig.TemperatureUnit - 1),
                new ushort[] { temUnitCode[index] });
            nmupYear.Select();
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
            else if(tab.SelectedIndex == 2)
            {
                zedGraphUtilsDriveGain.ReNewFormUpDown();
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

        private void hideLineDrgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as SkinCheckBox;
            if (check.Checked == true)
                zedGraphUtilsDriveGain.HideUpDownLine();
            else
                zedGraphUtilsDriveGain.RenewDataUpDown();
            zedGraphUtilsDriveGain.IsHideUpDownLine = check.Checked;
        }

        private void renewLineTemButton_Click(object sender, EventArgs e)
        {
            zedGraphUtilsTem.RenewUpDownLine();
        }

        private void renewLineDesButton_Click(object sender, EventArgs e)
        {
            zedGraphUtilsDes.RenewUpDownLine();
        }

        private void renewLineDrgButton_Click(object sender, EventArgs e)
        {
            zedGraphUtilsDriveGain.RenewUpDownLine();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void startupExEXEButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(serialPortConfig.ProLinkPath);
            }
            catch
            {

            }
            
        }

        private void findExEXEButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exEXEPathTextBox.Text = openFileDialog.FileName;
                serialPortConfig.ProLinkPath = exEXEPathTextBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timerGetData.Enabled = false;
            master?.WriteMultipleRegisters(1, 0, new ushort[] { 0x1234, 0x2222,0x2135 });
            //timerGetData.Enabled = true;
        }

        private void desAddressNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var updown = sender as SkinNumericUpDown;
            serialPortConfig.DesValueAddress = Convert.ToInt32(updown.Value);
        }

        private void temAddressNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var updown = sender as SkinNumericUpDown;
            serialPortConfig.TemValueAddress = Convert.ToInt32(updown.Value);
        }

        float GetDesTemData(int dataAddress)
        {
            byte slaveID = Convert.ToByte(serialPortConfig.BiaoAddressValue);
            ushort startAddress = (ushort)dataAddress;
            ushort numofPoints = 2;  //数据帧中 word 的数量
            ushort[] holdingregister = master.ReadHoldingRegisters(slaveID, startAddress, numofPoints);
            byte[] bytes = { };
            for (int i = 0; i < numofPoints * 2; i++)
            {
                byte[] byteTemp;
                byteTemp = BitConverter.GetBytes(holdingregister[i]);
                bytes = BitConverterHelper.BytesConnect(bytes, byteTemp);
            }
            float val = BitConverterHelper.ToSingle(bytes, 0);
            val = (float)(Math.Round(val, 3));
            return val;
        }

        void GetDesTemDrgData(out float des,out float tem,out float drg)
        {
            byte slaveID = SlaveAddress;
            ushort startAddress = (ushort)(AddressConfig.Density - 1);
            ushort numofPoints = 20;  //数据帧中 word 的数量
            ushort[] holdingregister = master.ReadInputRegisters(slaveID, startAddress, numofPoints);

            var dataDriveGain = master.ReadInputRegisters(SlaveAddress,
                (ushort)(AddressConfig.DriveGain - 1), 2);

            byte[] bytes = { };
            for (int i = 0; i < numofPoints; i++)
            {
                byte[] byteTemp;
                byteTemp = BitConverter.GetBytes(holdingregister[i]);
                bytes = BitConverterHelper.BytesConnect(bytes, byteTemp);
            }

            des = ModbusFloatHelper.UshortToFloat(holdingregister, 0, 3);
            tem = ModbusFloatHelper.UshortToFloat(holdingregister, 2, 3);
            drg = ModbusFloatHelper.UshortToFloat(dataDriveGain, 0, 3);
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            var saveData = new CDM.Sqlite.GatherSave()
            {
                GatherTime = DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss"),
                Density = paraDensity.Value.ToString() + " " + desUnitsLabel.Text,
                Temperature = paraTem.Value.ToString() + " " + temUnitsLabel.Text,
                K0 = paraDriveGain.Value.ToString() + "%",
                //K0 = K0_TextBox.Text,
                //K1 = K1_TextBox.Text,
                //K2 = K2_TextBox.Text,
            };
            ComWithSqliteServer.InsertData(saveData);
            SaveData.ListSave.Add(saveData);
            var timeNow = DateTime.Now;
            if(timeNow.Minute == 30 && timeNow.Second < 3)
            {
                if (SaveData.ListSave.Count == 0)
                {
                    MessageBox.Show("没有数据将不予生成");
                    return;
                }
                try
                {
                    var name = TimeHelper.GetUpLoadTime();
                    new Thread(new ThreadStart(() =>
                    {
                        new ExportExcel().ExportPath("gather" + name);
                        SaveData.ListSave.Clear();
                    })).Start();                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var fullFileName = "123" + ".xls";
            var startPath = Application.StartupPath;
            var savePath = startPath + "\\ExcelData\\" + fullFileName;
            labelStatus.Text = savePath;
        }

        private void btnFindData_Click(object sender, EventArgs e)
        {
            try
            {
                var year = Convert.ToInt32(nmupYear.Value);
                var month = Convert.ToInt32(nmupMonth.Value);
                var day = Convert.ToInt32(nmupDay.Value);
                var hour = Convert.ToInt32(nmupHour.Value);
                var min = Convert.ToInt32(mnupMin.Value);
                var time = new DateTime(year, month, day, hour, min, 0);
                var timeStr = "";
                if (isFindMin.Checked == true)
                    timeStr = time.ToString("yyyy/MM/dd_HH:mm");
                else
                    timeStr = time.ToString("yyyy/MM/dd_HH");
                var findStr = ComWithSqliteServer.FindData(timeStr);
                if (findStr == "") findStr = "没有数据";
                //var str = "采集时间  密度  温度  K0  K1  K2\r\n" + findStr;
                //textBoxFindResult.Text = str;

                var rowData = findStr.Split('&');
                dataGridViewFindData.Rows.Clear();

                for (int i = 0; i < rowData.Length - 1; ++i)
                {
                    var detailData = rowData[i].Split('|');
                    dataGridViewFindData.Rows.Add(detailData);
                }
            }
            catch
            {

            }

        }

        public void btnPrintCurve_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                zedGraphUtilsTem.Print();
            }
            if (tabControl1.SelectedIndex == 0)
            {
                zedGraphUtilsDes.Print();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                zedGraphUtilsDriveGain.Print();
            }
        }

        bool isShowInfoBox;
        /// <summary>
        /// 定时读取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGetData_Tick(object sender, EventArgs e)
        {
          
            try
            {
                //GetDesTemData(250, out var des, out var tem);
                //地址减一读
                GetDesTemDrgData(out var des, out var tem,out var drg);
                //读取状态位
                var datasBitsDefine = master?.ReadInputRegisters(SlaveAddress, 
                    (ushort)(AddressConfig.BitsDefine - 1), 1);
                pictureBoxDriveGain.BackColor = (((datasBitsDefine[0]) >> (5)) & 0x01) == 1 ? Color.Red : Color.Lime;
                pictureBoxSensor.BackColor = (((datasBitsDefine[0]) >> (10)) & 0x01) == 1 ? Color.Red : Color.Lime;
                //读取单位
                var datasUnits = master?.ReadHoldingRegisters(SlaveAddress,
                    (ushort)(AddressConfig.DensityUnit - 1), 2);
                desUnitsLabel.Text = ParaUnits.DesTable[datasUnits[0]];
                temUnitsLabel.Text = ParaUnits.TemTable[datasUnits[1]];
                //读取A37 A38
                var datasA37 = master?.ReadInputRegisters(SlaveAddress,
                    (ushort)(AddressConfig.A37 - 1), 1);
                pictureBoxSensorCheck.BackColor = (((datasA37[0]) >> (3)) & 0x01) == 1 ? 
                    Color.Red : Color.Lime;
                var datasA38 = master?.ReadInputRegisters(SlaveAddress,
                    (ushort)(AddressConfig.A38 - 1), 1);
                pictureBoxTimeOutLimits.BackColor = (((datasA38[0]) >> (2)) & 0x01) == 1 ?
                    Color.Red : Color.Lime;

                paraDensity.Value = des;
                paraTem.Value = tem;
                paraDriveGain.Value = drg;
                labelDes.Text = paraDensity.Value.ToString();
                LabelTem.Text = paraTem.Value.ToString();
                labelDriveGain.Text = paraDriveGain.Value.ToString() + "%";
                labelStatus.Text = "通信正常";
                timerDraw.Enabled = true;
                timerSave.Enabled = true;
                isShowInfoBox = false;
            }
            catch (Exception exception)
            {
                //timerGetData.Enabled = false;
                //timerGetData.Stop();
                if (exception.Source.Equals("System"))
                {
                    if(!isShowInfoBox)
                    {
                        isShowInfoBox = true;
                        MessageBox.Show(DateTime.Now.ToString() + " " + "通信超时");
                    }               
                    labelStatus.Text = "通信超时";
                }
                if (exception.Source.Equals("nModbusPC"))
                {
    
                    string str = exception.Message;
                    int FunctionCode;
                    string ExceptionCode;

                    str = str.Remove(0, str.IndexOf("\r\n", StringComparison.Ordinal) + 17);
                    FunctionCode = Convert.ToInt16(str.Remove(str.IndexOf("\r\n", StringComparison.Ordinal)));
                    //MessageBox.Show("Function Code: " + FunctionCode.ToString("X"));

                    str = str.Remove(0, str.IndexOf("\r\n", StringComparison.Ordinal) + 17);
                    ExceptionCode = str.Remove(str.IndexOf("-", StringComparison.Ordinal));
                    switch (ExceptionCode.Trim())
                    {
                        case "1":
                            labelStatus.Text = "通信异常：非法的通信功能码";
                            //MessageBox.Show("Exception Code: " + ExceptionCode.Trim() + "----> Illegal function!" );
                            break;
                        case "2":
                            labelStatus.Text = "通信异常：非法的数据地址";
                            //MessageBox.Show("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data address!" );
                            break;
                        case "3":
                            labelStatus.Text = "通信异常：非法的数据值";
                            //MessageBox.Show("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data value!"  );
                            break;
                        case "4":
                            labelStatus.Text = "从机故障";
                            //MessageBox.Show("Exception Code: " + ExceptionCode.Trim() + "----> Slave device failure!" );
                            break;

                    }
                    
                    //this.formMain.Close();

                }
                //labelStatus.Text = exception.Message.ToString();
            }          
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(serialPortConfig.ProLinkPath == "")
            {
                findExEXEButton_Click(null, null);
            }
            try
            {
                Process.Start(serialPortConfig.ProLinkPath);
            }
            catch
            {

            }
        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            ShowSerialConfigForm();
            btnOpenConnect.Text = serialPortConfig.PortIsOpen ? "断开连接" : "仪表连接";
        }

        private void flowUnitsComboBox_DropDownClosed(object sender, EventArgs e)
        {
            nmupYear.Select();
        }

        private void temUnitsComboBox_DropDownClosed(object sender, EventArgs e)
        {
            nmupYear.Select();
        }
    }
}
