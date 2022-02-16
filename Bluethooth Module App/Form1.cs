using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        static string Message = "";
        bool next = false;
        List<String> Message_list = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Status_Update(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            Baud_Rate_box.SelectedItem = "9600"; //Default value

            string[] ports = SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                Port_box.Items.Add(ports[i]);
            }


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
                Message_list.Add(message.Replace("\r\n",""));
            }

            if (Message.Contains("\r\n"))
            {
                GetAllMessage("");
            }
        }

        void Connect()
        {
            if(port != null)
            {
                port.Close();
            }

            port = new SerialPort(Port_box.SelectedItem.ToString());
            port.DataReceived += Port_DataReceived;
            port.ErrorReceived += Port_ErrorReceived;
            port.BaudRate = Convert.ToInt32(Baud_Rate_box.SelectedItem);
            port.WriteTimeout = 1000;

            try 
            {
                port.Open();
            }
            catch
            {
                MessageBox.Show("Cannot connect! Try diferent Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try 
            {
                port.Write("AT\r\n");
            }
            catch
            {
                MessageBox.Show("Cannot connect! Try diferent Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            
            while (Message_list.Count != 1)
            {
                if (stopWatch.ElapsedTicks > 5000)
                {
                    MessageBox.Show("Cannot connect! Try diferent Port or Baud Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stopWatch.Stop();
                    stopWatch.Reset();
                    return;
                }
            }

            if (Message_list[0] == "OK")
            {
                MessageBox.Show("pog");
                Message_list.Clear();
            }
        }

        private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Connect_onClick(object sender, EventArgs e)
        {
            if(Port_box.SelectedItem != null && Baud_Rate_box.SelectedItem != null)
            {
                Connect();
            }
            else
            {
                MessageBox.Show("Port or Baud Rate are not selected!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}

