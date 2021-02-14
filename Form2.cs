using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Communication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Com_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public string BaudRate
        {
            get { return this.BaudRate_ComBox.Text; }
        }
        public string PortName
        {
            get { return this.PortName_ComBox.Text; }
        }
        public int DataBits
        {
            get { return Convert.ToInt32(this.DataBit_ComBox.Text); }
        }
        public string StopBit
        {
            get { return this.StopBit_ComBox.Text; }
        }
        public string Parity
        {
            get { return this.Parity_ComBox.Text; }
        }
        private void Search_Btn_Click(object sender, EventArgs e)
        {
            string[] Data = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            PortName_ComBox.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기6110 
            BaudRate_ComBox.Items.AddRange(Data);
            BaudRate_ComBox.SelectedIndex = 6;
            DataBit_ComBox.SelectedIndex = 1;
            StopBit_ComBox.SelectedIndex = 1;
            Parity_ComBox.SelectedIndex = 0;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            string[] Data = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            PortName_ComBox.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기6110 
            BaudRate_ComBox.Items.AddRange(Data);
            BaudRate_ComBox.SelectedIndex = 6;
            DataBit_ComBox.SelectedIndex = 1;
            StopBit_ComBox.SelectedIndex = 1;
            Parity_ComBox.SelectedIndex = 0;
        }
    }
}
