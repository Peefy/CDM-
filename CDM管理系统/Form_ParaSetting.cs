using System;
using System.Windows.Forms;

using Modbus.Device;
using CDM.Configs;
using static CDM.Helpers.ModbusFloatHelper;

namespace CDM管理系统
{
    public partial class Form_ParaSetting : Form
    {
        ModbusSerialMaster mMaster;
        byte mSlaveAddress = 1;

        public Form_ParaSetting(ModbusSerialMaster pMaster,byte pSlaveAddress)
        {         
            InitializeComponent();
            mMaster = pMaster;
            mSlaveAddress = pSlaveAddress;
        }

        private void Form_ParaSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonWrite_Click(null, null);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                var datas = mMaster?.ReadHoldingRegisters(mSlaveAddress,
                     (ushort)(AddressConfig.DensityCoefficient - 1), 2);
                textboxDensityCoe.Text = UshortToFloat(datas, 0, 3).ToString();

                datas = mMaster?.ReadHoldingRegisters(mSlaveAddress,
                    (ushort)(AddressConfig.K0 - 1), 2);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if(float.TryParse(textboxDensityCoe.Text,out var data) == true)
            {
                try
                {
                    mMaster?.WriteMultipleRegisters(mSlaveAddress,
                        (ushort)(AddressConfig.DensityCoefficient - 1),
                        FloatToUshort(data));
                }
                catch
                {
                    MessageBox.Show("仪表拒绝写入数据\r\n可能原因：数据不符合范围");
                }

            }
            else
            {
                MessageBox.Show("输入的数据不符合规范!");
            }
            
        }

        private void Form_ParaSetting_Load(object sender, EventArgs e)
        {
            buttonRead_Click(null, null);
        }
    }
}
