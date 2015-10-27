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
        public Coin(int x, int y,int time, int val)
        {
            this.time = time;
            this.value = val;
            this.x = x;
            this.y = y;


        }
        public void start()
        {
                Thread.Sleep(time);
            

        }
    }
}
