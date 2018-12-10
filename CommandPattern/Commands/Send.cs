using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CommandPattern
{
    class Send : ICommand, ICommandFactory
    {
        ManualResetEvent connectDone = new ManualResetEvent(false);
        TcpClient client;
        public IPAddress IP = IPAddress.Parse("fe80::11f6:8c3:800b:ea90%4");//"10.141.152.191");
        public int Port = 2045;
        public string CommandName
        {
            get;
        } = "Send";
        public string Description
        {
            get;

        } = "Send -s or -f [filename] - s for update self, f for update a file";
        string Action;
        public void Execute()
        {
            StartConnect();
        }

        void StartConnect()
        {
            //   string host = "10.141.152.191";
            // Connect asynchronously to the specifed host.
            client = new TcpClient(AddressFamily.InterNetworkV6);
            IPAddress[] remoteHost = Dns.GetHostAddresses(IP.ToString());
            connectDone.Reset();

            Console.WriteLine("Establishing Connection to {0}", remoteHost[0]);
            client.BeginConnect(remoteHost[0], Port, new AsyncCallback(Connected), client);

            // Wait here until the callback processes the connection.
            connectDone.WaitOne();
            Console.WriteLine("Connection established");
            Console.ReadLine();
        }

        async void Connected(IAsyncResult ar)
        {
            var c = (TcpClient)ar.AsyncState;
            c.EndConnect(ar);         
            Console.WriteLine("connected to " + c.Client.RemoteEndPoint.ToString());
            connectDone.Set();
            if (client.Connected == true)
            {
               await SendCommand(Action);
            }
        }

         async Task SendCommand(string action)
        {
            try
            {
                
            //    if (client.Connected == true)
                {
                    NetworkStream ns = client.GetStream();
                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);
                    writer.AutoFlush = true;
                    Console.WriteLine("Sending>> " + Action);
                    await writer.WriteLineAsync(Action);
                    while (true)
                    {

                        string request = await reader.ReadLineAsync();

                        if (request != null)
                        {
                            Console.WriteLine(request);
                        }

                        else break;

                    }
                }

            }
            catch
            {
                Console.WriteLine("didnt work");
            }
        }

        public ICommand MakeCommand(string[] args, int index)
        {
            return new Send {
                IP = IPAddress.Parse(args[index + 1]),
               Port = int.Parse(args[index + 2]),
                Action = args[index + 3]
                
            };
        }
    }
}
