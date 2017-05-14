using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using CDM.Model;

namespace CDM管理系统
{
    public partial class Form_SerialConfig : Form
    {

        public string ComText => comcmb.Text;

        SerialPortConfig mSerialPortConfig;

        public Form_SerialConfig()
        {
            InitializeComponent();
        }

        public Form_SerialConfig(SerialPortConfig pSerrialPortConfig)
        {
            InitializeComponent();
            mSerialPortConfig = pSerrialPortConfig;
            
        }

        private void Form_SerialConfig_Load(object sender, EventArgs e)
        {
            #region SerialInit
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comcmb.Items.Clear();
            comcmb.Items.AddRange(ports);
            comcmb.SelectedIndex = comcmb.Items.Count > 0 ? 0 : -1;
            #endregion
            #region DataInit
            foreach (var control in protocolGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    var index = Convert.ToInt32(radio.Tag);
                    if (index == mSerialPortConfig.ProtocolIndex)
                        radio.Checked = true;
                }
            }

            foreach (var control in jiaoyanGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    var index = Convert.ToInt32(radio.Tag);
                    if (index == mSerialPortConfig.ParityIndex)
                        radio.Checked = true;
                }
            }

            foreach (var control in stopbitsGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    var index = Convert.ToInt32(radio.Tag);
                    if (index == mSerialPortConfig.StopBitsIndex)
                        radio.Checked = true;
                }
            }

            foreach (var control in baudrateGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    var index = Convert.ToInt32(radio.Tag);
                    if (index == mSerialPortConfig.BaudRateIndex)
                        radio.Checked = true;
                }
            }

            nmudSlaveAdderss.Value = mSerialPortConfig.BiaoAddressValue;

            #endregion
            buttonConnect.Enabled = !mSerialPortConfig.PortIsOpen;
            buttonDisConnect.Enabled = mSerialPortConfig.PortIsOpen;
        }

        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comcmb.Text.Contains("COM") == false)
            {
                this.DialogResult = DialogResult.Abort;
                return;
            }
                   
            foreach(var control in protocolGroupBox.Controls)
            {
                if(control is RadioButton radio)
                {
                    if(radio.Checked == true)
                    {
                        var index = Convert.ToInt32(radio.Tag);
                        mSerialPortConfig.ProtocolIndex = index;
                        break;
                    }
                }
            }

            foreach (var control in jiaoyanGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    if (radio.Checked == true)
                    {
                        var index = Convert.ToInt32(radio.Tag);
                        mSerialPortConfig.ParityIndex = index;
                        break;
                    }
                }
            }

            foreach (var control in stopbitsGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    if (radio.Checked == true)
                    {
                        var index = Convert.ToInt32(radio.Tag);
                        mSerialPortConfig.StopBitsIndex= index;
                        break;
                    }
                }
            }

            foreach (var control in baudrateGroupBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    if (radio.Checked == true)
                    {
                        var index = Convert.ToInt32(radio.Tag);
                        mSerialPortConfig.BaudRateIndex = index;
                        break;
                    }
                }
            }
            mSerialPortConfig.BiaoAddressValue = nmudSlaveAdderss.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void buttonRenew_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                MessageBox.Show("没有可用的串口，请检查硬件连接");
            }
            Array.Sort(ports);
            comcmb.Items.Clear();
            comcmb.Items.AddRange(ports);
            comcmb.SelectedIndex = comcmb.Items.Count > 0 ? 0 : -1;
        }


    }
}
