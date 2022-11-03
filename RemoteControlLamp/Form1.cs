using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace RemoteControlLamp
{
    public partial class btnGreenMed : Form
    {
        String topic = "remotelamp";
        MqttClient client = new MqttClient(IPAddress.Parse("163.44.192.189")); //Make a client object and parses the IP address of the cloudserver
        SerialPort serialPort = new SerialPort();
        public btnGreenMed()
        {
            InitializeComponent();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
            serialPort.Open();
        }

        //Sends data to arduino to control LEDs
        private void btnRedLow_Click(object sender, EventArgs e) //Red LED low brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("Q");
        }

        private void btnRedMed_Click(object sender, EventArgs e) //Red LED medium brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("W");
        }

        private void btnRedMax_Click(object sender, EventArgs e) //Red LED max brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("E");
        }

        private void btnGreenLow_Click(object sender, EventArgs e) //Green LED low brightness
            {
            timer1.Enabled = true;
            serialPort.WriteLine("R");
        }

        private void button2_Click(object sender, EventArgs e) //Green LED medium brightness
            {
            timer1.Enabled = true;
            serialPort.WriteLine("T");
        }

        private void btnGreenMax_Click(object sender, EventArgs e) //Green LED max brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("Y");
        }

        private void btnBlueLow_Click(object sender, EventArgs e) //Blue LED low brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("U");
        }

        private void btnBlueMed_Click(object sender, EventArgs e) //Blue LED medium brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("I");
        }

        private void btnBlueMax_Click(object sender, EventArgs e) //Blue LED max brightness
        {
            timer1.Enabled = true;
            serialPort.WriteLine("O");
        }

        private void btnXmasMode_Click(object sender, EventArgs e) //Turns on all LEDs
        {
            timer1.Enabled = true;
            serialPort.WriteLine("C");
        }


        private void btnConnectMQTT_Click(object sender, EventArgs e) //Connects to MQTT and publishes data to the server
        {
            client.Connect(Guid.NewGuid().ToString(), "admin", "password");
            this.Text = " connect server MQTT status: " + client.IsConnected;

            string[] topic1 = { "remotelamp"};
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };

            client.MqttMsgSubscribed += Client_MqttMsgSubscribed;
            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            client.Subscribe(topic1, qosLevels);
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            String data = UnicodeEncoding.ASCII.GetString(e.Message);
            this.Invoke(new MethodInvoker(delegate ()
            {
                this.Text = data;
                String myData = data;
                StringBuilder sb = new StringBuilder(myData);
                //this.richTextBox1.AppendText("data: " + sb.ToString() + "\n");
                //this.richTextBox1.AppendText(sb.ToString()+"\n");

                if (myData.Contains("Turned off"))
                {
                    btnOff.Enabled = true;
                    this.richTextBox2.AppendText(sb.ToString() + "\n");
                }

                else if (myData.Contains("Red LED: low brightness"))
                {
                    //btnRedLow_Click(myData, e);
                    btnRedLow.Enabled = true;
                    this.richTextBox2.AppendText(sb.ToString() + "\n");
                    //timer2.Enabled = true;
                }

                else if (myData.Contains("Turning on The Anh's lamp"))
                {
                    AnhLamp.Enabled = true;
                    this.richTextBox2.AppendText(sb.ToString() + "\n");
                }
            }));
        }
        private void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                this.Text = "Subscribe server-- ";
            }));
        }

        private void btnOff_Click(object sender, EventArgs e) //Turns off the system
        {
            timer1.Enabled = true;
            serialPort.WriteLine("P");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String data = serialPort.ReadExisting();
            //richTextBox1.Text += "Data: " + data + "\n";
            richTextBox1.AppendText(data);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            client.Publish(topic, bytes);
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            String data = serialPort.ReadExisting();
            //richTextBox1.Text += "Data: " + data + "\n";
            richTextBox1.AppendText(data);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            client.Publish(topic, bytes);
        }

        private void AnhLamp_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            serialPort.WriteLine("A");
        }
    }
}
