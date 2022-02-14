using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluethooth_Module_App
{
    public partial class Form1 : Form
    {
        static SerialPort port;
        bool PortFind = false;
        static string Message = "";
        string[] ports;

        public Form1()
        {
            InitializeComponent();
        }

        private void Status_Update(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            FindPort();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = port.ReadExisting();
            GetAllMessage(msg);
        }

        void GetAllMessage(string msg)
        {
            Message += msg;
            int index = Message.IndexOf("\r\n");
            if (index != -1)
            {
                string message = Message.Substring(0, index + 2);
                Message = Message.Remove(0, index + 2);
                Console.Write(message);
            }

            if (Message.Contains("\r\n"))
            {
                GetAllMessage("");
            }
        }

        void FindPort()
        {
            ports = SerialPort.GetPortNames();

            port = new SerialPort("COM4");
            port.DataReceived += Port_DataReceived;
            port.BaudRate = 9600;
            port.Open();
            port.Write("AT\r\n");
            while (PortFind == false) ;
        }
    }
}

