using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;


namespace Tank1
{
    class Client
    {
        private TcpClient client;
        private string ip = "127.0.0.1";
        private Int32 portConnect = 1000;
        private Int32 portRecieve = 2000;
        private string input;
        private Form1 com;
        private Thread thread;

        public Client() {
            thread = new Thread(new ThreadStart(recieve));
        
        }
        public void send(string msg1,Form1 form){
            com = form;
            client = new TcpClient();
            client.Connect(IPAddress.Parse(ip),portConnect);
            Stream stream = client.GetStream();

            ASCIIEncoding encode = new ASCIIEncoding();
            byte[] msg = encode.GetBytes(msg1);
            stream.Write(msg, 0, msg.Length);
            stream.Close();
            if (msg1.Equals("#JOIN")) {
                thread.Start();
            }
        }
            public void recieve(){
                TcpListener listner = new TcpListener(IPAddress.Parse(ip),portRecieve);
                while (true){
                 listner.Start();
                    TcpListener
                
                }
            }
        }
 






    }
}
