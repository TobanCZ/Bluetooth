using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluethooth
{
    class Program
    {
        static SerialPort port;
        static string Message = "";
        static string[] ports;
        static void Main(string[] args)
        {
            port = new SerialPort("COM5");
            port.DataReceived += Port_DataReceived;
            port.BaudRate = 9600;
            port.Open();
            port.Write("AT\r\n");
            port.Write("AT+NAME?\r\n");
            port.Write("AT+PSWD?\r\n");
            port.Write("AT+STATE?\r\n");
            port.Write("AT+CLASS?\r\n");
            ports = SerialPort.GetPortNames();

            for(int i =0;i < ports.Length;i++)
            {
                Console.WriteLine(ports[i]);
            }

            while (true) ;
        }

        private static void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = port.ReadExisting();
            GetAllMessage(msg);
        }

        static void GetAllMessage(string msg)
        {
            Message += msg;
            int index = Message.IndexOf("\r\n");
            if (index != -1)
            {
                string message = Message.Substring(0,index + 2);
                Message = Message.Remove(0,index + 2);
                Console.Write(message);
            }

            if (Message.Contains("\r\n"))
            {
                GetAllMessage("");
            }
        }
    }
}
