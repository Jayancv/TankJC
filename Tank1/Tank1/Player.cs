using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank1
{
    class Player
    {
        int x0, yo, x, y;
        int dir;
        int health, points, coins;
        bool shot;
        public Player(int x, int y, int dir)
        {
            this.x = x;
            this.y = y;
            this.dir = dir;
            health = 0;
            points = 0;
            coins = 0;

            shot = false;
        }
        public void move(int x, int y, int dir, int h, int p,int c)
        {
            x = x;
            y = y;
            dir = dir;


        }


    }
}
