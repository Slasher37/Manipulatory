using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.IO.Ports;
using System.Threading;


namespace manipulatory
{
    public partial class Window1
    {
        public delegate void NoArgDelegate();
        static SerialPort Sp;
        string portName = "COM5";
        string data;
        char[] Message;
        public Window1()
        {
            this.InitializeComponent();
            Message = new char[100];

            // Insert code required on object creation below this point.
        }

        private void bt_connect(object sender, RoutedEventArgs e)
        {
            Sp = new SerialPort();
            Sp.PortName = portName;
            Sp.Parity = Parity.Even;
            Sp.StopBits = StopBits.Two;
            Sp.DataBits = 8;
            Sp.BaudRate = 9600;
            Sp.PortName = portName;
            Sp.Open();
            Sp.Write("WH \r");
            for (int i = 0; i < 100; i++)
            {

                if (Message[i] == '\r') break;
            }
           
            
        }

        //private void _OnDataRecieved(object sender, SerialDataReceivedEventArgs e)
        //{
        //    base.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Send, (NoArgDelegate)delegate
        //    {
        //        data = Sp.ReadExisting();
        //        tb_status.Text = data;
        //    }
        //    );
        //}

    }
}