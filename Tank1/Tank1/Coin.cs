using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tank1
{
    class Coin
    {
        int value;
        int time;
        int x;
        int y;
        Form1 com;
        public Coin(int x, int y,int time, int val,Form1 com)
        {
            this.time = time;
            this.value = val;
            this.x = x;
            this.y = y;
            this.com = com;


        }
        public void start()
        {        
              //  Thread.Sleep(time);
               
        }
    }
}
