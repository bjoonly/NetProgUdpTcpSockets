using ClassLibrary;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Server
{
    class MyServer
    {
        public Service Service;
        public MyServer()
        {
            Service = new Service();
        }
        public Client GetClient(string login, string password)
        {
            return Service.GetClients().Where(c => c.Login == login && c.Password == password).FirstOrDefault();
        }
        public ExchangeRate GetRate(string from, string to)
        {
            return Service.GetRate(from, to);
        }
        public void AddLog(Log log)
        {
            Service.AddLog(log);

        }
        public void AddClient(string login, string password)
        {
            Service.AddClient(new Client() { Login = login, Password = password });
        }
        public bool IsMaxCountRequest(string login)
        {
            if (Service.CountLogsLastMin(login) >= 5)
                return true;
            return false;
        }
    }
    public partial class MainWindow : Window
    {
        MyServer server;
        Semaphore semaphore;

        int port = 8080;
        IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint ipPoint;
        public MainWindow()
        {
            InitializeComponent();
            server = new MyServer();
            semaphore = new Semaphore(2, 2);
            ipPoint = new IPEndPoint(iPAddress, port);
            Task.Run(Start);
        }
        public void Start()
        {
            try
            {

                Application.Current.Dispatcher.Invoke(new Action(() =>
                {

                    listBox.Items.Add("Server started! Waiting for connection...");


                }));
                Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listenSocket.Bind(ipPoint);

                while (true)
                {
                    listenSocket.Listen(10);
                    Socket handler = listenSocket.Accept();
                    Task.Run(() => Work(handler));

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void Work(Socket handler)
        {
            try
            {

                Log log = new Log();
                int bytes = 0;
                byte[] data = new byte[256];
                if (!semaphore.WaitOne(500))
                {
                    data = Encoding.Unicode.GetBytes("The max number of clients is connected to server, please try to connect later.");
                }
                else
                {
                    StringBuilder builder = new StringBuilder();
                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);
                    string[] lines = builder.ToString().Split('\n');
                    Client client = server.GetClient(lines[0], lines[1]);
                    if (server.IsMaxCountRequest(client.Login))
                    {
                        data = Encoding.Unicode.GetBytes("The max number of requests has been reached. Try sending your request in a minute.");
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {

                            listBox.Items.Add(String.Format("Customer {0} has exceeded the max number of requests.", client.Login));


                        }));
                    }
                    else if (client != null)
                    {
                        log.Client = client;
                        log.ConntectionTime = DateTime.Now;
                        string[] fromTo = lines[2].Split(' ');
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            listBox.Items.Add(String.Format("Customer: {0} \nConntection: {1}", log.Client.Login, log.ConntectionTime));
                        }));


                        ExchangeRate rate = server.GetRate(fromTo[0], fromTo[1]);
                        if (rate != null)
                        {
                            string message = rate.Rate.ToString();

                            data = Encoding.Unicode.GetBytes(message);

                            Thread.Sleep(3000);
                            log.ExchangeRate = rate;


                            log.ShutdownTime = DateTime.Now;
                            Application.Current.Dispatcher.Invoke(new Action(() =>
                            {
                                listBox.Items.Add(String.Format("Shutdown: {0}", log.ShutdownTime));

                            }));
                            server.AddLog(log);
               
                        }
                        else { data = Encoding.Unicode.GetBytes($"No information about the course {fromTo[0]} to {fromTo[1]}"); }
                    }
                    else
                    {
                        data = Encoding.Unicode.GetBytes("Client not found.");
                    }
                    semaphore.Release();
                }

                handler.Send(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            server.AddClient(loginTB.Text, PasswordTB.Text);
        }
    }
}
