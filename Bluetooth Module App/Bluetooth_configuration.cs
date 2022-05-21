using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bluethooth_Module_App
{
    public partial class Bluetooth_configuration : Form
    {
        static SerialPort port;
        static string Message = "";
        List<String> Message_list = new List<String>();
        List<String> Status_list = new List<String>();
        bool Status_check = false;

        TextBox[] Box_array;
        Label[] Label_array;
        String[,] Command_array = new string[,] { { "NAME", "PSWD" }, { "ADDR", "VERSION" } };

        List<String> Role_list = new List<String>{"Slave","Master","Slave-Loop" };

        public Bluetooth_configuration()
        {
            InitializeComponent();
        }

        private void Status_Update(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                Write("AT+STATE?\r\n");

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Status_list.Count != 2)
                {
                    if (stopWatch.ElapsedMilliseconds > 2000)
                    {
                        MessageBox.Show("Cannot read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        Disconnect();
                        return;
                    }
                }

                if (Status_list[1] == "OK")
                {
                    Status_Timer.Enabled = true;
                    Module_Status.Text = Status_list[0].Replace("+STATE:", "");
                    Module_Status.ForeColor = Color.Blue;
                    Status_list.Clear();
                }
            }
            else
            {
                Disconnect();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Baud_Rate_select_box.SelectedItem = "9600"; //Default value

            string[] ports = SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                Port_box.Items.Add(ports[i]);
            }

            Status.Text = "Disconnected";
            Status.ForeColor = Color.Red;

            Module_Status.Text = "Disconnected";
            Module_Status.ForeColor = Color.Red;

            Module_Version.Text = "";
            Module_Adress.Text = "";

            Box_array = new TextBox[] { Name_box, Password_box };
            Label_array = new Label[] { Module_Adress, Module_Version };
        }

        void GetAllMessage(string msg)
        {
            Message += msg;
            int index = Message.IndexOf("\r\n");
            if (index != -1)
            {
                string message = Message.Substring(0, index + 2);
                Message = Message.Remove(0, index + 2);

                if (message.Contains("+STATE:"))
                {
                    Status_list.Add(message.Replace("\r\n", ""));
                    Status_check = true;
                }
                else
                {
                    if (!Status_check)
                    {
                        Message_list.Add(message.Replace("\r\n", ""));
                    }
                    else
                    {
                        Status_check = false;
                        Status_list.Add(message.Replace("\r\n", ""));
                    }
                }
            }

            if (Message.Contains("\r\n"))
            {
                GetAllMessage("");
            }
        }

        void Connect()
        {
            Connect_Button.Text = "Disconnect";

            port = new SerialPort(Port_box.SelectedItem.ToString());
            port.DataReceived += Port_DataReceived;
            port.ErrorReceived += Port_ErrorReceived;
            port.BaudRate = Convert.ToInt32(Baud_Rate_select_box.SelectedItem);
            port.WriteTimeout = 1000;

            try
            {
                port.Open();
            }
            catch
            {
                Disconnect();
                MessageBox.Show("Cannot connect! Try diferent Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            port.ReadExisting();
            Thread.Sleep(500); //psalo to driv nez se otevrel port
            try
            {
                port.Write("AT\r\n");
            }
            catch
            {
                Disconnect();
                MessageBox.Show("Cannot connect! Try diferent Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            while (Message_list.Count != 1)
            {
                if (stopWatch.ElapsedMilliseconds > 1000)
                {
                    Disconnect();
                    MessageBox.Show("Cannot connect! Try diferent Port or Baud Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stopWatch.Stop();
                    stopWatch.Reset();
                    return;
                }
            }

            if (Message_list[0] == "OK")
            {
                Status_Timer.Enabled = true;
                Message_list.Clear();
                Status.Text = "Connected";
                Status.ForeColor = Color.Green;
                Read_Module();
            }
        }

        void Read_Module()
        {
            Stopwatch stopWatch;

            for (int i = 0; i < Box_array.Length; i++)
            {
                Write(String.Format("AT+{0}?\r\n", Command_array[0, i]));

                stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Message_list.Count != 2)
                {
                    if (stopWatch.ElapsedMilliseconds > 1000)
                    {
                        MessageBox.Show("Cannot read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        return;
                    }
                }

                if (Message_list[1] == "OK")
                {
                    Box_array[i].Text = Message_list[0].Replace(String.Format("+{0}:", Command_array[0, i]), "");
                    Message_list.Clear();            
                }
            }

            for (int i = 0; i < Label_array.Length; i++)
            {
                Write(String.Format("AT+{0}?\r\n", Command_array[1, i]));

                stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Message_list.Count != 2)
                {
                    if (stopWatch.ElapsedMilliseconds > 1000)
                    {
                        MessageBox.Show("Cannot read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        return;
                    }
                }

                if (Message_list[1] == "OK")
                {
                    Label_array[i].Text = Message_list[0].Replace(String.Format("+{0}:", Command_array[1, i]), "");
                    Message_list.Clear();
                }
            }

            Write("AT+UART?\r\n"); //Baud Rate

            stopWatch = new Stopwatch();
            stopWatch.Start();

            while (Message_list.Count != 2)
            {
                if (stopWatch.ElapsedMilliseconds > 1000)
                {
                    MessageBox.Show("Cannot read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stopWatch.Stop();
                    stopWatch.Reset();
                    return;
                }
            }

            if (Message_list[1] == "OK")
            {

                Baud_Rate_box.SelectedItem = Message_list[0].Split(',')[0].Replace("+UART:", "");
                Message_list.Clear();
            }

            Write("AT+ROLE?\r\n"); //Role

            stopWatch = new Stopwatch();
            stopWatch.Start();

            while (Message_list.Count != 2)
            {
                if (stopWatch.ElapsedMilliseconds > 1000)
                {
                    MessageBox.Show("Cannot read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stopWatch.Stop();
                    stopWatch.Reset();
                    return;
                }
            }

            if (Message_list[1] == "OK")
            {

                Role_box.SelectedItem = Role_list[Convert.ToInt32(Message_list[0].Replace("+ROLE:",""))];
                Message_list.Clear();
            }
        }

        void Disconnect()
        {
            Connect_Button.Text = "Connect";

            try
            {
                port.Close();
            }
            catch
            {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            port = null;

            Status.Text = "Disconnected";
            Status.ForeColor = Color.Red;

            Module_Status.Text = "Disconnected";
            Module_Status.ForeColor = Color.Red;

            Module_Version.Text = "";
            Module_Adress.Text = "";


            for (int i = 0; i < Box_array.Length; i++)
            {
                Box_array[i].Text = "";
            }

            Baud_Rate_box.SelectedIndex = -1;
            Role_box.SelectedIndex = -1;

            Status_Timer.Enabled = false;

            Message_list.Clear();
            Status_list.Clear();
        }

        void Write(string msg)
        {
            try 
            {
                port.Write(msg);
            }
            catch
            {
                MessageBox.Show("Cannot write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = port.ReadExisting();
            GetAllMessage(msg);
        }

        private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Connect_onClick(object sender, EventArgs e)
        {
            if (Connect_Button.Text == "Connect")
            {
                if (Port_box.SelectedItem != null && Baud_Rate_select_box.SelectedItem != null)
                {
                    Connect();
                }
                else
                {
                    MessageBox.Show("Port or Baud Rate are not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Disconnect();
            }
        }

        private void Change_onClick(object sender, EventArgs e)
        {
            try
            {
                Change();
            }
            catch
            {
                MessageBox.Show("Cannot make change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void Change()
        {
            if (port != null && port.IsOpen)
            {
                Stopwatch stopWatch;

                for (int i = 0; i < Box_array.Length; i++)
                {
                    String comm = String.Format("AT+{0}={1}\r\n", Command_array[0, i], Box_array[i].Text);
                    Write(comm);

                    stopWatch = new Stopwatch();
                    stopWatch.Start();

                    while (Message_list.Count != 1)
                    {
                        if (stopWatch.ElapsedMilliseconds > 1000)
                        {
                            MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            stopWatch.Stop();
                            stopWatch.Reset();
                            return;
                        }
                    }

                    if (Message_list[0] == "OK")
                    {
                        Message_list.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Write(String.Format("AT+UART={0}\r\n", Baud_Rate_box.SelectedItem.ToString() + ", 0, 0")); //Baud Rate 

                stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Message_list.Count != 1)
                {
                    if (stopWatch.ElapsedMilliseconds > 1000)
                    {
                        MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        return;
                    }
                }

                if (Message_list[0] == "OK")
                {
                    Message_list.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Write(String.Format("AT+ROLE={0}\r\n", Role_list.IndexOf(Role_box.SelectedItem.ToString()))); ; //Role

                stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Message_list.Count != 1)
                {
                    if (stopWatch.ElapsedMilliseconds > 1000)
                    {
                        MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        return;
                    }
                }



                if (Message_list[0] == "OK")
                {
                    Message_list.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR: Cannot write.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Changes was applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Reset_onClick(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                Change();
                Write("AT+RESET\r\n");

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                while (Message_list.Count != 1)
                {
                    if (stopWatch.ElapsedMilliseconds > 2000)
                    {
                        MessageBox.Show("Cannot make change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stopWatch.Stop();
                        stopWatch.Reset();
                        return;
                    }
                }

                if (Message_list[0] == "OK")
                {
                    Message_list.Clear();
                    Baud_Rate_select_box.SelectedItem = Baud_Rate_box.SelectedItem;
                    Disconnect();
                    Connect();
                    MessageBox.Show("Reset was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else
            {
                MessageBox.Show("You are not connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FC_Reset_onClick(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Factory Reset",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {

                    Write("AT+ORGL\r\n");

                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    while (Message_list.Count != 1)
                    {
                        if (stopWatch.ElapsedMilliseconds > 10000)
                        {
                            MessageBox.Show("Cannot write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            stopWatch.Stop();
                            stopWatch.Reset();
                            return;
                        }
                    }

                    if (Message_list[0] == "OK")
                    {
                        Message_list.Clear();
                        Disconnect();
                        Connect();
                        MessageBox.Show("Factory Reset was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You are not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
    


