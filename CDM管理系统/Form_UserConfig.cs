using CDM.Sqlite;
using CDM.Utils;
using System;
using System.Windows.Forms;

namespace CDM管理系统
{
    public partial class Form_UserConfig : Form
    {

        string userName = "";
        string password = "";
        private ComWithSqlite comWithSqliteServer;

        public Form_UserConfig(ComWithSqlite comWithSqliteServer)
        {
            InitializeComponent();
            this.comWithSqliteServer = comWithSqliteServer;

            UserListBox.Items.Clear();
            if(LoginInfo.UserName != "管理员")
            {
                UserListBox.Items.Add(new CCWin.SkinControl.SkinListBoxItem(LoginInfo.UserName));
                UserListBox.SelectedIndex = 0;
            }               
            textBoxUserName.Text = LoginInfo.UserName;
            textBoxOldPassWord.Text = LoginInfo.PassWord;

            textBoxUserName.Enabled = LoginInfo.IsManager;
            textBoxNewPassWord.Enabled = LoginInfo.IsManager;
            textBoxAgainPassWord.Enabled = LoginInfo.IsManager;

            groupBoxUser.Enabled = LoginInfo.IsManager;
            labelStatus.Visible = !LoginInfo.IsManager;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个用户");
                return;
            }

            if(string.IsNullOrEmpty(textBoxNewPassWord.Text) == true ||
                string.IsNullOrEmpty(textBoxAgainPassWord.Text) == true || 
                    string.IsNullOrEmpty(textBoxUserName.Text) == true)
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            if(string.Equals(textBoxAgainPassWord.Text,
                textBoxNewPassWord.Text) == false)
            {
                MessageBox.Show("两次输入新密码不一致");
                return;
            }
            if(LoginInfo.ChangeUserNamePassword(textBoxUserName.Text, 
                textBoxAgainPassWord.Text) == true && 
                LoginInfo.ChangePassword(textBoxNewPassWord.Text) == true)
            {
                MessageBox.Show("修改成功!");
                textBoxOldPassWord.Text = textBoxAgainPassWord.Text;
            }
        }

        private void Form_UserConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
