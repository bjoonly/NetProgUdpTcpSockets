using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

namespace Client
{
  
    public partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
           
        }
       private void Work()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(ipPoint);
                   

                string message="";
              
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                if (string.IsNullOrEmpty(loginTB.Text) || string.IsNullOrEmpty(PasswordTB.Text))
                {
                    MessageBox.Show("Enter login and password!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(MessageTB.Text))
                {
                    MessageBox.Show("Enter a message!");
                    return;
                }
                message= loginTB.Text + "\n" + PasswordTB.Text + "\n" + MessageTB.Text;
                }));
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);


                data = new byte[256];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    list.Items.Add(builder.ToString());

                }));
            }
            catch 
            {
               
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    
    private void Button_Click(object sender, RoutedEventArgs e)
    {
            Task.Run(Work);
    }
              
    }
}
