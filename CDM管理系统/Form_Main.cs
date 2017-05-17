﻿using System;
using System.Drawing;
using System.Windows.Forms;
using CDM.Utils;

namespace 流量计检定上位机
{
    public partial class Form_Main : CCWin.CCSkinMain
    {
        Form_MainShow formMainShow;
        Size FormSetParaSize = new Size(715, 620);
        Size FormNomalSize = new Size(490, 620);
        Size FormAboutSize = new Size(490, 710);

        #region 主窗体初始化
        public Form_Main()
        {
            InitializeComponent();
            参数设定ToolStripMenuItem.Enabled = LoginInfo.IsManager;
            #region Init
            #region FormInit
            this.Size = FormNomalSize;
            this.Text = AppInfo.GetName();
            #endregion
            formMainShow = new Form_MainShow(this);
            formMainShow.Init();
            //Thread.Sleep(400);
            #endregion
        }

        public void Init()
        {
            #region Init
            #region FormInit
            this.Size = FormNomalSize;
            this.Text = AppInfo.GetName();
            #endregion
            formMainShow = new Form_MainShow(this);
            formMainShow.Init();
            
            //Thread.Sleep(400);
            #endregion
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            labelRegister.Text = SoftRegister.GetFreeRegisterNum();
            if(SoftRegister.IsRegister() == true)
            {
                panelRegister.Visible = false;
                menuStrip.Enabled = true;
                toolStrip.Enabled = true;
                formMainShow.MdiParent = this;
                formMainShow.WindowState = FormWindowState.Maximized;
                formMainShow.Show();
            }
        }

        #endregion
        #region MenuView
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        #endregion
        #region Print

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.btnPrintCurve_Click(null, null);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printToolStripMenuItem_Click(sender, e);
        }

        #endregion
        #region About

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.aboutToolStripMenuItem_Click(sender, e);
        }


        #endregion        
        #region ParaSet

        private void SetFlowMeterStad_Click(object sender, EventArgs e)
        {
            formMainShow.SetFlowMeterStad_Click(sender,e);
        }

        private void SetFlowMeterWork_Click(object sender, EventArgs e)
        {
            formMainShow.SetFlowMeterWork_Click(sender, e);
        }


        #endregion
        #region ParaSave

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.saveToolStripMenuItem_Click(sender, e);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            formMainShow.OpenFile(sender, e);
        }

        #endregion
        #region 标定控制

        private void btnStartDema_Click(object sender, EventArgs e)
        {
            formMainShow.btnStartDema_Click(sender, e);
        }

        private void btnStopDema_Click(object sender, EventArgs e)
        {
            formMainShow.btnStopDema_Click(sender, e);
        }

        private void 诊断信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.诊断信息ToolStripMenuItem_Click(sender, e);
        }

        private void 诊断结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.诊断结束ToolStripMenuItem_Click(sender, e);
        }

        private void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.打开端口ToolStripMenuItem_Click(sender, e);
        }

        #endregion
        #region 保存查询数据

        private void 查询数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.查询数据ToolStripMenuItem_Click(sender, e);
        }

        private void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.保存数据ToolStripMenuItem_Click(sender, e);
        }

        #endregion

        private void MenuItemGenerateReport_Click(object sender, EventArgs e)
        {
            formMainShow.MenuItemGenerateReport_Click(sender, e);               
        }

        private void MenuItemGenerateExcel_Click(object sender, EventArgs e)
        {
            formMainShow.MenuItemGenerateExcel_Click(sender, e);
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMainShow.Form_Main_FormClosing(sender, e);
            formMainShow.Close();
            Application.Exit();//退出整个应用程序。（无法退出单独开启的线程）
            Application.ExitThread();//释放所有线程　
        }

        private void RegisterMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool result = SoftRegister.RegisterING(labelRegister.Text);
            if(result == true)
            {
                MessageBox.Show("注册成功！");
                Form_Main_Load(null, null);
            }
            else
            {
                MessageBox.Show("注册码不对！");
            }  
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 串口连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.串口连接ToolStripMenuItem_Click(sender,e);
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            formMainShow.串口连接ToolStripMenuItem_Click(sender, e);
        }

        private void timerShowTime_Tick(object sender, EventArgs e)
        {

        }

        private void 参数设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMainShow.参数设定ToolStripMenuItem_Click(sender, e);
        }

        private void 用户管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formMainShow.用户管理ToolStripMenuItem_Click(sender, e);
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            panelRegister.Location = new Point(Width / 2 - panelRegister.Width / 2 - 5,
                Height / 2 - panelRegister.Height / 2);
        }
    }
}
