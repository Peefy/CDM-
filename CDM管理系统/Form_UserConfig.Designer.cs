namespace CDM管理系统
{
    partial class Form_UserConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserConfig));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.textBoxAgainPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserListBox = new CCWin.SkinControl.SkinListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(313, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 33);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.btnChange);
            this.groupBoxUser.Controls.Add(this.btnSub);
            this.groupBoxUser.Controls.Add(this.btnAdd);
            this.groupBoxUser.Controls.Add(this.textBoxAgainPassWord);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Controls.Add(this.textBoxNewPassWord);
            this.groupBoxUser.Controls.Add(this.label3);
            this.groupBoxUser.Controls.Add(this.textBoxOldPassWord);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.textBoxUserName);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Location = new System.Drawing.Point(211, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(177, 204);
            this.groupBoxUser.TabIndex = 5;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "用户信息";
            // 
            // textBoxAgainPassWord
            // 
            this.textBoxAgainPassWord.Enabled = false;
            this.textBoxAgainPassWord.Location = new System.Drawing.Point(65, 140);
            this.textBoxAgainPassWord.Name = "textBoxAgainPassWord";
            this.textBoxAgainPassWord.Size = new System.Drawing.Size(100, 21);
            this.textBoxAgainPassWord.TabIndex = 8;
            this.textBoxAgainPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "确认密码";
            // 
            // textBoxNewPassWord
            // 
            this.textBoxNewPassWord.Enabled = false;
            this.textBoxNewPassWord.Location = new System.Drawing.Point(65, 113);
            this.textBoxNewPassWord.Name = "textBoxNewPassWord";
            this.textBoxNewPassWord.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewPassWord.TabIndex = 6;
            this.textBoxNewPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "新密码";
            // 
            // textBoxOldPassWord
            // 
            this.textBoxOldPassWord.Enabled = false;
            this.textBoxOldPassWord.Location = new System.Drawing.Point(65, 68);
            this.textBoxOldPassWord.Name = "textBoxOldPassWord";
            this.textBoxOldPassWord.Size = new System.Drawing.Size(100, 21);
            this.textBoxOldPassWord.TabIndex = 3;
            this.textBoxOldPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "旧密码";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Location = new System.Drawing.Point(65, 20);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // UserListBox
            // 
            this.UserListBox.Back = null;
            this.UserListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 20;
            this.UserListBox.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("UserListBox.Items")))});
            this.UserListBox.Location = new System.Drawing.Point(13, 20);
            this.UserListBox.MouseColor = System.Drawing.Color.White;
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.RowBackColor2 = System.Drawing.Color.White;
            this.UserListBox.Size = new System.Drawing.Size(145, 164);
            this.UserListBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户列表";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("宋体", 10F);
            this.labelStatus.Location = new System.Drawing.Point(12, 227);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(147, 28);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "您不是管理员用户\r\n没有权限进行用户管理";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(64, 169);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(48, 23);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "删除";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(117, 169);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(48, 23);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form_UserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.btnConfirm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_UserConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox textBoxAgainPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOldPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinListBox UserListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
    }
}