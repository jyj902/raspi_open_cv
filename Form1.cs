using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //시리얼통신을 위해 추가해줘야 함

namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
        }
               
        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                //serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                //serialPort1.BaudRate = 115200;  //보레이트 변경이 필요하면 숫자 변경하기
                //serialPort1.DataBits = 8;
                //serialPort1.StopBits = StopBits.One;
                //serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //이것이 꼭 필요하다
                
                serialPort1.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }
                
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {            
            char ReceiveData = (char)serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기

            richTextBox_received.Text = richTextBox_received.Text + ReceiveData.ToString(); //string.Format("{0:G}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
        }

        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            serialPort1.Write(textBox_send.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
        }

        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            comboBox_port.DataSource = SerialPort.GetPortNames();
        }

        private void Config_Btn_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            if(Dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                serialPort1.BaudRate = Convert.ToInt32(Dlg.BaudRate);
                serialPort1.PortName = Dlg.PortName;
                serialPort1.DataBits = Dlg.DataBits;
                if (Dlg.StopBit == "None") serialPort1.StopBits = StopBits.None;
                else if(Dlg.StopBit == "One") serialPort1.StopBits = StopBits.One;
                else if (Dlg.StopBit == "OnePointFive") serialPort1.StopBits = StopBits.OnePointFive;
                else if (Dlg.StopBit == "Two") serialPort1.StopBits = StopBits.Two;
                if (Dlg.Parity == "Even") serialPort1.Parity = Parity.Even;
                else if (Dlg.Parity == "Mark") serialPort1.Parity = Parity.Mark;
                else if (Dlg.Parity == "None") serialPort1.Parity = Parity.None;
                else if (Dlg.Parity == "Odd") serialPort1.Parity = Parity.Odd;
                else if (Dlg.Parity == "Space") serialPort1.Parity = Parity.Space;
            }
        }

        private void textBox_send_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Write(textBox_send.Text);
        }
    }
}
