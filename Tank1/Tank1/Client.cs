using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace Tank1
{
    class Client
    {
        private TcpClient client;
        private string ip = "127.0.0.1";

        private Int32 portIn = 6000;   //port use to connect
        private Int32 portOut = 7000;  //port to recieve

        private string data;
        private Form1 com;
        private Thread thread;
        public Client()
        {
            thread = new Thread(new ThreadStart(recieve));
        }

        //to send message to the server
        public void send(string message, Form1 com)
        {
            this.com = com;
            client = new TcpClient();
            client.Connect(IPAddress.Parse(ip), portIn);
            Stream stream = client.GetStream();

            ASCIIEncoding asciiencode = new ASCIIEncoding();
            byte[] msg = asciiencode.GetBytes(message);

            stream.Write(msg, 0, msg.Length);
            stream.Close();
            client.Close();
            if (message.Equals("JOIN#"))    //starts the game with the command JOIN#
                thread.Start();
        }
        //to get messages from server
        public void recieve()
        {
            TcpListener listner = new TcpListener(IPAddress.Parse(ip), portOut);
            while (true)
            {
                listner.Start();
                TcpClient clientRecieve = listner.AcceptTcpClient();
                Stream streamRecieve = clientRecieve.GetStream();
                Byte[] bytes = new Byte[256];

                int i;
                data = null;

                while ((i = streamRecieve.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }
                string[] lines = Regex.Split(data, ":");
                com.Invoke(new Action(() =>
                {
                    if (lines.Length == 5)
                        com.displayData("jayan");
                    else
                        com.displayData("\n msg => \n" + data + "\n");
                }));
                streamRecieve.Close();
                listner.Stop();
                clientRecieve.Close();
            }
        }


    }
}
