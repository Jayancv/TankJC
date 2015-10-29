using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank1
{
    class Player
    {
        int x0, y0, x, y;
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
        public void move(int x1, int y1, int dir1, bool sh, int h1, int p1, int c1)
        {
            x0 = x;
            y0 = y;
            x = x1;
            y = y1;
            dir = dir1;
            health = h1;
            points = p1;
            coins = c1;
            shot = sh;



        }
        public int getPreviousX()
        {
            return x0;
        }
        public int getPreviousY()
        {
            return y0;
        }


    }
}
