using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Tank1
{
    class stringEvaluator
    {
        private Form1 com;
        private string data;
        private Player P1, P2, P3, P4, P0;
       
        public void evaluate(String data, Form1 com)
        {
            this.data = data;
            this.com = com;
            data = data.Remove(data.Length - 1);
            string[] lines = Regex.Split(data, ":");
            if (lines[0] == "I")
            {
                initiate_Evaluate(lines, com);
            }
            else if (lines[0] == "C")
            {
                coin(lines, com);
            }
            else if (lines[0] == "S"){
                newPlayer(lines);
            }
            else if (lines[0] == "G")
            {
               tankMoves(lines);
            }
        }


        private void initiate_Evaluate(String[] lines, Form1 com)    {
            for (int x = 2; x < 5; x++)       {
                string[] sublines = Regex.Split(lines[x], ";");
                for (int y = 0; y < sublines.Length; y++)  {
                    string[] cell = Regex.Split(sublines[y], ",");
                    int a = Int32.Parse(cell[0]);
                    int b = Int32.Parse(cell[1]);
                    Button bn= com.selectbtn(a, b);
                    com.updateBtn(bn,x);
                }
            }
        }


        private void coin(String[] lines, Form1 com){
               string[] codinate = Regex.Split(lines[1], ",");
               int x = Int32.Parse(codinate[0]);
               int y = Int32.Parse(codinate[1]);
               int val = Int32.Parse(lines[3]);
               int time = Int32.Parse(lines[2]);
               
            
            Coin coin=new Coin(x,y,time,val,com);
            Button bn = com.selectbtn(x,y);
            com.coinDisplay(bn);

            Thread coin_thread = new Thread(coin.start);
            coin_thread.Start();

            bool finished = coin_thread.Join(time);
            if (!finished)
                coin_thread.Abort();
          
            com.coinDiassapear(bn);       
        }

        private void newPlayer(String[] lines)
        {
            for( int i=1; i < lines.Length ; i++){
                 string[] sublines = Regex.Split(lines[i], ";");
               
            string[] location = Regex.Split(sublines[1], ",");
            int x = Int32.Parse(location[0]);
            int y = Int32.Parse(location[1]);
            int dir = Int32.Parse(sublines[2]);

            if (sublines[0] == "P1") {
                P1 = new Player(x,y,dir);            
            }else if (sublines[0] == "P2") {
                P2 = new Player(x,y,dir);            
            }else if (sublines[0] == "P3") {
                P3 = new Player(x,y,dir);            
            }else if (sublines[0] == "P4") {
                P4 = new Player(x,y,dir);            
            }else if (sublines[0] == "P0") {
                P0 = new Player(x,y,dir);            
            }
            Button bn = com.selectbtn(x, y);
            com.tankDisplay(bn, sublines[0]);
               
            }
            }


        private void tankMove(String[] lines,Form com)
        {
            for (int x = 1; x < lines.Length ; x++)
            {
                string[] sublines = Regex.Split(lines[x], ";");
                String[] dire = Regex.Split(sublines[1], ",");
                int x1= Int32.Parse(dire[0]);
                int y1 = Int32.Parse(dire[1]);
                int d = Int32.Parse(sublines[2]);
                bool s;
                if (sublines[3] == "1")
                    s = true;
                else
                    s = false;
                int h = Int32.Parse(sublines[4]);
                int c = Int32.Parse(sublines[5]);
                int p = Int32.Parse(sublines[6]);
                

            }


        }
        private void tankMoves(String[] lines)
        {
            for (int x = 1; x < lines.Length - 1; x++)
            {
                string[] sublines = Regex.Split(lines[x], ";");
                String[] dire = Regex.Split(sublines[1], ",");
                int x1 = Int32.Parse(dire[0]);
                int y1 = Int32.Parse(dire[1]);
                int d = Int32.Parse(sublines[2]);
                bool s;
                if (sublines[3] == "1")
                    s = true;
                else
                    s = false;
                int h = Int32.Parse(sublines[4]);
                int c = Int32.Parse(sublines[5]);
                int p = Int32.Parse(sublines[6]);
                int x0 = 0;
                int y0 = 0;
                if (sublines[0] == "P1")
                {
                    P1.move(x1, y1, d, s, h, p, c);
                    x0 = P1.getPreviousX();
                    y0 = P1.getPreviousY();
                }
                else if (sublines[0] == "P2")
                {
                    P2.move(x1, y1, d, s, h, p, c);
                    x0 = P2.getPreviousX();
                    y0 = P2.getPreviousY();
                }
                else if (sublines[0] == "P3")
                {
                    P3.move(x1, y1, d, s, h, p, c);
                    x0 = P3.getPreviousX();
                    y0 = P3.getPreviousY();
                }
                else if (sublines[0] == "P4")
                {
                    P4.move(x1, y1, d, s, h, p, c);
                    x0 = P4.getPreviousX();
                    y0 = P4.getPreviousY();
                }
                else if (sublines[0] == "P0")
                {
                    P0.move(x1, y1, d, s, h, p, c);
                    x0 = P0.getPreviousX();
                    y0 = P0.getPreviousY();
                }
                Button bn = com.selectbtn(x1, y1);

                Button pre = com.selectbtn(x0, y0);
                com.tankMove(pre, bn, sublines[0]);

            }


        }
    }
}
