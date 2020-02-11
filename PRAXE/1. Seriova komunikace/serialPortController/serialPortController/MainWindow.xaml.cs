using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;


namespace serialPortController
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort port;
        public MainWindow()
        {
            InitializeComponent();
            updateCOMlist();
        }

        private void updateCOMlist()
        {
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.
            foreach (string port in ports)
            {
                selectCOMport.Items.Add(port);
                Console.WriteLine(port);
            }
        }

        private void ConnectToDevice_Click(object sender, RoutedEventArgs e)
        {
            port = new SerialPort(selectCOMport.Text, 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void SnadToDevice_Click(object sender, RoutedEventArgs e)
        {
            port.WriteLine(stringTextbox.Text);
        }
    }
}
