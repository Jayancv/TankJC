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
        private Player P1, P2, P3, P4, P5;
       

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
            else if (lines[0] == "S")
                newPlayer(lines);   
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

            if (sublines[1] == "P1") {
                P1 = new Player(x,y,dir);            
            }else if (sublines[1] == "P2") {
                P2 = new Player(x,y,dir);            
            }else if (sublines[1] == "P3") {
                P3 = new Player(x,y,dir);            
            }else if (sublines[1] == "P4") {
                P4 = new Player(x,y,dir);            
            }else if (sublines[1] == "P5") {
                P5 = new Player(x,y,dir);            
            }
            Button bn = com.selectbtn(x, y);
            com.tankDisplay(bn);
               
            }

            }
        


    }
}
