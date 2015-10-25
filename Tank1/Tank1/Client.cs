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
        private Int32 portConnect = 6000;
        private Int32 portRecieve = 7000;
        private string input;
        private Form1 com;
        private Thread thread;

        public Client() {
            thread = new Thread(new ThreadStart(recieve));
        
        }
        public void send(string msg1,Form1 form){    //used to send data 
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
            public void recieve(){      //used to recieve msgs
                TcpListener listner = new TcpListener(IPAddress.Parse(ip),portRecieve);
                while (true){
                 listner.Start();
                    TcpClient reciever = listner.AcceptTcpClient();
                    Byte[] bytes = new Byte[256];
                    Stream r_Stream = reciever.GetStream();
                    input = null;
                    int i;
                    while ((i = r_Stream.Read(bytes, 0, bytes.Length)) != 0) {

                        input = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    }
                    string[] array = Regex.Split(input, ":");
                    com.Invoke(new Action (()=>{
                    
                    if(array.Length==5){
                        com.displayData("Jayan");
                    }else{

                        com.displayData("\n msg => \n " + input + "\n");
                    }
                    
                    
                    }
                        )) ;
                    r_Stream.Close();
                    listner.Stop();
                    reciever.Close();      
                
            }
        }
 






    }
}
