using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank1
{
    
    class LifePack
    {
        int life;
        int time;
        int x;
        int y;
        Form1 com;
        public LifePack(int x, int y, int time, int val, Form1 com)
        {
            this.time = time;
            this.life = val;
            this.x = x;
            this.y = y;
            this.com = com;

        }

    }
}
