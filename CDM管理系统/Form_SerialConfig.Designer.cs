namespace CDM管理系统
{
    partial class Form_SerialConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialConfig));
            this.serialGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonRenew = new System.Windows.Forms.Button();
            this.comcmb = new System.Windows.Forms.ComboBox();
            this.jiaoyanGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.stopbitsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.baudrateGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudSlaveAdderss = new System.Windows.Forms.NumericUpDown();
            this.protocolGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.serialGroupBox.SuspendLayout();
            this.jiaoyanGroupBox.SuspendLayout();
            this.stopbitsGroupBox.SuspendLayout();
            this.baudrateGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSlaveAdderss)).BeginInit();
            this.protocolGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialGroupBox
            // 
            this.serialGroupBox.Controls.Add(this.buttonRenew);
            this.serialGroupBox.Controls.Add(this.comcmb);
            this.serialGroupBox.Location = new System.Drawing.Point(13, 13);
            this.serialGroupBox.Name = "serialGroupBox";
            this.serialGroupBox.Size = new System.Drawing.Size(112, 100);
            this.serialGroupBox.TabIndex = 0;
            this.serialGroupBox.TabStop = false;
            this.serialGroupBox.Text = "串口";
            // 
            // buttonRenew
            // 
            this.buttonRenew.Location = new System.Drawing.Point(22, 22);
            this.buttonRenew.Name = "buttonRenew";
            this.buttonRenew.Size = new System.Drawing.Size(68, 23);
            this.buttonRenew.TabIndex = 1;
            this.buttonRenew.Text = "刷新";
            this.buttonRenew.UseVisualStyleBackColor = true;
            this.buttonRenew.Click += new System.EventHandler(this.buttonRenew_Click);
            // 
            // comcmb
            // 
            this.comcmb.FormattingEnabled = true;
            this.comcmb.Location = new System.Drawing.Point(22, 55);
            this.comcmb.Name = "comcmb";
            this.comcmb.Size = new System.Drawing.Size(68, 20);
            this.comcmb.TabIndex = 0;
            // 
            // jiaoyanGroupBox
            // 
            this.jiaoyanGroupBox.Controls.Add(this.radioButton3);
            this.jiaoyanGroupBox.Controls.Add(this.radioButton2);
            this.jiaoyanGroupBox.Controls.Add(this.radioButton1);
            this.jiaoyanGroupBox.Location = new System.Drawing.Point(131, 12);
            this.jiaoyanGroupBox.Name = "jiaoyanGroupBox";
            this.jiaoyanGroupBox.Size = new System.Drawing.Size(100, 200);
            this.jiaoyanGroupBox.TabIndex = 0;
            this.jiaoyanGroupBox.TabStop = false;
            this.jiaoyanGroupBox.Text = "校验";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "1";
            this.radioButton3.Text = "偶校验";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "奇校验";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "无校验";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // stopbitsGroupBox
            // 
            this.stopbitsGroupBox.Controls.Add(this.radioButton4);
            this.stopbitsGroupBox.Controls.Add(this.radioButton5);
            this.stopbitsGroupBox.Controls.Add(this.radioButton6);
            this.stopbitsGroupBox.Location = new System.Drawing.Point(237, 12);
            this.stopbitsGroupBox.Name = "stopbitsGroupBox";
            this.stopbitsGroupBox.Size = new System.Drawing.Size(116, 200);
            this.stopbitsGroupBox.TabIndex = 0;
            this.stopbitsGroupBox.TabStop = false;
            this.stopbitsGroupBox.Text = "停止位";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 60);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Tag = "1";
            this.radioButton4.Text = "2个停止位";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 95);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Tag = "2";
            this.radioButton5.Text = "1.5个停止位";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 25);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(77, 16);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "0";
            this.radioButton6.Text = "1个停止位";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // baudrateGroupBox
            // 
            this.baudrateGroupBox.Controls.Add(this.radioButton12);
            this.baudrateGroupBox.Controls.Add(this.radioButton11);
            this.baudrateGroupBox.Controls.Add(this.radioButton7);
            this.baudrateGroupBox.Controls.Add(this.radioButton10);
            this.baudrateGroupBox.Controls.Add(this.radioButton8);
            this.baudrateGroupBox.Controls.Add(this.radioButton9);
            this.baudrateGroupBox.Location = new System.Drawing.Point(359, 13);
            this.baudrateGroupBox.Name = "baudrateGroupBox";
            this.baudrateGroupBox.Size = new System.Drawing.Size(100, 199);
            this.baudrateGroupBox.TabIndex = 0;
            this.baudrateGroupBox.TabStop = false;
            this.baudrateGroupBox.Text = "波特率";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(16, 175);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(53, 16);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.Tag = "5";
            this.radioButton12.Text = "38400";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(16, 145);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(53, 16);
            this.radioButton11.TabIndex = 0;
            this.radioButton11.Tag = "4";
            this.radioButton11.Text = "19200";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(16, 85);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(47, 16);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.Tag = "2";
            this.radioButton7.Text = "4800";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(16, 115);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(47, 16);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Tag = "3";
            this.radioButton10.Text = "9600";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(16, 55);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 16);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Tag = "1";
            this.radioButton8.Text = "2400";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(16, 25);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(47, 16);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.Tag = "0";
            this.radioButton9.Text = "1200";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCancel);
            this.groupBox5.Controls.Add(this.buttonConnect);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.nmudSlaveAdderss);
            this.groupBox5.Location = new System.Drawing.Point(465, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(126, 199);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "连接";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(14, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(14, 58);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 36);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地址";
            // 
            // nmudSlaveAdderss
            // 
            this.nmudSlaveAdderss.Location = new System.Drawing.Point(53, 22);
            this.nmudSlaveAdderss.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmudSlaveAdderss.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudSlaveAdderss.Name = "nmudSlaveAdderss";
            this.nmudSlaveAdderss.Size = new System.Drawing.Size(60, 21);
            this.nmudSlaveAdderss.TabIndex = 1;
            this.nmudSlaveAdderss.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // protocolGroupBox
            // 
            this.protocolGroupBox.Controls.Add(this.radioButton14);
            this.protocolGroupBox.Controls.Add(this.radioButton13);
            this.protocolGroupBox.Location = new System.Drawing.Point(13, 112);
            this.protocolGroupBox.Name = "protocolGroupBox";
            this.protocolGroupBox.Size = new System.Drawing.Size(112, 100);
            this.protocolGroupBox.TabIndex = 0;
            this.protocolGroupBox.TabStop = false;
            this.protocolGroupBox.Text = "协议";
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(11, 59);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(95, 16);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.Tag = "1";
            this.radioButton14.Text = "Modbus ASCII";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Location = new System.Drawing.Point(11, 27);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(83, 16);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.TabStop = true;
            this.radioButton13.Tag = "0";
            this.radioButton13.Text = "Modbus RTU";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // Form_SerialConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 217);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.baudrateGroupBox);
            this.Controls.Add(this.stopbitsGroupBox);
            this.Controls.Add(this.jiaoyanGroupBox);
            this.Controls.Add(this.protocolGroupBox);
            this.Controls.Add(this.serialGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_SerialConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接";
            this.Load += new System.EventHandler(this.Form_SerialConfig_Load);
            this.serialGroupBox.ResumeLayout(false);
            this.jiaoyanGroupBox.ResumeLayout(false);
            this.jiaoyanGroupBox.PerformLayout();
            this.stopbitsGroupBox.ResumeLayout(false);
            this.stopbitsGroupBox.PerformLayout();
            this.baudrateGroupBox.ResumeLayout(false);
            this.baudrateGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSlaveAdderss)).EndInit();
            this.protocolGroupBox.ResumeLayout(false);
            this.protocolGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serialGroupBox;
        private System.Windows.Forms.Button buttonRenew;
        private System.Windows.Forms.ComboBox comcmb;
        private System.Windows.Forms.GroupBox jiaoyanGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox stopbitsGroupBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox baudrateGroupBox;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nmudSlaveAdderss;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox protocolGroupBox;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
    }
}