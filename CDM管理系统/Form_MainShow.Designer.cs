namespace 流量计检定上位机
{
    partial class Form_MainShow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainShow));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelTime = new CCWin.SkinControl.SkinLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.labelStatus = new CCWin.SkinControl.SkinLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.labelVersion = new CCWin.SkinControl.SkinLabel();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.groupConnectSet = new CCWin.SkinControl.SkinGroupBox();
            this.comcmb = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnRenew = new CCWin.SkinControl.SkinButton();
            this.btnConnect = new CCWin.SkinControl.SkinButton();
            this.temUnitsComboBox = new CCWin.SkinControl.SkinComboBox();
            this.flowUnitsComboBox = new CCWin.SkinControl.SkinComboBox();
            this.MainTabControl = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.exEXEPathTextBox = new CCWin.SkinControl.SkinTextBox();
            this.panelLocation1 = new System.Windows.Forms.Panel();
            this.labelConnect = new System.Windows.Forms.Label();
            this.pictureBoxConnect = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpenConnect = new CCWin.SkinControl.SkinButton();
            this.skinLabel35 = new CCWin.SkinControl.SkinLabel();
            this.findExEXEButton = new CCWin.SkinControl.SkinButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupSetDemarcate = new CCWin.SkinControl.SkinGroupBox();
            this.curveCheckBox = new CCWin.SkinControl.SkinCheckBox();
            this.skinLine6 = new CCWin.SkinControl.SkinLine();
            this.labelYmin = new CCWin.SkinControl.SkinTextBox();
            this.labelYmax = new CCWin.SkinControl.SkinTextBox();
            this.btnChangeUpDown = new CCWin.SkinControl.SkinButton();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.panelIsAutoMode = new System.Windows.Forms.Panel();
            this.btnStopCurve = new CCWin.SkinControl.SkinButton();
            this.btnPrintCurve = new CCWin.SkinControl.SkinButton();
            this.btnClearCurve = new CCWin.SkinControl.SkinButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.desWarningFlag = new System.Windows.Forms.PictureBox();
            this.skinLabel25 = new CCWin.SkinControl.SkinLabel();
            this.hideLineDesCheckBox = new CCWin.SkinControl.SkinCheckBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.desDown = new CCWin.SkinControl.SkinTextBox();
            this.desUp = new CCWin.SkinControl.SkinTextBox();
            this.renewLineDesButton = new CCWin.SkinControl.SkinButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.temWarningFlag = new System.Windows.Forms.PictureBox();
            this.hideLineTemCheckBox = new CCWin.SkinControl.SkinCheckBox();
            this.renewLineTemButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel24 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.temDown = new CCWin.SkinControl.SkinTextBox();
            this.temUp = new CCWin.SkinControl.SkinTextBox();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.drgWarningFlag = new System.Windows.Forms.PictureBox();
            this.hideLineDrgCheckBox = new CCWin.SkinControl.SkinCheckBox();
            this.renewLineDrgButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel34 = new CCWin.SkinControl.SkinLabel();
            this.drgDown = new CCWin.SkinControl.SkinTextBox();
            this.drgUp = new CCWin.SkinControl.SkinTextBox();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.groupDataShow = new CCWin.SkinControl.SkinGroupBox();
            this.pictureBoxTimeOutLimits = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensorCheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensor = new System.Windows.Forms.PictureBox();
            this.pictureBoxDriveGain = new System.Windows.Forms.PictureBox();
            this.skinLabel37 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel36 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel26 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.labelDriveGain = new CCWin.SkinControl.SkinLabel();
            this.temUnitsLabel = new CCWin.SkinControl.SkinLabel();
            this.LabelTem = new CCWin.SkinControl.SkinLabel();
            this.labelDes = new CCWin.SkinControl.SkinLabel();
            this.desUnitsLabel = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLine4 = new CCWin.SkinControl.SkinLine();
            this.skinLine2 = new CCWin.SkinControl.SkinLine();
            this.skinLine9 = new CCWin.SkinControl.SkinLine();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.biaoAddressTextbox = new CCWin.SkinControl.SkinNumericUpDown();
            this.protocolComboBox = new CCWin.SkinControl.SkinComboBox();
            this.parityComboBox = new CCWin.SkinControl.SkinComboBox();
            this.stopBitsComboBox = new CCWin.SkinControl.SkinComboBox();
            this.dataBitsComboBox = new CCWin.SkinControl.SkinComboBox();
            this.baudComboBox = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel33 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.panelLocation2 = new System.Windows.Forms.Panel();
            this.dataGridViewFindData = new System.Windows.Forms.DataGridView();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.btnFindData = new CCWin.SkinControl.SkinButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.btnExportSqliteToExcel = new CCWin.SkinControl.SkinButton();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.nmupYear = new System.Windows.Forms.TextBox();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.温度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupConnectSet.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.panelLocation1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupSetDemarcate.SuspendLayout();
            this.panelIsAutoMode.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desWarningFlag)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temWarningFlag)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgWarningFlag)).BeginInit();
            this.groupDataShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeOutLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDriveGain)).BeginInit();
            this.skinTabPage3.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biaoAddressTextbox)).BeginInit();
            this.panelLocation2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindData)).BeginInit();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.BorderColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(845, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(196, 22);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "System.DateTime.Now";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(26, -15);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(69, 17);
            this.skinLabel9.TabIndex = 28;
            this.skinLabel9.Text = "skinLabel9";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.BorderColor = System.Drawing.Color.White;
            this.labelStatus.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelStatus.Location = new System.Drawing.Point(6, 19);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 20);
            this.labelStatus.TabIndex = 29;
            this.labelStatus.Text = "状态:未连接";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.skinLabel12);
            this.panel2.Controls.Add(this.labelVersion);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 50);
            this.panel2.TabIndex = 30;
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel12.Location = new System.Drawing.Point(792, 13);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(47, 22);
            this.skinLabel12.TabIndex = 27;
            this.skinLabel12.Text = "时间:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.BorderColor = System.Drawing.Color.White;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelVersion.Location = new System.Drawing.Point(1047, 13);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 22);
            this.labelVersion.TabIndex = 27;
            this.labelVersion.Text = "版本号:";
            // 
            // timerGetData
            // 
            this.timerGetData.Interval = 1000;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerDraw
            // 
            this.timerDraw.Interval = 200;
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // timerSave
            // 
            this.timerSave.Interval = 5000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // groupConnectSet
            // 
            this.groupConnectSet.BackColor = System.Drawing.Color.Transparent;
            this.groupConnectSet.BorderColor = System.Drawing.Color.Black;
            this.groupConnectSet.Controls.Add(this.comcmb);
            this.groupConnectSet.Controls.Add(this.skinLabel1);
            this.groupConnectSet.Controls.Add(this.btnRenew);
            this.groupConnectSet.Controls.Add(this.btnConnect);
            this.groupConnectSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupConnectSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupConnectSet.Location = new System.Drawing.Point(643, 631);
            this.groupConnectSet.Name = "groupConnectSet";
            this.groupConnectSet.RectBackColor = System.Drawing.Color.DarkGray;
            this.groupConnectSet.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupConnectSet.Size = new System.Drawing.Size(200, 110);
            this.groupConnectSet.TabIndex = 4;
            this.groupConnectSet.TabStop = false;
            this.groupConnectSet.Text = "通信端口";
            this.groupConnectSet.TitleBorderColor = System.Drawing.Color.Black;
            this.groupConnectSet.TitleRectBackColor = System.Drawing.Color.DarkGray;
            this.groupConnectSet.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupConnectSet.Visible = false;
            // 
            // comcmb
            // 
            this.comcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comcmb.DropBackColor = System.Drawing.Color.Silver;
            this.comcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comcmb.FormattingEnabled = true;
            this.comcmb.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.comcmb.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.comcmb.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comcmb.Location = new System.Drawing.Point(91, 28);
            this.comcmb.Name = "comcmb";
            this.comcmb.Size = new System.Drawing.Size(87, 30);
            this.comcmb.TabIndex = 8;
            this.comcmb.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(16, 32);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(58, 22);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "端口号";
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.DarkGray;
            this.btnRenew.BaseColor = System.Drawing.Color.Gray;
            this.btnRenew.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRenew.DownBack = null;
            this.btnRenew.Location = new System.Drawing.Point(101, 66);
            this.btnRenew.MouseBack = null;
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.NormlBack = null;
            this.btnRenew.Size = new System.Drawing.Size(77, 28);
            this.btnRenew.TabIndex = 7;
            this.btnRenew.Text = "刷新";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkGray;
            this.btnConnect.BaseColor = System.Drawing.Color.Gray;
            this.btnConnect.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConnect.DownBack = null;
            this.btnConnect.Location = new System.Drawing.Point(17, 66);
            this.btnConnect.MouseBack = null;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NormlBack = null;
            this.btnConnect.Size = new System.Drawing.Size(78, 28);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "打开";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // temUnitsComboBox
            // 
            this.temUnitsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.temUnitsComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.temUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temUnitsComboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temUnitsComboBox.FormattingEnabled = true;
            this.temUnitsComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.temUnitsComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.temUnitsComboBox.Items.AddRange(new object[] {
            "摄氏度",
            "华氏度"});
            this.temUnitsComboBox.Location = new System.Drawing.Point(271, 640);
            this.temUnitsComboBox.Name = "temUnitsComboBox";
            this.temUnitsComboBox.Size = new System.Drawing.Size(180, 27);
            this.temUnitsComboBox.TabIndex = 8;
            this.temUnitsComboBox.Visible = false;
            this.temUnitsComboBox.WaterText = "";
            this.temUnitsComboBox.SelectedIndexChanged += new System.EventHandler(this.temUnitsComboBox_SelectedIndexChanged);
            this.temUnitsComboBox.DropDownClosed += new System.EventHandler(this.temUnitsComboBox_DropDownClosed);
            // 
            // flowUnitsComboBox
            // 
            this.flowUnitsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flowUnitsComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.flowUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowUnitsComboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowUnitsComboBox.FormattingEnabled = true;
            this.flowUnitsComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.flowUnitsComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.flowUnitsComboBox.Items.AddRange(new object[] {
            "kg/m3 (千克/立方米)",
            "g/cm3 (克/立方厘米)"});
            this.flowUnitsComboBox.Location = new System.Drawing.Point(457, 640);
            this.flowUnitsComboBox.Name = "flowUnitsComboBox";
            this.flowUnitsComboBox.Size = new System.Drawing.Size(180, 27);
            this.flowUnitsComboBox.TabIndex = 8;
            this.flowUnitsComboBox.Visible = false;
            this.flowUnitsComboBox.WaterText = "";
            this.flowUnitsComboBox.SelectedIndexChanged += new System.EventHandler(this.flowUnitsComboBox_SelectedIndexChanged);
            this.flowUnitsComboBox.DropDownClosed += new System.EventHandler(this.flowUnitsComboBox_DropDownClosed);
            // 
            // MainTabControl
            // 
            this.MainTabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.MainTabControl.BackColor = System.Drawing.Color.DarkGray;
            this.MainTabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.MainTabControl.Controls.Add(this.skinTabPage1);
            this.MainTabControl.Controls.Add(this.skinTabPage3);
            this.MainTabControl.HeadBack = null;
            this.MainTabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.MainTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.MainTabControl.Location = new System.Drawing.Point(4, 5);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageArrowDown")));
            this.MainTabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageArrowHover")));
            this.MainTabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageCloseHover")));
            this.MainTabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageCloseNormal")));
            this.MainTabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageDown")));
            this.MainTabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("MainTabControl.PageHover")));
            this.MainTabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.MainTabControl.PageNorml = null;
            this.MainTabControl.SelectedIndex = 1;
            this.MainTabControl.Size = new System.Drawing.Size(1269, 605);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 31;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.skinTabPage1.Controls.Add(this.exEXEPathTextBox);
            this.skinTabPage1.Controls.Add(this.panelLocation1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Font = new System.Drawing.Font("宋体", 10F);
            this.skinTabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 40);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(1269, 565);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "主界面";
            // 
            // exEXEPathTextBox
            // 
            this.exEXEPathTextBox.BackColor = System.Drawing.Color.Transparent;
            this.exEXEPathTextBox.DownBack = null;
            this.exEXEPathTextBox.Icon = null;
            this.exEXEPathTextBox.IconIsButton = false;
            this.exEXEPathTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.exEXEPathTextBox.IsPasswordChat = '\0';
            this.exEXEPathTextBox.IsSystemPasswordChar = false;
            this.exEXEPathTextBox.Lines = new string[0];
            this.exEXEPathTextBox.Location = new System.Drawing.Point(1070, 556);
            this.exEXEPathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.exEXEPathTextBox.MaxLength = 32767;
            this.exEXEPathTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.exEXEPathTextBox.MouseBack = null;
            this.exEXEPathTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.exEXEPathTextBox.Multiline = false;
            this.exEXEPathTextBox.Name = "exEXEPathTextBox";
            this.exEXEPathTextBox.NormlBack = null;
            this.exEXEPathTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.exEXEPathTextBox.ReadOnly = true;
            this.exEXEPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.exEXEPathTextBox.Size = new System.Drawing.Size(151, 28);
            // 
            // 
            // 
            this.exEXEPathTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exEXEPathTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exEXEPathTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.exEXEPathTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.exEXEPathTextBox.SkinTxt.Name = "BaseText";
            this.exEXEPathTextBox.SkinTxt.ReadOnly = true;
            this.exEXEPathTextBox.SkinTxt.Size = new System.Drawing.Size(141, 18);
            this.exEXEPathTextBox.SkinTxt.TabIndex = 0;
            this.exEXEPathTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.exEXEPathTextBox.SkinTxt.WaterText = "";
            this.exEXEPathTextBox.TabIndex = 32;
            this.exEXEPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exEXEPathTextBox.Visible = false;
            this.exEXEPathTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.exEXEPathTextBox.WaterText = "";
            this.exEXEPathTextBox.WordWrap = true;
            // 
            // panelLocation1
            // 
            this.panelLocation1.Controls.Add(this.labelConnect);
            this.panelLocation1.Controls.Add(this.pictureBoxConnect);
            this.panelLocation1.Controls.Add(this.pictureBox2);
            this.panelLocation1.Controls.Add(this.btnOpenConnect);
            this.panelLocation1.Controls.Add(this.skinLabel35);
            this.panelLocation1.Controls.Add(this.findExEXEButton);
            this.panelLocation1.Controls.Add(this.pictureBox1);
            this.panelLocation1.Controls.Add(this.groupSetDemarcate);
            this.panelLocation1.Controls.Add(this.tabControl1);
            this.panelLocation1.Controls.Add(this.groupDataShow);
            this.panelLocation1.Location = new System.Drawing.Point(4, 0);
            this.panelLocation1.Name = "panelLocation1";
            this.panelLocation1.Size = new System.Drawing.Size(1258, 553);
            this.panelLocation1.TabIndex = 7;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Location = new System.Drawing.Point(99, 85);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(49, 14);
            this.labelConnect.TabIndex = 36;
            this.labelConnect.Text = "未连接";
            // 
            // pictureBoxConnect
            // 
            this.pictureBoxConnect.BackColor = System.Drawing.Color.Red;
            this.pictureBoxConnect.Location = new System.Drawing.Point(76, 83);
            this.pictureBoxConnect.Name = "pictureBoxConnect";
            this.pictureBoxConnect.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxConnect.TabIndex = 35;
            this.pictureBoxConnect.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CDM管理系统.Properties.Resources.motionLogo;
            this.pictureBox2.Location = new System.Drawing.Point(26, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 104);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.BackColor = System.Drawing.Color.DarkGray;
            this.btnOpenConnect.BaseColor = System.Drawing.Color.Gray;
            this.btnOpenConnect.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenConnect.DownBack = null;
            this.btnOpenConnect.Location = new System.Drawing.Point(35, 111);
            this.btnOpenConnect.MouseBack = null;
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.NormlBack = null;
            this.btnOpenConnect.Size = new System.Drawing.Size(148, 31);
            this.btnOpenConnect.TabIndex = 33;
            this.btnOpenConnect.Text = "仪表连接";
            this.btnOpenConnect.UseVisualStyleBackColor = false;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click);
            // 
            // skinLabel35
            // 
            this.skinLabel35.AutoSize = true;
            this.skinLabel35.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel35.BorderColor = System.Drawing.Color.White;
            this.skinLabel35.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel35.Location = new System.Drawing.Point(1108, 440);
            this.skinLabel35.Name = "skinLabel35";
            this.skinLabel35.Size = new System.Drawing.Size(93, 22);
            this.skinLabel35.TabIndex = 32;
            this.skinLabel35.Text = "ProLink III";
            // 
            // findExEXEButton
            // 
            this.findExEXEButton.BackColor = System.Drawing.Color.DarkGray;
            this.findExEXEButton.BaseColor = System.Drawing.Color.Gray;
            this.findExEXEButton.BorderColor = System.Drawing.Color.DarkGray;
            this.findExEXEButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.findExEXEButton.DownBack = null;
            this.findExEXEButton.Location = new System.Drawing.Point(1088, 474);
            this.findExEXEButton.MouseBack = null;
            this.findExEXEButton.Name = "findExEXEButton";
            this.findExEXEButton.NormlBack = null;
            this.findExEXEButton.Size = new System.Drawing.Size(130, 31);
            this.findExEXEButton.TabIndex = 8;
            this.findExEXEButton.Text = "指定软件路径";
            this.findExEXEButton.UseVisualStyleBackColor = false;
            this.findExEXEButton.Click += new System.EventHandler(this.findExEXEButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CDM管理系统.Properties.Resources.ProLinkIII_00001;
            this.pictureBox1.InitialImage = global::CDM管理系统.Properties.Resources.ProLinkIII_00001;
            this.pictureBox1.Location = new System.Drawing.Point(1128, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // groupSetDemarcate
            // 
            this.groupSetDemarcate.BackColor = System.Drawing.Color.Transparent;
            this.groupSetDemarcate.BorderColor = System.Drawing.Color.Black;
            this.groupSetDemarcate.Controls.Add(this.curveCheckBox);
            this.groupSetDemarcate.Controls.Add(this.skinLine6);
            this.groupSetDemarcate.Controls.Add(this.labelYmin);
            this.groupSetDemarcate.Controls.Add(this.labelYmax);
            this.groupSetDemarcate.Controls.Add(this.btnChangeUpDown);
            this.groupSetDemarcate.Controls.Add(this.skinLabel10);
            this.groupSetDemarcate.Controls.Add(this.skinLabel8);
            this.groupSetDemarcate.Controls.Add(this.panelIsAutoMode);
            this.groupSetDemarcate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupSetDemarcate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupSetDemarcate.Location = new System.Drawing.Point(1066, 13);
            this.groupSetDemarcate.Name = "groupSetDemarcate";
            this.groupSetDemarcate.RectBackColor = System.Drawing.Color.DarkGray;
            this.groupSetDemarcate.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupSetDemarcate.Size = new System.Drawing.Size(175, 328);
            this.groupSetDemarcate.TabIndex = 4;
            this.groupSetDemarcate.TabStop = false;
            this.groupSetDemarcate.Text = "曲线操作";
            this.groupSetDemarcate.TitleBorderColor = System.Drawing.Color.Black;
            this.groupSetDemarcate.TitleRectBackColor = System.Drawing.Color.DarkGray;
            this.groupSetDemarcate.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // curveCheckBox
            // 
            this.curveCheckBox.AutoSize = true;
            this.curveCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.curveCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.curveCheckBox.DownBack = null;
            this.curveCheckBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curveCheckBox.Location = new System.Drawing.Point(17, 296);
            this.curveCheckBox.MouseBack = null;
            this.curveCheckBox.Name = "curveCheckBox";
            this.curveCheckBox.NormlBack = null;
            this.curveCheckBox.SelectedDownBack = null;
            this.curveCheckBox.SelectedMouseBack = null;
            this.curveCheckBox.SelectedNormlBack = null;
            this.curveCheckBox.Size = new System.Drawing.Size(88, 23);
            this.curveCheckBox.TabIndex = 37;
            this.curveCheckBox.Text = "曲线跟随";
            this.curveCheckBox.UseVisualStyleBackColor = false;
            // 
            // skinLine6
            // 
            this.skinLine6.BackColor = System.Drawing.Color.Transparent;
            this.skinLine6.LineColor = System.Drawing.Color.Black;
            this.skinLine6.LineHeight = 2;
            this.skinLine6.Location = new System.Drawing.Point(4, 178);
            this.skinLine6.Name = "skinLine6";
            this.skinLine6.Size = new System.Drawing.Size(170, 10);
            this.skinLine6.TabIndex = 32;
            this.skinLine6.Text = "skinLine1";
            // 
            // labelYmin
            // 
            this.labelYmin.BackColor = System.Drawing.Color.Transparent;
            this.labelYmin.DownBack = null;
            this.labelYmin.Icon = null;
            this.labelYmin.IconIsButton = false;
            this.labelYmin.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelYmin.IsPasswordChat = '\0';
            this.labelYmin.IsSystemPasswordChar = false;
            this.labelYmin.Lines = new string[] {
        "0"};
            this.labelYmin.Location = new System.Drawing.Point(74, 258);
            this.labelYmin.Margin = new System.Windows.Forms.Padding(0);
            this.labelYmin.MaxLength = 32767;
            this.labelYmin.MinimumSize = new System.Drawing.Size(28, 28);
            this.labelYmin.MouseBack = null;
            this.labelYmin.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelYmin.Multiline = false;
            this.labelYmin.Name = "labelYmin";
            this.labelYmin.NormlBack = null;
            this.labelYmin.Padding = new System.Windows.Forms.Padding(5);
            this.labelYmin.ReadOnly = false;
            this.labelYmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.labelYmin.Size = new System.Drawing.Size(92, 28);
            // 
            // 
            // 
            this.labelYmin.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelYmin.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYmin.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.labelYmin.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.labelYmin.SkinTxt.Name = "BaseText";
            this.labelYmin.SkinTxt.Size = new System.Drawing.Size(82, 18);
            this.labelYmin.SkinTxt.TabIndex = 0;
            this.labelYmin.SkinTxt.Text = "0";
            this.labelYmin.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelYmin.SkinTxt.WaterText = "";
            this.labelYmin.TabIndex = 31;
            this.labelYmin.Text = "0";
            this.labelYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelYmin.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelYmin.WaterText = "";
            this.labelYmin.WordWrap = true;
            // 
            // labelYmax
            // 
            this.labelYmax.BackColor = System.Drawing.Color.Transparent;
            this.labelYmax.DownBack = null;
            this.labelYmax.Icon = null;
            this.labelYmax.IconIsButton = false;
            this.labelYmax.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelYmax.IsPasswordChat = '\0';
            this.labelYmax.IsSystemPasswordChar = false;
            this.labelYmax.Lines = new string[] {
        "1.2"};
            this.labelYmax.Location = new System.Drawing.Point(74, 225);
            this.labelYmax.Margin = new System.Windows.Forms.Padding(0);
            this.labelYmax.MaxLength = 32767;
            this.labelYmax.MinimumSize = new System.Drawing.Size(28, 28);
            this.labelYmax.MouseBack = null;
            this.labelYmax.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelYmax.Multiline = false;
            this.labelYmax.Name = "labelYmax";
            this.labelYmax.NormlBack = null;
            this.labelYmax.Padding = new System.Windows.Forms.Padding(5);
            this.labelYmax.ReadOnly = false;
            this.labelYmax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.labelYmax.Size = new System.Drawing.Size(92, 28);
            // 
            // 
            // 
            this.labelYmax.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelYmax.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYmax.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.labelYmax.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.labelYmax.SkinTxt.Name = "BaseText";
            this.labelYmax.SkinTxt.Size = new System.Drawing.Size(82, 18);
            this.labelYmax.SkinTxt.TabIndex = 0;
            this.labelYmax.SkinTxt.Text = "1.2";
            this.labelYmax.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelYmax.SkinTxt.WaterText = "";
            this.labelYmax.TabIndex = 31;
            this.labelYmax.Text = "1.2";
            this.labelYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelYmax.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelYmax.WaterText = "";
            this.labelYmax.WordWrap = true;
            this.labelYmax.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelYmax_PreviewKeyDown);
            // 
            // btnChangeUpDown
            // 
            this.btnChangeUpDown.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeUpDown.BaseColor = System.Drawing.Color.Gray;
            this.btnChangeUpDown.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeUpDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnChangeUpDown.DownBack = null;
            this.btnChangeUpDown.Location = new System.Drawing.Point(14, 189);
            this.btnChangeUpDown.MouseBack = null;
            this.btnChangeUpDown.Name = "btnChangeUpDown";
            this.btnChangeUpDown.NormlBack = null;
            this.btnChangeUpDown.Size = new System.Drawing.Size(148, 31);
            this.btnChangeUpDown.TabIndex = 7;
            this.btnChangeUpDown.Text = "修改曲线坐标";
            this.btnChangeUpDown.UseVisualStyleBackColor = false;
            this.btnChangeUpDown.Click += new System.EventHandler(this.btnChangeUpDown_Click);
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel10.Location = new System.Drawing.Point(14, 261);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(58, 22);
            this.skinLabel10.TabIndex = 27;
            this.skinLabel10.Text = "下边界";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel8.Location = new System.Drawing.Point(13, 229);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(58, 22);
            this.skinLabel8.TabIndex = 27;
            this.skinLabel8.Text = "上边界";
            // 
            // panelIsAutoMode
            // 
            this.panelIsAutoMode.Controls.Add(this.btnStopCurve);
            this.panelIsAutoMode.Controls.Add(this.btnPrintCurve);
            this.panelIsAutoMode.Controls.Add(this.btnClearCurve);
            this.panelIsAutoMode.Location = new System.Drawing.Point(14, 27);
            this.panelIsAutoMode.Name = "panelIsAutoMode";
            this.panelIsAutoMode.Size = new System.Drawing.Size(149, 145);
            this.panelIsAutoMode.TabIndex = 29;
            // 
            // btnStopCurve
            // 
            this.btnStopCurve.BackColor = System.Drawing.Color.DarkGray;
            this.btnStopCurve.BaseColor = System.Drawing.Color.Gray;
            this.btnStopCurve.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStopCurve.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStopCurve.DownBack = null;
            this.btnStopCurve.Location = new System.Drawing.Point(8, 13);
            this.btnStopCurve.MouseBack = null;
            this.btnStopCurve.Name = "btnStopCurve";
            this.btnStopCurve.NormlBack = null;
            this.btnStopCurve.Size = new System.Drawing.Size(130, 28);
            this.btnStopCurve.TabIndex = 7;
            this.btnStopCurve.Text = "暂停实时曲线";
            this.btnStopCurve.UseVisualStyleBackColor = false;
            this.btnStopCurve.Click += new System.EventHandler(this.btnStopCurve_Click);
            // 
            // btnPrintCurve
            // 
            this.btnPrintCurve.BackColor = System.Drawing.Color.DarkGray;
            this.btnPrintCurve.BaseColor = System.Drawing.Color.Gray;
            this.btnPrintCurve.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintCurve.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPrintCurve.DownBack = null;
            this.btnPrintCurve.Location = new System.Drawing.Point(8, 111);
            this.btnPrintCurve.MouseBack = null;
            this.btnPrintCurve.Name = "btnPrintCurve";
            this.btnPrintCurve.NormlBack = null;
            this.btnPrintCurve.Size = new System.Drawing.Size(130, 28);
            this.btnPrintCurve.TabIndex = 7;
            this.btnPrintCurve.Text = "打印实时曲线";
            this.btnPrintCurve.UseVisualStyleBackColor = false;
            this.btnPrintCurve.Click += new System.EventHandler(this.btnPrintCurve_Click);
            // 
            // btnClearCurve
            // 
            this.btnClearCurve.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearCurve.BaseColor = System.Drawing.Color.Gray;
            this.btnClearCurve.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCurve.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClearCurve.DownBack = null;
            this.btnClearCurve.Location = new System.Drawing.Point(8, 62);
            this.btnClearCurve.MouseBack = null;
            this.btnClearCurve.Name = "btnClearCurve";
            this.btnClearCurve.NormlBack = null;
            this.btnClearCurve.Size = new System.Drawing.Size(130, 28);
            this.btnClearCurve.TabIndex = 7;
            this.btnClearCurve.Text = "清空实时曲线";
            this.btnClearCurve.UseVisualStyleBackColor = false;
            this.btnClearCurve.Click += new System.EventHandler(this.btnClearCurve_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(219, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 517);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.desWarningFlag);
            this.tabPage1.Controls.Add(this.skinLabel25);
            this.tabPage1.Controls.Add(this.hideLineDesCheckBox);
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Controls.Add(this.skinLabel21);
            this.tabPage1.Controls.Add(this.skinLabel20);
            this.tabPage1.Controls.Add(this.desDown);
            this.tabPage1.Controls.Add(this.desUp);
            this.tabPage1.Controls.Add(this.renewLineDesButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "密度曲线";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // desWarningFlag
            // 
            this.desWarningFlag.BackColor = System.Drawing.Color.Lime;
            this.desWarningFlag.Location = new System.Drawing.Point(749, 460);
            this.desWarningFlag.Name = "desWarningFlag";
            this.desWarningFlag.Size = new System.Drawing.Size(44, 18);
            this.desWarningFlag.TabIndex = 39;
            this.desWarningFlag.TabStop = false;
            // 
            // skinLabel25
            // 
            this.skinLabel25.AutoSize = true;
            this.skinLabel25.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel25.BorderColor = System.Drawing.Color.White;
            this.skinLabel25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel25.Location = new System.Drawing.Point(675, 458);
            this.skinLabel25.Name = "skinLabel25";
            this.skinLabel25.Size = new System.Drawing.Size(74, 22);
            this.skinLabel25.TabIndex = 38;
            this.skinLabel25.Text = "超限报警";
            // 
            // hideLineDesCheckBox
            // 
            this.hideLineDesCheckBox.AutoSize = true;
            this.hideLineDesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.hideLineDesCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.hideLineDesCheckBox.DownBack = null;
            this.hideLineDesCheckBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hideLineDesCheckBox.Location = new System.Drawing.Point(400, 459);
            this.hideLineDesCheckBox.MouseBack = null;
            this.hideLineDesCheckBox.Name = "hideLineDesCheckBox";
            this.hideLineDesCheckBox.NormlBack = null;
            this.hideLineDesCheckBox.SelectedDownBack = null;
            this.hideLineDesCheckBox.SelectedMouseBack = null;
            this.hideLineDesCheckBox.SelectedNormlBack = null;
            this.hideLineDesCheckBox.Size = new System.Drawing.Size(133, 23);
            this.hideLineDesCheckBox.TabIndex = 37;
            this.hideLineDesCheckBox.Text = "隐藏上下限标线";
            this.hideLineDesCheckBox.UseVisualStyleBackColor = false;
            this.hideLineDesCheckBox.CheckedChanged += new System.EventHandler(this.hideLineDesCheckBox_CheckedChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowContextMenu = false;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PanButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl1.PanButtons2 = System.Windows.Forms.MouseButtons.Right;
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(790, 450);
            this.zedGraphControl1.TabIndex = 5;
            this.zedGraphControl1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // skinLabel21
            // 
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel21.Location = new System.Drawing.Point(209, 459);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(74, 22);
            this.skinLabel21.TabIndex = 27;
            this.skinLabel21.Text = "密度下限";
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel20.Location = new System.Drawing.Point(20, 459);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(74, 22);
            this.skinLabel20.TabIndex = 27;
            this.skinLabel20.Text = "密度上限";
            // 
            // desDown
            // 
            this.desDown.BackColor = System.Drawing.Color.Transparent;
            this.desDown.DownBack = null;
            this.desDown.Icon = null;
            this.desDown.IconIsButton = false;
            this.desDown.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.desDown.IsPasswordChat = '\0';
            this.desDown.IsSystemPasswordChar = false;
            this.desDown.Lines = new string[] {
        "0"};
            this.desDown.Location = new System.Drawing.Point(287, 456);
            this.desDown.Margin = new System.Windows.Forms.Padding(0);
            this.desDown.MaxLength = 32767;
            this.desDown.MinimumSize = new System.Drawing.Size(28, 28);
            this.desDown.MouseBack = null;
            this.desDown.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.desDown.Multiline = false;
            this.desDown.Name = "desDown";
            this.desDown.NormlBack = null;
            this.desDown.Padding = new System.Windows.Forms.Padding(5);
            this.desDown.ReadOnly = false;
            this.desDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.desDown.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.desDown.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desDown.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desDown.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.desDown.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.desDown.SkinTxt.Name = "BaseText";
            this.desDown.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.desDown.SkinTxt.TabIndex = 0;
            this.desDown.SkinTxt.Text = "0";
            this.desDown.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.desDown.SkinTxt.WaterText = "";
            this.desDown.TabIndex = 31;
            this.desDown.Text = "0";
            this.desDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.desDown.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.desDown.WaterText = "";
            this.desDown.WordWrap = true;
            // 
            // desUp
            // 
            this.desUp.BackColor = System.Drawing.Color.Transparent;
            this.desUp.DownBack = null;
            this.desUp.Icon = null;
            this.desUp.IconIsButton = false;
            this.desUp.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.desUp.IsPasswordChat = '\0';
            this.desUp.IsSystemPasswordChar = false;
            this.desUp.Lines = new string[] {
        "0"};
            this.desUp.Location = new System.Drawing.Point(95, 456);
            this.desUp.Margin = new System.Windows.Forms.Padding(0);
            this.desUp.MaxLength = 32767;
            this.desUp.MinimumSize = new System.Drawing.Size(28, 28);
            this.desUp.MouseBack = null;
            this.desUp.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.desUp.Multiline = false;
            this.desUp.Name = "desUp";
            this.desUp.NormlBack = null;
            this.desUp.Padding = new System.Windows.Forms.Padding(5);
            this.desUp.ReadOnly = false;
            this.desUp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.desUp.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.desUp.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desUp.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desUp.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.desUp.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.desUp.SkinTxt.Name = "BaseText";
            this.desUp.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.desUp.SkinTxt.TabIndex = 0;
            this.desUp.SkinTxt.Text = "0";
            this.desUp.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.desUp.SkinTxt.WaterText = "";
            this.desUp.TabIndex = 31;
            this.desUp.Text = "0";
            this.desUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.desUp.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.desUp.WaterText = "";
            this.desUp.WordWrap = true;
            // 
            // renewLineDesButton
            // 
            this.renewLineDesButton.BackColor = System.Drawing.Color.DarkGray;
            this.renewLineDesButton.BaseColor = System.Drawing.Color.Gray;
            this.renewLineDesButton.BorderColor = System.Drawing.Color.DarkGray;
            this.renewLineDesButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.renewLineDesButton.DownBack = null;
            this.renewLineDesButton.Location = new System.Drawing.Point(539, 456);
            this.renewLineDesButton.MouseBack = null;
            this.renewLineDesButton.Name = "renewLineDesButton";
            this.renewLineDesButton.NormlBack = null;
            this.renewLineDesButton.Size = new System.Drawing.Size(130, 28);
            this.renewLineDesButton.TabIndex = 7;
            this.renewLineDesButton.Text = "修改上下限标线";
            this.renewLineDesButton.UseVisualStyleBackColor = false;
            this.renewLineDesButton.Click += new System.EventHandler(this.renewLineDesButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.temWarningFlag);
            this.tabPage2.Controls.Add(this.hideLineTemCheckBox);
            this.tabPage2.Controls.Add(this.renewLineTemButton);
            this.tabPage2.Controls.Add(this.skinLabel22);
            this.tabPage2.Controls.Add(this.skinLabel24);
            this.tabPage2.Controls.Add(this.skinLabel23);
            this.tabPage2.Controls.Add(this.temDown);
            this.tabPage2.Controls.Add(this.temUp);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "温度曲线";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // temWarningFlag
            // 
            this.temWarningFlag.BackColor = System.Drawing.Color.Lime;
            this.temWarningFlag.Location = new System.Drawing.Point(749, 461);
            this.temWarningFlag.Name = "temWarningFlag";
            this.temWarningFlag.Size = new System.Drawing.Size(44, 18);
            this.temWarningFlag.TabIndex = 32;
            this.temWarningFlag.TabStop = false;
            // 
            // hideLineTemCheckBox
            // 
            this.hideLineTemCheckBox.AutoSize = true;
            this.hideLineTemCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.hideLineTemCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.hideLineTemCheckBox.DownBack = null;
            this.hideLineTemCheckBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hideLineTemCheckBox.Location = new System.Drawing.Point(400, 459);
            this.hideLineTemCheckBox.MouseBack = null;
            this.hideLineTemCheckBox.Name = "hideLineTemCheckBox";
            this.hideLineTemCheckBox.NormlBack = null;
            this.hideLineTemCheckBox.SelectedDownBack = null;
            this.hideLineTemCheckBox.SelectedMouseBack = null;
            this.hideLineTemCheckBox.SelectedNormlBack = null;
            this.hideLineTemCheckBox.Size = new System.Drawing.Size(133, 23);
            this.hideLineTemCheckBox.TabIndex = 36;
            this.hideLineTemCheckBox.Text = "隐藏上下限标线";
            this.hideLineTemCheckBox.UseVisualStyleBackColor = false;
            this.hideLineTemCheckBox.CheckedChanged += new System.EventHandler(this.hideLineTemCheckBox_CheckedChanged);
            // 
            // renewLineTemButton
            // 
            this.renewLineTemButton.BackColor = System.Drawing.Color.DarkGray;
            this.renewLineTemButton.BaseColor = System.Drawing.Color.Gray;
            this.renewLineTemButton.BorderColor = System.Drawing.Color.DarkGray;
            this.renewLineTemButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.renewLineTemButton.DownBack = null;
            this.renewLineTemButton.Location = new System.Drawing.Point(539, 456);
            this.renewLineTemButton.MouseBack = null;
            this.renewLineTemButton.Name = "renewLineTemButton";
            this.renewLineTemButton.NormlBack = null;
            this.renewLineTemButton.Size = new System.Drawing.Size(130, 28);
            this.renewLineTemButton.TabIndex = 35;
            this.renewLineTemButton.Text = "修改上下限标线";
            this.renewLineTemButton.UseVisualStyleBackColor = false;
            this.renewLineTemButton.Click += new System.EventHandler(this.renewLineTemButton_Click);
            // 
            // skinLabel22
            // 
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel22.Location = new System.Drawing.Point(209, 459);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(74, 22);
            this.skinLabel22.TabIndex = 32;
            this.skinLabel22.Text = "温度下限";
            // 
            // skinLabel24
            // 
            this.skinLabel24.AutoSize = true;
            this.skinLabel24.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel24.BorderColor = System.Drawing.Color.White;
            this.skinLabel24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel24.Location = new System.Drawing.Point(675, 459);
            this.skinLabel24.Name = "skinLabel24";
            this.skinLabel24.Size = new System.Drawing.Size(74, 22);
            this.skinLabel24.TabIndex = 27;
            this.skinLabel24.Text = "超限报警";
            // 
            // skinLabel23
            // 
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel23.Location = new System.Drawing.Point(20, 459);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(74, 22);
            this.skinLabel23.TabIndex = 33;
            this.skinLabel23.Text = "温度上限";
            // 
            // temDown
            // 
            this.temDown.BackColor = System.Drawing.Color.Transparent;
            this.temDown.DownBack = null;
            this.temDown.Icon = null;
            this.temDown.IconIsButton = false;
            this.temDown.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.temDown.IsPasswordChat = '\0';
            this.temDown.IsSystemPasswordChar = false;
            this.temDown.Lines = new string[] {
        "0"};
            this.temDown.Location = new System.Drawing.Point(287, 456);
            this.temDown.Margin = new System.Windows.Forms.Padding(0);
            this.temDown.MaxLength = 32767;
            this.temDown.MinimumSize = new System.Drawing.Size(28, 28);
            this.temDown.MouseBack = null;
            this.temDown.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.temDown.Multiline = false;
            this.temDown.Name = "temDown";
            this.temDown.NormlBack = null;
            this.temDown.Padding = new System.Windows.Forms.Padding(5);
            this.temDown.ReadOnly = false;
            this.temDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.temDown.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.temDown.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temDown.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temDown.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.temDown.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.temDown.SkinTxt.Name = "BaseText";
            this.temDown.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.temDown.SkinTxt.TabIndex = 0;
            this.temDown.SkinTxt.Text = "0";
            this.temDown.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.temDown.SkinTxt.WaterText = "";
            this.temDown.TabIndex = 34;
            this.temDown.Text = "0";
            this.temDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.temDown.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.temDown.WaterText = "";
            this.temDown.WordWrap = true;
            // 
            // temUp
            // 
            this.temUp.BackColor = System.Drawing.Color.Transparent;
            this.temUp.DownBack = null;
            this.temUp.Icon = null;
            this.temUp.IconIsButton = false;
            this.temUp.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.temUp.IsPasswordChat = '\0';
            this.temUp.IsSystemPasswordChar = false;
            this.temUp.Lines = new string[] {
        "0"};
            this.temUp.Location = new System.Drawing.Point(95, 456);
            this.temUp.Margin = new System.Windows.Forms.Padding(0);
            this.temUp.MaxLength = 32767;
            this.temUp.MinimumSize = new System.Drawing.Size(28, 28);
            this.temUp.MouseBack = null;
            this.temUp.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.temUp.Multiline = false;
            this.temUp.Name = "temUp";
            this.temUp.NormlBack = null;
            this.temUp.Padding = new System.Windows.Forms.Padding(5);
            this.temUp.ReadOnly = false;
            this.temUp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.temUp.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.temUp.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temUp.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temUp.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.temUp.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.temUp.SkinTxt.Name = "BaseText";
            this.temUp.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.temUp.SkinTxt.TabIndex = 0;
            this.temUp.SkinTxt.Text = "0";
            this.temUp.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.temUp.SkinTxt.WaterText = "";
            this.temUp.TabIndex = 34;
            this.temUp.Text = "0";
            this.temUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.temUp.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.temUp.WaterText = "";
            this.temUp.WordWrap = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.IsShowContextMenu = false;
            this.zedGraphControl2.IsShowHScrollBar = true;
            this.zedGraphControl2.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.PanButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl2.PanButtons2 = System.Windows.Forms.MouseButtons.Right;
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(790, 450);
            this.zedGraphControl2.TabIndex = 6;
            this.zedGraphControl2.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.drgWarningFlag);
            this.tabPage3.Controls.Add(this.hideLineDrgCheckBox);
            this.tabPage3.Controls.Add(this.renewLineDrgButton);
            this.tabPage3.Controls.Add(this.skinLabel5);
            this.tabPage3.Controls.Add(this.skinLabel11);
            this.tabPage3.Controls.Add(this.skinLabel34);
            this.tabPage3.Controls.Add(this.drgDown);
            this.tabPage3.Controls.Add(this.drgUp);
            this.tabPage3.Controls.Add(this.zedGraphControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(820, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "驱动增益曲线";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // drgWarningFlag
            // 
            this.drgWarningFlag.BackColor = System.Drawing.Color.Lime;
            this.drgWarningFlag.Location = new System.Drawing.Point(749, 461);
            this.drgWarningFlag.Name = "drgWarningFlag";
            this.drgWarningFlag.Size = new System.Drawing.Size(44, 18);
            this.drgWarningFlag.TabIndex = 44;
            this.drgWarningFlag.TabStop = false;
            // 
            // hideLineDrgCheckBox
            // 
            this.hideLineDrgCheckBox.AutoSize = true;
            this.hideLineDrgCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.hideLineDrgCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.hideLineDrgCheckBox.DownBack = null;
            this.hideLineDrgCheckBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hideLineDrgCheckBox.Location = new System.Drawing.Point(400, 459);
            this.hideLineDrgCheckBox.MouseBack = null;
            this.hideLineDrgCheckBox.Name = "hideLineDrgCheckBox";
            this.hideLineDrgCheckBox.NormlBack = null;
            this.hideLineDrgCheckBox.SelectedDownBack = null;
            this.hideLineDrgCheckBox.SelectedMouseBack = null;
            this.hideLineDrgCheckBox.SelectedNormlBack = null;
            this.hideLineDrgCheckBox.Size = new System.Drawing.Size(133, 23);
            this.hideLineDrgCheckBox.TabIndex = 43;
            this.hideLineDrgCheckBox.Text = "隐藏上下限标线";
            this.hideLineDrgCheckBox.UseVisualStyleBackColor = false;
            this.hideLineDrgCheckBox.CheckedChanged += new System.EventHandler(this.hideLineDrgCheckBox_CheckedChanged);
            // 
            // renewLineDrgButton
            // 
            this.renewLineDrgButton.BackColor = System.Drawing.Color.DarkGray;
            this.renewLineDrgButton.BaseColor = System.Drawing.Color.Gray;
            this.renewLineDrgButton.BorderColor = System.Drawing.Color.DarkGray;
            this.renewLineDrgButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.renewLineDrgButton.DownBack = null;
            this.renewLineDrgButton.Location = new System.Drawing.Point(539, 456);
            this.renewLineDrgButton.MouseBack = null;
            this.renewLineDrgButton.Name = "renewLineDrgButton";
            this.renewLineDrgButton.NormlBack = null;
            this.renewLineDrgButton.Size = new System.Drawing.Size(130, 28);
            this.renewLineDrgButton.TabIndex = 42;
            this.renewLineDrgButton.Text = "修改上下限标线";
            this.renewLineDrgButton.UseVisualStyleBackColor = false;
            this.renewLineDrgButton.Click += new System.EventHandler(this.renewLineDrgButton_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel5.Location = new System.Drawing.Point(209, 459);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(74, 22);
            this.skinLabel5.TabIndex = 38;
            this.skinLabel5.Text = "增益下限";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel11.Location = new System.Drawing.Point(675, 459);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(74, 22);
            this.skinLabel11.TabIndex = 37;
            this.skinLabel11.Text = "超限报警";
            // 
            // skinLabel34
            // 
            this.skinLabel34.AutoSize = true;
            this.skinLabel34.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel34.BorderColor = System.Drawing.Color.White;
            this.skinLabel34.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel34.Location = new System.Drawing.Point(20, 459);
            this.skinLabel34.Name = "skinLabel34";
            this.skinLabel34.Size = new System.Drawing.Size(74, 22);
            this.skinLabel34.TabIndex = 39;
            this.skinLabel34.Text = "增益上限";
            // 
            // drgDown
            // 
            this.drgDown.BackColor = System.Drawing.Color.Transparent;
            this.drgDown.DownBack = null;
            this.drgDown.Icon = null;
            this.drgDown.IconIsButton = false;
            this.drgDown.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.drgDown.IsPasswordChat = '\0';
            this.drgDown.IsSystemPasswordChar = false;
            this.drgDown.Lines = new string[] {
        "0"};
            this.drgDown.Location = new System.Drawing.Point(287, 456);
            this.drgDown.Margin = new System.Windows.Forms.Padding(0);
            this.drgDown.MaxLength = 32767;
            this.drgDown.MinimumSize = new System.Drawing.Size(28, 28);
            this.drgDown.MouseBack = null;
            this.drgDown.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.drgDown.Multiline = false;
            this.drgDown.Name = "drgDown";
            this.drgDown.NormlBack = null;
            this.drgDown.Padding = new System.Windows.Forms.Padding(5);
            this.drgDown.ReadOnly = false;
            this.drgDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.drgDown.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.drgDown.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drgDown.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgDown.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.drgDown.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.drgDown.SkinTxt.Name = "BaseText";
            this.drgDown.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.drgDown.SkinTxt.TabIndex = 0;
            this.drgDown.SkinTxt.Text = "0";
            this.drgDown.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.drgDown.SkinTxt.WaterText = "";
            this.drgDown.TabIndex = 40;
            this.drgDown.Text = "0";
            this.drgDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.drgDown.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.drgDown.WaterText = "";
            this.drgDown.WordWrap = true;
            // 
            // drgUp
            // 
            this.drgUp.BackColor = System.Drawing.Color.Transparent;
            this.drgUp.DownBack = null;
            this.drgUp.Icon = null;
            this.drgUp.IconIsButton = false;
            this.drgUp.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.drgUp.IsPasswordChat = '\0';
            this.drgUp.IsSystemPasswordChar = false;
            this.drgUp.Lines = new string[] {
        "0"};
            this.drgUp.Location = new System.Drawing.Point(95, 456);
            this.drgUp.Margin = new System.Windows.Forms.Padding(0);
            this.drgUp.MaxLength = 32767;
            this.drgUp.MinimumSize = new System.Drawing.Size(28, 28);
            this.drgUp.MouseBack = null;
            this.drgUp.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.drgUp.Multiline = false;
            this.drgUp.Name = "drgUp";
            this.drgUp.NormlBack = null;
            this.drgUp.Padding = new System.Windows.Forms.Padding(5);
            this.drgUp.ReadOnly = false;
            this.drgUp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.drgUp.Size = new System.Drawing.Size(105, 28);
            // 
            // 
            // 
            this.drgUp.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drgUp.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgUp.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.drgUp.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.drgUp.SkinTxt.Name = "BaseText";
            this.drgUp.SkinTxt.Size = new System.Drawing.Size(95, 18);
            this.drgUp.SkinTxt.TabIndex = 0;
            this.drgUp.SkinTxt.Text = "0";
            this.drgUp.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.drgUp.SkinTxt.WaterText = "";
            this.drgUp.TabIndex = 41;
            this.drgUp.Text = "0";
            this.drgUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.drgUp.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.drgUp.WaterText = "";
            this.drgUp.WordWrap = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.IsShowContextMenu = false;
            this.zedGraphControl3.IsShowHScrollBar = true;
            this.zedGraphControl3.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.PanButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl3.PanButtons2 = System.Windows.Forms.MouseButtons.Right;
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(790, 450);
            this.zedGraphControl3.TabIndex = 6;
            this.zedGraphControl3.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // groupDataShow
            // 
            this.groupDataShow.BackColor = System.Drawing.Color.Transparent;
            this.groupDataShow.BorderColor = System.Drawing.Color.Black;
            this.groupDataShow.Controls.Add(this.pictureBoxTimeOutLimits);
            this.groupDataShow.Controls.Add(this.pictureBoxSensorCheck);
            this.groupDataShow.Controls.Add(this.pictureBoxSensor);
            this.groupDataShow.Controls.Add(this.pictureBoxDriveGain);
            this.groupDataShow.Controls.Add(this.skinLabel37);
            this.groupDataShow.Controls.Add(this.skinLabel36);
            this.groupDataShow.Controls.Add(this.skinLabel14);
            this.groupDataShow.Controls.Add(this.skinLabel4);
            this.groupDataShow.Controls.Add(this.skinLabel13);
            this.groupDataShow.Controls.Add(this.skinLabel26);
            this.groupDataShow.Controls.Add(this.skinLabel2);
            this.groupDataShow.Controls.Add(this.labelDriveGain);
            this.groupDataShow.Controls.Add(this.temUnitsLabel);
            this.groupDataShow.Controls.Add(this.LabelTem);
            this.groupDataShow.Controls.Add(this.labelDes);
            this.groupDataShow.Controls.Add(this.desUnitsLabel);
            this.groupDataShow.Controls.Add(this.skinLabel3);
            this.groupDataShow.Controls.Add(this.skinLine4);
            this.groupDataShow.Controls.Add(this.skinLine2);
            this.groupDataShow.Controls.Add(this.skinLine9);
            this.groupDataShow.Controls.Add(this.skinLine1);
            this.groupDataShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupDataShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupDataShow.Location = new System.Drawing.Point(13, 150);
            this.groupDataShow.Name = "groupDataShow";
            this.groupDataShow.RectBackColor = System.Drawing.Color.DarkGray;
            this.groupDataShow.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupDataShow.Size = new System.Drawing.Size(200, 379);
            this.groupDataShow.TabIndex = 4;
            this.groupDataShow.TabStop = false;
            this.groupDataShow.Text = "数据显示";
            this.groupDataShow.TitleBorderColor = System.Drawing.Color.Black;
            this.groupDataShow.TitleRectBackColor = System.Drawing.Color.DarkGray;
            this.groupDataShow.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // pictureBoxTimeOutLimits
            // 
            this.pictureBoxTimeOutLimits.BackColor = System.Drawing.Color.Red;
            this.pictureBoxTimeOutLimits.Location = new System.Drawing.Point(148, 313);
            this.pictureBoxTimeOutLimits.Name = "pictureBoxTimeOutLimits";
            this.pictureBoxTimeOutLimits.Size = new System.Drawing.Size(44, 18);
            this.pictureBoxTimeOutLimits.TabIndex = 32;
            this.pictureBoxTimeOutLimits.TabStop = false;
            // 
            // pictureBoxSensorCheck
            // 
            this.pictureBoxSensorCheck.BackColor = System.Drawing.Color.Red;
            this.pictureBoxSensorCheck.Location = new System.Drawing.Point(148, 345);
            this.pictureBoxSensorCheck.Name = "pictureBoxSensorCheck";
            this.pictureBoxSensorCheck.Size = new System.Drawing.Size(44, 18);
            this.pictureBoxSensorCheck.TabIndex = 32;
            this.pictureBoxSensorCheck.TabStop = false;
            // 
            // pictureBoxSensor
            // 
            this.pictureBoxSensor.BackColor = System.Drawing.Color.Red;
            this.pictureBoxSensor.Location = new System.Drawing.Point(148, 278);
            this.pictureBoxSensor.Name = "pictureBoxSensor";
            this.pictureBoxSensor.Size = new System.Drawing.Size(44, 18);
            this.pictureBoxSensor.TabIndex = 32;
            this.pictureBoxSensor.TabStop = false;
            // 
            // pictureBoxDriveGain
            // 
            this.pictureBoxDriveGain.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDriveGain.Location = new System.Drawing.Point(148, 244);
            this.pictureBoxDriveGain.Name = "pictureBoxDriveGain";
            this.pictureBoxDriveGain.Size = new System.Drawing.Size(44, 18);
            this.pictureBoxDriveGain.TabIndex = 32;
            this.pictureBoxDriveGain.TabStop = false;
            // 
            // skinLabel37
            // 
            this.skinLabel37.AutoSize = true;
            this.skinLabel37.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel37.BorderColor = System.Drawing.Color.White;
            this.skinLabel37.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.skinLabel37.Location = new System.Drawing.Point(9, 313);
            this.skinLabel37.Name = "skinLabel37";
            this.skinLabel37.Size = new System.Drawing.Size(140, 19);
            this.skinLabel37.TabIndex = 27;
            this.skinLabel37.Text = "时间周期超限(A38)";
            // 
            // skinLabel36
            // 
            this.skinLabel36.AutoSize = true;
            this.skinLabel36.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel36.BorderColor = System.Drawing.Color.White;
            this.skinLabel36.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.skinLabel36.Location = new System.Drawing.Point(9, 344);
            this.skinLabel36.Name = "skinLabel36";
            this.skinLabel36.Size = new System.Drawing.Size(125, 19);
            this.skinLabel36.TabIndex = 27;
            this.skinLabel36.Text = "传感器检测(A37)";
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.skinLabel14.Location = new System.Drawing.Point(9, 277);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(99, 19);
            this.skinLabel14.TabIndex = 27;
            this.skinLabel14.Text = "驱动增益状态";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.skinLabel4.Location = new System.Drawing.Point(9, 243);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(84, 19);
            this.skinLabel4.TabIndex = 27;
            this.skinLabel4.Text = "传感器状态";
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.skinLabel13.Location = new System.Drawing.Point(12, 215);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(84, 25);
            this.skinLabel13.TabIndex = 27;
            this.skinLabel13.Text = "状态诊断";
            // 
            // skinLabel26
            // 
            this.skinLabel26.AutoSize = true;
            this.skinLabel26.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel26.BorderColor = System.Drawing.Color.White;
            this.skinLabel26.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.skinLabel26.Location = new System.Drawing.Point(14, 153);
            this.skinLabel26.Name = "skinLabel26";
            this.skinLabel26.Size = new System.Drawing.Size(84, 25);
            this.skinLabel26.TabIndex = 27;
            this.skinLabel26.Text = "驱动增益";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.skinLabel2.Location = new System.Drawing.Point(14, 92);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(48, 25);
            this.skinLabel2.TabIndex = 27;
            this.skinLabel2.Text = "温度";
            // 
            // labelDriveGain
            // 
            this.labelDriveGain.AutoSize = true;
            this.labelDriveGain.BackColor = System.Drawing.Color.Transparent;
            this.labelDriveGain.BorderColor = System.Drawing.Color.White;
            this.labelDriveGain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelDriveGain.Location = new System.Drawing.Point(13, 182);
            this.labelDriveGain.Name = "labelDriveGain";
            this.labelDriveGain.Size = new System.Drawing.Size(85, 22);
            this.labelDriveGain.TabIndex = 27;
            this.labelDriveGain.Text = "9999.999";
            this.labelDriveGain.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // temUnitsLabel
            // 
            this.temUnitsLabel.AutoSize = true;
            this.temUnitsLabel.BackColor = System.Drawing.Color.Transparent;
            this.temUnitsLabel.BorderColor = System.Drawing.Color.White;
            this.temUnitsLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.temUnitsLabel.Location = new System.Drawing.Point(96, 122);
            this.temUnitsLabel.Name = "temUnitsLabel";
            this.temUnitsLabel.Size = new System.Drawing.Size(58, 22);
            this.temUnitsLabel.TabIndex = 27;
            this.temUnitsLabel.Text = "摄氏度";
            // 
            // LabelTem
            // 
            this.LabelTem.AutoSize = true;
            this.LabelTem.BackColor = System.Drawing.Color.Transparent;
            this.LabelTem.BorderColor = System.Drawing.Color.White;
            this.LabelTem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.LabelTem.ForeColor = System.Drawing.Color.Navy;
            this.LabelTem.Location = new System.Drawing.Point(13, 122);
            this.LabelTem.Name = "LabelTem";
            this.LabelTem.Size = new System.Drawing.Size(85, 22);
            this.LabelTem.TabIndex = 27;
            this.LabelTem.Text = "9999.999";
            this.LabelTem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.BackColor = System.Drawing.Color.Transparent;
            this.labelDes.BorderColor = System.Drawing.Color.White;
            this.labelDes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelDes.ForeColor = System.Drawing.Color.Navy;
            this.labelDes.Location = new System.Drawing.Point(13, 63);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(85, 22);
            this.labelDes.TabIndex = 27;
            this.labelDes.Text = "9999.999";
            this.labelDes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // desUnitsLabel
            // 
            this.desUnitsLabel.AutoSize = true;
            this.desUnitsLabel.BackColor = System.Drawing.Color.Transparent;
            this.desUnitsLabel.BorderColor = System.Drawing.Color.White;
            this.desUnitsLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.desUnitsLabel.Location = new System.Drawing.Point(96, 62);
            this.desUnitsLabel.Name = "desUnitsLabel";
            this.desUnitsLabel.Size = new System.Drawing.Size(98, 22);
            this.desUnitsLabel.TabIndex = 27;
            this.desUnitsLabel.Text = "千克/立方米";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.skinLabel3.Location = new System.Drawing.Point(14, 33);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(48, 25);
            this.skinLabel3.TabIndex = 27;
            this.skinLabel3.Text = "密度";
            // 
            // skinLine4
            // 
            this.skinLine4.BackColor = System.Drawing.Color.Transparent;
            this.skinLine4.LineColor = System.Drawing.Color.Black;
            this.skinLine4.LineHeight = 2;
            this.skinLine4.Location = new System.Drawing.Point(3, 226);
            this.skinLine4.Name = "skinLine4";
            this.skinLine4.Size = new System.Drawing.Size(188, 12);
            this.skinLine4.TabIndex = 26;
            this.skinLine4.Text = "skinLine1";
            // 
            // skinLine2
            // 
            this.skinLine2.BackColor = System.Drawing.Color.Transparent;
            this.skinLine2.LineColor = System.Drawing.Color.Black;
            this.skinLine2.LineHeight = 2;
            this.skinLine2.Location = new System.Drawing.Point(7, 165);
            this.skinLine2.Name = "skinLine2";
            this.skinLine2.Size = new System.Drawing.Size(188, 12);
            this.skinLine2.TabIndex = 26;
            this.skinLine2.Text = "skinLine1";
            // 
            // skinLine9
            // 
            this.skinLine9.BackColor = System.Drawing.Color.Transparent;
            this.skinLine9.LineColor = System.Drawing.Color.Black;
            this.skinLine9.LineHeight = 2;
            this.skinLine9.Location = new System.Drawing.Point(6, 103);
            this.skinLine9.Name = "skinLine9";
            this.skinLine9.Size = new System.Drawing.Size(188, 12);
            this.skinLine9.TabIndex = 26;
            this.skinLine9.Text = "skinLine1";
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 2;
            this.skinLine1.Location = new System.Drawing.Point(6, 44);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(188, 12);
            this.skinLine1.TabIndex = 26;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.skinTabPage3.Controls.Add(this.nmupYear);
            this.skinTabPage3.Controls.Add(this.skinGroupBox1);
            this.skinTabPage3.Controls.Add(this.panelLocation2);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Font = new System.Drawing.Font("宋体", 10F);
            this.skinTabPage3.Location = new System.Drawing.Point(0, 40);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(1269, 565);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "数据查询";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.biaoAddressTextbox);
            this.skinGroupBox1.Controls.Add(this.protocolComboBox);
            this.skinGroupBox1.Controls.Add(this.parityComboBox);
            this.skinGroupBox1.Controls.Add(this.stopBitsComboBox);
            this.skinGroupBox1.Controls.Add(this.dataBitsComboBox);
            this.skinGroupBox1.Controls.Add(this.baudComboBox);
            this.skinGroupBox1.Controls.Add(this.skinLabel18);
            this.skinGroupBox1.Controls.Add(this.skinLabel33);
            this.skinGroupBox1.Controls.Add(this.skinLabel19);
            this.skinGroupBox1.Controls.Add(this.skinLabel17);
            this.skinGroupBox1.Controls.Add(this.skinLabel16);
            this.skinGroupBox1.Controls.Add(this.skinLabel15);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox1.Location = new System.Drawing.Point(1202, 241);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(234, 324);
            this.skinGroupBox1.TabIndex = 9;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "仪表通信设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Visible = false;
            // 
            // biaoAddressTextbox
            // 
            this.biaoAddressTextbox.Location = new System.Drawing.Point(72, 239);
            this.biaoAddressTextbox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.biaoAddressTextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.biaoAddressTextbox.Name = "biaoAddressTextbox";
            this.biaoAddressTextbox.Size = new System.Drawing.Size(151, 29);
            this.biaoAddressTextbox.TabIndex = 10;
            this.biaoAddressTextbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // protocolComboBox
            // 
            this.protocolComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.protocolComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.protocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocolComboBox.FormattingEnabled = true;
            this.protocolComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.protocolComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.protocolComboBox.Items.AddRange(new object[] {
            "ModbusRTU",
            "ModbusASCII"});
            this.protocolComboBox.Location = new System.Drawing.Point(72, 198);
            this.protocolComboBox.Name = "protocolComboBox";
            this.protocolComboBox.Size = new System.Drawing.Size(151, 30);
            this.protocolComboBox.TabIndex = 8;
            this.protocolComboBox.WaterText = "";
            // 
            // parityComboBox
            // 
            this.parityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.parityComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.parityComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.parityComboBox.Items.AddRange(new object[] {
            "无",
            "偶校验",
            "奇校验"});
            this.parityComboBox.Location = new System.Drawing.Point(72, 157);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(151, 30);
            this.parityComboBox.TabIndex = 8;
            this.parityComboBox.WaterText = "";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stopBitsComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.stopBitsComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "1位",
            "2位",
            "1.5位"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(72, 116);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(151, 30);
            this.stopBitsComboBox.TabIndex = 8;
            this.stopBitsComboBox.WaterText = "";
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dataBitsComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.dataBitsComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(72, 72);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(151, 30);
            this.dataBitsComboBox.TabIndex = 8;
            this.dataBitsComboBox.WaterText = "";
            // 
            // baudComboBox
            // 
            this.baudComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.baudComboBox.DropBackColor = System.Drawing.Color.Silver;
            this.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.ItemBorderColor = System.Drawing.Color.SlateGray;
            this.baudComboBox.ItemHoverForeColor = System.Drawing.Color.Gray;
            this.baudComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.baudComboBox.Location = new System.Drawing.Point(72, 28);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(151, 30);
            this.baudComboBox.TabIndex = 8;
            this.baudComboBox.WaterText = "";
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.Location = new System.Drawing.Point(14, 242);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(58, 22);
            this.skinLabel18.TabIndex = 0;
            this.skinLabel18.Text = "表地址";
            // 
            // skinLabel33
            // 
            this.skinLabel33.AutoSize = true;
            this.skinLabel33.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel33.BorderColor = System.Drawing.Color.White;
            this.skinLabel33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel33.Location = new System.Drawing.Point(14, 202);
            this.skinLabel33.Name = "skinLabel33";
            this.skinLabel33.Size = new System.Drawing.Size(42, 22);
            this.skinLabel33.TabIndex = 0;
            this.skinLabel33.Text = "协议";
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.Location = new System.Drawing.Point(14, 160);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(42, 22);
            this.skinLabel19.TabIndex = 0;
            this.skinLabel19.Text = "校验";
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.Location = new System.Drawing.Point(14, 119);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(58, 22);
            this.skinLabel17.TabIndex = 0;
            this.skinLabel17.Text = "停止位";
            // 
            // skinLabel16
            // 
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.Location = new System.Drawing.Point(14, 75);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(58, 22);
            this.skinLabel16.TabIndex = 0;
            this.skinLabel16.Text = "数据位";
            // 
            // skinLabel15
            // 
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.Location = new System.Drawing.Point(14, 32);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(58, 22);
            this.skinLabel15.TabIndex = 0;
            this.skinLabel15.Text = "波特率";
            // 
            // panelLocation2
            // 
            this.panelLocation2.Controls.Add(this.dataGridViewFindData);
            this.panelLocation2.Controls.Add(this.skinGroupBox3);
            this.panelLocation2.Location = new System.Drawing.Point(95, 3);
            this.panelLocation2.Name = "panelLocation2";
            this.panelLocation2.Size = new System.Drawing.Size(1054, 559);
            this.panelLocation2.TabIndex = 36;
            // 
            // dataGridViewFindData
            // 
            this.dataGridViewFindData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.密度,
            this.温度,
            this.Column4});
            this.dataGridViewFindData.Location = new System.Drawing.Point(9, 80);
            this.dataGridViewFindData.Name = "dataGridViewFindData";
            this.dataGridViewFindData.RowTemplate.Height = 23;
            this.dataGridViewFindData.RowTemplate.ReadOnly = true;
            this.dataGridViewFindData.Size = new System.Drawing.Size(867, 462);
            this.dataGridViewFindData.TabIndex = 37;
//            this.dataGridViewFindData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewFindData_Scroll);
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Controls.Add(this.label1);
            this.skinGroupBox3.Controls.Add(this.dateTimePickerEnd);
            this.skinGroupBox3.Controls.Add(this.dateTimePickerStart);
            this.skinGroupBox3.Controls.Add(this.btnExportSqliteToExcel);
            this.skinGroupBox3.Controls.Add(this.btnFindData);
            this.skinGroupBox3.Controls.Add(this.skinLabel6);
            this.skinGroupBox3.Controls.Add(this.skinLabel7);
            this.skinGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox3.Location = new System.Drawing.Point(9, 3);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(867, 71);
            this.skinGroupBox3.TabIndex = 34;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "查询设置";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnFindData
            // 
            this.btnFindData.BackColor = System.Drawing.Color.DarkGray;
            this.btnFindData.BaseColor = System.Drawing.Color.Gray;
            this.btnFindData.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindData.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFindData.DownBack = null;
            this.btnFindData.Location = new System.Drawing.Point(606, 31);
            this.btnFindData.MouseBack = null;
            this.btnFindData.Name = "btnFindData";
            this.btnFindData.NormlBack = null;
            this.btnFindData.Size = new System.Drawing.Size(81, 33);
            this.btnFindData.TabIndex = 35;
            this.btnFindData.Text = "查询";
            this.btnFindData.UseVisualStyleBackColor = false;
            this.btnFindData.Click += new System.EventHandler(this.btnFindData_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(14, 32);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(96, 28);
            this.skinLabel7.TabIndex = 1;
            this.skinLabel7.Text = "起始时间";
            // 
            // btnExportSqliteToExcel
            // 
            this.btnExportSqliteToExcel.BackColor = System.Drawing.Color.DarkGray;
            this.btnExportSqliteToExcel.BaseColor = System.Drawing.Color.Gray;
            this.btnExportSqliteToExcel.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportSqliteToExcel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExportSqliteToExcel.DownBack = null;
            this.btnExportSqliteToExcel.Location = new System.Drawing.Point(692, 31);
            this.btnExportSqliteToExcel.MouseBack = null;
            this.btnExportSqliteToExcel.Name = "btnExportSqliteToExcel";
            this.btnExportSqliteToExcel.NormlBack = null;
            this.btnExportSqliteToExcel.Size = new System.Drawing.Size(159, 33);
            this.btnExportSqliteToExcel.TabIndex = 35;
            this.btnExportSqliteToExcel.Text = "导出到Excel表格";
            this.btnExportSqliteToExcel.UseVisualStyleBackColor = false;
            this.btnExportSqliteToExcel.Click += new System.EventHandler(this.btnExportSqliteToExcel_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dateTimePickerStart.Location = new System.Drawing.Point(116, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(190, 29);
            this.dateTimePickerStart.TabIndex = 37;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(310, 33);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(96, 28);
            this.skinLabel6.TabIndex = 1;
            this.skinLabel6.Text = "结束时间";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(410, 33);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(190, 29);
            this.dateTimePickerEnd.TabIndex = 37;
            // 
            // nmupYear
            // 
            this.nmupYear.Location = new System.Drawing.Point(-2, 357);
            this.nmupYear.Name = "nmupYear";
            this.nmupYear.Size = new System.Drawing.Size(46, 23);
            this.nmupYear.TabIndex = 38;
            this.nmupYear.Visible = false;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "采集日期";
            this.Column0.Name = "Column0";
            this.Column0.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "采集时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // 密度
            // 
            this.密度.HeaderText = "密度";
            this.密度.Name = "密度";
            this.密度.ReadOnly = true;
            this.密度.Width = 200;
            // 
            // 温度
            // 
            this.温度.HeaderText = "温度";
            this.温度.Name = "温度";
            this.温度.ReadOnly = true;
            this.温度.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "驱动增益(%)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            // 
            // Form_MainShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1383, 727);
            this.ControlBox = false;
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupConnectSet);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.temUnitsComboBox);
            this.Controls.Add(this.flowUnitsComboBox);
            this.KeyPreview = true;
            this.MdiBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.MinimumSize = new System.Drawing.Size(490, 550);
            this.Name = "Form_MainShow";
            this.Radius = 1;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TitleCenter = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_MainShow_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_MainShow_PreviewKeyDown);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupConnectSet.ResumeLayout(false);
            this.groupConnectSet.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.panelLocation1.ResumeLayout(false);
            this.panelLocation1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupSetDemarcate.ResumeLayout(false);
            this.groupSetDemarcate.PerformLayout();
            this.panelIsAutoMode.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desWarningFlag)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temWarningFlag)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgWarningFlag)).EndInit();
            this.groupDataShow.ResumeLayout(false);
            this.groupDataShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeOutLimits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDriveGain)).EndInit();
            this.skinTabPage3.ResumeLayout(false);
            this.skinTabPage3.PerformLayout();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biaoAddressTextbox)).EndInit();
            this.panelLocation2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindData)).EndInit();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private CCWin.SkinControl.SkinLabel labelTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel labelStatus;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel labelVersion;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinGroupBox groupConnectSet;
        private CCWin.SkinControl.SkinButton btnConnect;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinGroupBox groupDataShow;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinGroupBox groupSetDemarcate;
        private System.Windows.Forms.Panel panelIsAutoMode;
        private CCWin.SkinControl.SkinTabControl MainTabControl;
        private CCWin.SkinControl.SkinComboBox comcmb;
        private CCWin.SkinControl.SkinButton btnStopCurve;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private CCWin.SkinControl.SkinLabel desUnitsLabel;
        private CCWin.SkinControl.SkinButton btnRenew;
        private CCWin.SkinControl.SkinLabel temUnitsLabel;
        private CCWin.SkinControl.SkinLabel LabelTem;
        private CCWin.SkinControl.SkinLabel labelDes;
        private CCWin.SkinControl.SkinLine skinLine9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinTextBox labelYmin;
        private CCWin.SkinControl.SkinTextBox labelYmax;
        public System.Windows.Forms.Timer timerGetData;
        public System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Timer timerDraw;
        private CCWin.SkinControl.SkinButton btnClearCurve;
        private CCWin.SkinControl.SkinComboBox flowUnitsComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLine skinLine4;
        private System.Windows.Forms.PictureBox pictureBoxSensor;
        private System.Windows.Forms.PictureBox pictureBoxDriveGain;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinNumericUpDown biaoAddressTextbox;
        private CCWin.SkinControl.SkinComboBox stopBitsComboBox;
        private CCWin.SkinControl.SkinComboBox dataBitsComboBox;
        private CCWin.SkinControl.SkinComboBox baudComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinComboBox parityComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinTextBox desDown;
        private CCWin.SkinControl.SkinTextBox desUp;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private CCWin.SkinControl.SkinTextBox temDown;
        private CCWin.SkinControl.SkinTextBox temUp;
        private CCWin.SkinControl.SkinButton renewLineDesButton;
        private CCWin.SkinControl.SkinButton renewLineTemButton;
        private CCWin.SkinControl.SkinCheckBox hideLineDesCheckBox;
        private CCWin.SkinControl.SkinCheckBox hideLineTemCheckBox;
        private System.Windows.Forms.PictureBox desWarningFlag;
        private CCWin.SkinControl.SkinLabel skinLabel25;
        private System.Windows.Forms.PictureBox temWarningFlag;
        private CCWin.SkinControl.SkinLabel skinLabel24;
        private CCWin.SkinControl.SkinCheckBox curveCheckBox;
        private CCWin.SkinControl.SkinButton findExEXEButton;
        private CCWin.SkinControl.SkinTextBox exEXEPathTextBox;
        public System.Windows.Forms.Timer timerSave;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinButton btnFindData;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLine skinLine6;
        private CCWin.SkinControl.SkinButton btnPrintCurve;
        private System.Windows.Forms.Panel panelLocation2;
        private System.Windows.Forms.Panel panelLocation1;
        private System.Windows.Forms.DataGridView dataGridViewFindData;
        private CCWin.SkinControl.SkinComboBox protocolComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel33;
        private CCWin.SkinControl.SkinComboBox temUnitsComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel26;
        private CCWin.SkinControl.SkinLabel labelDriveGain;
        private CCWin.SkinControl.SkinLine skinLine2;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.PictureBox drgWarningFlag;
        private CCWin.SkinControl.SkinCheckBox hideLineDrgCheckBox;
        private CCWin.SkinControl.SkinButton renewLineDrgButton;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel34;
        private CCWin.SkinControl.SkinTextBox drgDown;
        private CCWin.SkinControl.SkinTextBox drgUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinLabel skinLabel35;
        private System.Windows.Forms.PictureBox pictureBoxTimeOutLimits;
        private System.Windows.Forms.PictureBox pictureBoxSensorCheck;
        private CCWin.SkinControl.SkinLabel skinLabel37;
        private CCWin.SkinControl.SkinLabel skinLabel36;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CCWin.SkinControl.SkinButton btnOpenConnect;
        private CCWin.SkinControl.SkinButton btnChangeUpDown;
        private System.Windows.Forms.PictureBox pictureBoxConnect;
        private System.Windows.Forms.Label labelConnect;
        private CCWin.SkinControl.SkinButton btnExportSqliteToExcel;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.TextBox nmupYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 温度;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
    }
}



