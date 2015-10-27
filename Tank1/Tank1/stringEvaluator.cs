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
       

        public void evaluate(String data, Form1 com)
        {
            this.data = data;
            this.com = com;
            data = data.Remove(data.Length - 1);
            string[] lines = Regex.Split(data, ":");
            if (lines[0] == "I")
            {
               initiate_Evaluate( lines,com);
            }
            else if (lines[0] == "C")
            {
                coin(lines, com);
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
    }
}
