namespace CDM管理系统
{
    partial class Form_ParaSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ParaSetting));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.textboxDensityCoe = new CCWin.SkinControl.SkinTextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 23);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(74, 22);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "密度系数";
            // 
            // textboxDensityCoe
            // 
            this.textboxDensityCoe.BackColor = System.Drawing.Color.Transparent;
            this.textboxDensityCoe.DownBack = null;
            this.textboxDensityCoe.Icon = null;
            this.textboxDensityCoe.IconIsButton = false;
            this.textboxDensityCoe.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textboxDensityCoe.IsPasswordChat = '\0';
            this.textboxDensityCoe.IsSystemPasswordChar = false;
            this.textboxDensityCoe.Lines = new string[] {
        "0.1"};
            this.textboxDensityCoe.Location = new System.Drawing.Point(122, 71);
            this.textboxDensityCoe.Margin = new System.Windows.Forms.Padding(0);
            this.textboxDensityCoe.MaxLength = 32767;
            this.textboxDensityCoe.MinimumSize = new System.Drawing.Size(28, 28);
            this.textboxDensityCoe.MouseBack = null;
            this.textboxDensityCoe.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textboxDensityCoe.Multiline = false;
            this.textboxDensityCoe.Name = "textboxDensityCoe";
            this.textboxDensityCoe.NormlBack = null;
            this.textboxDensityCoe.Padding = new System.Windows.Forms.Padding(5);
            this.textboxDensityCoe.ReadOnly = false;
            this.textboxDensityCoe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxDensityCoe.Size = new System.Drawing.Size(92, 28);
            // 
            // 
            // 
            this.textboxDensityCoe.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDensityCoe.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxDensityCoe.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textboxDensityCoe.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textboxDensityCoe.SkinTxt.Name = "BaseText";
            this.textboxDensityCoe.SkinTxt.Size = new System.Drawing.Size(82, 18);
            this.textboxDensityCoe.SkinTxt.TabIndex = 0;
            this.textboxDensityCoe.SkinTxt.Text = "0.1";
            this.textboxDensityCoe.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textboxDensityCoe.SkinTxt.WaterText = "";
            this.textboxDensityCoe.TabIndex = 32;
            this.textboxDensityCoe.Text = "0.1";
            this.textboxDensityCoe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxDensityCoe.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textboxDensityCoe.WaterText = "";
            this.textboxDensityCoe.WordWrap = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(229, 134);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(78, 32);
            this.buttonRead.TabIndex = 33;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(315, 134);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(78, 32);
            this.buttonWrite.TabIndex = 33;
            this.buttonWrite.Text = "写入";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "注：此参数必须由系统管理员设定";
            // 
            // Form_ParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textboxDensityCoe);
            this.Controls.Add(this.skinLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_ParaSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设定";
            this.Load += new System.EventHandler(this.Form_ParaSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ParaSetting_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox textboxDensityCoe;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label label1;
    }
}