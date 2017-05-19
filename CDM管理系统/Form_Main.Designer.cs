namespace 流量计检定上位机
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.timerShowTime = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuShowDemarcate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.放大显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.timerSetData = new System.Windows.Forms.Timer(this.components);
            this.timerRenewPanelDema = new System.Windows.Forms.Timer(this.components);
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new CCWin.SkinControl.SkinButton();
            this.labelRegister = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGenerateExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.查询数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.MenuShowDemarcate.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip.Enabled = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolMenu,
            this.viewMenu,
            this.toolsMenu,
            this.userMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(4, 28);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.DarkGray;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.MenuItemGenerateExcel,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(58, 21);
            this.fileMenu.Text = "文件(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "退出(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolMenu
            // 
            this.toolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询数据ToolStripMenuItem});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(59, 21);
            this.toolMenu.Text = "工具(&T)";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(60, 21);
            this.viewMenu.Text = "视图(&V)";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolBarToolStripMenuItem.Text = "工具栏(&T)";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口连接ToolStripMenuItem,
            this.参数设定ToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(59, 21);
            this.toolsMenu.Text = "设置(&S)";
            // 
            // 参数设定ToolStripMenuItem
            // 
            this.参数设定ToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.参数设定ToolStripMenuItem.Name = "参数设定ToolStripMenuItem";
            this.参数设定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.参数设定ToolStripMenuItem.Text = "参数设定";
            this.参数设定ToolStripMenuItem.Click += new System.EventHandler(this.参数设定ToolStripMenuItem_Click);
            // 
            // userMenu
            // 
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem});
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(61, 21);
            this.userMenu.Text = "用户(&U)";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click_1);
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(61, 21);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip.Enabled = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(4, 53);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // timerGetData
            // 
            this.timerGetData.Enabled = true;
            this.timerGetData.Interval = 80;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // timerShowTime
            // 
            this.timerShowTime.Enabled = true;
            this.timerShowTime.Interval = 1000;
            this.timerShowTime.Tick += new System.EventHandler(this.timerShowTime_Tick);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MenuShowDemarcate
            // 
            this.MenuShowDemarcate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大显示});
            this.MenuShowDemarcate.Name = "MenuShowDemarcate";
            this.MenuShowDemarcate.Size = new System.Drawing.Size(125, 26);
            // 
            // 放大显示
            // 
            this.放大显示.Name = "放大显示";
            this.放大显示.Size = new System.Drawing.Size(124, 22);
            this.放大显示.Text = "放大显示";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(-15, -15);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(69, 17);
            this.skinLabel9.TabIndex = 28;
            this.skinLabel9.Text = "skinLabel9";
            // 
            // timerSetData
            // 
            this.timerSetData.Enabled = true;
            this.timerSetData.Interval = 400;
            // 
            // timerRenewPanelDema
            // 
            this.timerRenewPanelDema.Interval = 2000;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.labelRegister);
            this.panelRegister.Controls.Add(this.skinLabel1);
            this.panelRegister.Location = new System.Drawing.Point(7, 81);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(288, 134);
            this.panelRegister.TabIndex = 30;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BaseColor = System.Drawing.Color.DarkGray;
            this.btnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRegister.DownBack = null;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(102, 88);
            this.btnRegister.MouseBack = null;
            this.btnRegister.MouseBaseColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormlBack = null;
            this.btnRegister.Size = new System.Drawing.Size(85, 29);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "确定";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.DownBack = null;
            this.labelRegister.Icon = null;
            this.labelRegister.IconIsButton = false;
            this.labelRegister.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelRegister.IsPasswordChat = '\0';
            this.labelRegister.IsSystemPasswordChar = false;
            this.labelRegister.Lines = new string[0];
            this.labelRegister.Location = new System.Drawing.Point(17, 44);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(0);
            this.labelRegister.MaxLength = 32767;
            this.labelRegister.MinimumSize = new System.Drawing.Size(28, 28);
            this.labelRegister.MouseBack = null;
            this.labelRegister.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.labelRegister.Multiline = false;
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.NormlBack = null;
            this.labelRegister.Padding = new System.Windows.Forms.Padding(5);
            this.labelRegister.ReadOnly = false;
            this.labelRegister.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.labelRegister.Size = new System.Drawing.Size(252, 28);
            // 
            // 
            // 
            this.labelRegister.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelRegister.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRegister.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.labelRegister.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.labelRegister.SkinTxt.Name = "BaseText";
            this.labelRegister.SkinTxt.Size = new System.Drawing.Size(242, 18);
            this.labelRegister.SkinTxt.TabIndex = 0;
            this.labelRegister.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelRegister.SkinTxt.WaterText = "";
            this.labelRegister.TabIndex = 1;
            this.labelRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelRegister.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelRegister.WaterText = "";
            this.labelRegister.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(76, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(138, 22);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "请输入注册码注册";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "打开参数";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "保存参数";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "打印";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CDM管理系统.Properties.Resources.excel;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "导出今日数据";
            this.toolStripButton4.Click += new System.EventHandler(this.MenuItemGenerateExcel_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::CDM管理系统.Properties.Resources.find;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "查询历史数据";
            this.toolStripButton6.Click += new System.EventHandler(this.查询数据ToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CDM管理系统.Properties.Resources.Port_32px_530255_easyicon_net;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "串口连接";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openToolStripMenuItem.Text = "打开参数(&O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveToolStripMenuItem.Text = "保存参数(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.printToolStripMenuItem.Text = "打印(&P)";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MenuItemGenerateExcel
            // 
            this.MenuItemGenerateExcel.BackColor = System.Drawing.Color.DarkGray;
            this.MenuItemGenerateExcel.Image = global::CDM管理系统.Properties.Resources.excel;
            this.MenuItemGenerateExcel.Name = "MenuItemGenerateExcel";
            this.MenuItemGenerateExcel.Size = new System.Drawing.Size(189, 22);
            this.MenuItemGenerateExcel.Text = "导出今日数据";
            this.MenuItemGenerateExcel.Click += new System.EventHandler(this.MenuItemGenerateExcel_Click);
            // 
            // 查询数据ToolStripMenuItem
            // 
            this.查询数据ToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.查询数据ToolStripMenuItem.Image = global::CDM管理系统.Properties.Resources.find;
            this.查询数据ToolStripMenuItem.Name = "查询数据ToolStripMenuItem";
            this.查询数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询数据ToolStripMenuItem.Text = "查询数据";
            this.查询数据ToolStripMenuItem.Click += new System.EventHandler(this.查询数据ToolStripMenuItem_Click);
            // 
            // 串口连接ToolStripMenuItem
            // 
            this.串口连接ToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.串口连接ToolStripMenuItem.Image = global::CDM管理系统.Properties.Resources.Port_32px_530255_easyicon_net;
            this.串口连接ToolStripMenuItem.Name = "串口连接ToolStripMenuItem";
            this.串口连接ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.串口连接ToolStripMenuItem.Text = "仪表连接";
            this.串口连接ToolStripMenuItem.Click += new System.EventHandler(this.串口连接ToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1272, 727);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MdiBackColor = System.Drawing.Color.DarkGray;
            this.MinimumSize = new System.Drawing.Size(1272, 726);
            this.Name = "Form_Main";
            this.Radius = 10;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流量计检定上位机";
            this.TitleCenter = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.MenuShowDemarcate.ResumeLayout(false);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGenerateExcel;
        public System.Windows.Forms.Timer timerGetData;
        private System.Windows.Forms.Timer timerShowTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        public System.Windows.Forms.Timer timerSetData;
        public System.Windows.Forms.Timer timerRenewPanelDema;
        private System.Windows.Forms.ContextMenuStrip MenuShowDemarcate;
        private System.Windows.Forms.ToolStripMenuItem 放大显示;
        private System.Windows.Forms.ToolStripMenuItem 查询数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel panelRegister;
        private CCWin.SkinControl.SkinButton btnRegister;
        private CCWin.SkinControl.SkinTextBox labelRegister;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.ToolStripMenuItem 串口连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 参数设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
    }
}



