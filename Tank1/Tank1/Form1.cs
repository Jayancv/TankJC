using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Text.RegularExpressions;


namespace Tank1
{
    public partial class Form1 : MetroForm
    {
        Client client;
        private List<Button> bricks;             //Store brick coordinates 
        private List<Button> stones;             //store Stone coordinates
        private List<Button> water1;             //store water corrdinates
      
        public Form1()
        {
            InitializeComponent();
            client = new Client();                //creating objects
            bricks = new List<Button>();
            stones = new List<Button>();
            water1 = new List<Button>();
           Form1.CheckForIllegalCrossThreadCalls = false; //for thread control

        }
        


        //Control Button events
        private void btnJoin_Click(object sender, EventArgs e) 
        {
            client.send("JOIN#", this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            client.send("UP#", this);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            client.send("LEFT#", this);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            client.send("DOWN#", this);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            client.send("RIGHT#", this);
        }
        private void btnShoot_Click(object sender, EventArgs e)
        {
            client.send("SHOOT#", this);
        }


        //Text box message display
        public void displayData(String input)
        {
            txtBox.Text += "\n" + input;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            txtBox.SelectionStart = txtBox.Text.Length; //Set the current caret position at the end
            txtBox.ScrollToCaret();
        }

        // Change button image  - this for map initiate
        public void updateBtn(Button btn,int n)
        { 
        if(n==2){
            bricks.Add(btn);
            btn.BackgroundImage = Properties.Resources.brick;
            
        }
        else if (n == 3)
        {
            stones.Add(btn);
            btn.BackgroundImage = Properties.Resources.stone;
        }
        else if (n == 4)
        {
            water1.Add(btn);
            btn.BackgroundImage = Properties.Resources.water;
               
        }
            
        // return button of the given x,y coordinates
        }
        public Button selectbtn(int a, int b)
        {
            //store buttons in a 2D array
            Button[,] btns = new Button[,] {{b0,b1,b2,b3,b4,b5,b6,b7,b8,b9},{b10,b11,b12,b13,b14,b15,b16,b17,b18,b19},{b20,b21,b22,b23,b24,b25,b26,b27,b28,b29},
            {b30,b31,b32,b33,b34,b35,b36,b37,b38,b39},{b40,b41,b42,b43,b44,b45,b46,b47,b48,b49},{b50,b51,b52,b53,b54,b55,b56,b57,b58,b59},{b60,b61,b62,b63,b64,b65,b66,b67,b68,b69},
            {b70,b71,b72,b73,b74,b75,b76,b77,b78,b79},{b80,b81,b82,b83,b84,b85,b86,b87,b88,b89},{b90,b91,b92,b93,b94,b95,b96,b97,b98,b99}};
           
               
               return (btns[a, b]);


        }
        //Update coins 
        public void coinUpdate(Button btn, int time)
        {
            coinDisplay(btn);
            Thread.Sleep(time);
            coinDiasappear(btn);
        }

        public void coinDisplay(Button btn) {
            btn.BackgroundImage = Properties.Resources.coin;
                
        }
        public void coinDiasappear(Button btn) {
            btn.BackgroundImage = Properties.Resources.blank;
        
        }
        //Update Life packets
        public void lifeUpdate(Button btn, int time)
        {
            lifeDisplay(btn);
            Thread.Sleep(time);      //Sleep thread that given time a
           // coinDiassapear(btn);
            lifeDiasappear(btn);

        }
        private void lifeDisplay(Button btn){
            btn.BackgroundImage = Properties.Resources.health;

         }
        public void lifeDiasappear(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.blank;

        }

        // display tans in the map
        public void tankDisplay(Button btn, String playerNo, int d)
        {
            Image im = rotate(Properties.Resources.tank2, d); //Rotate tanck to given direction d
            if (playerNo == "P1")                             // check and identify player/tank
            {
                im= rotate(Properties.Resources.Tank0, d);
            }
            else if (playerNo == "P2")
            {
                 im= rotate(Properties.Resources.tank24,d);
            }
            else if (playerNo == "P3")
            {
                 im= rotate(Properties.Resources.tan25,d);
            }
            else if (playerNo == "P4")
            {
                 im= rotate(Properties.Resources.Tank26,d);
            }
            else if (playerNo == "P0")
            {
                 im= rotate(Properties.Resources.Tank4 ,d);
            }
            btn.BackgroundImage = im;                        //display image
        }

        //Rotate image
        private Image rotate(Image im,int d){
           if(d==1)
               im.RotateFlip(RotateFlipType.Rotate90FlipNone);
           if (d == 2)
               im.RotateFlip(RotateFlipType.Rotate180FlipNone);
           if (d == 3)
               im.RotateFlip(RotateFlipType.Rotate270FlipNone);

            return im;
        }


        public void tankDisappear(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.blank;
        }

        public void tankMove(Button pre, Button btn, String playerNo,int d)
        {
            if (!(bricks.Exists(elemet => elemet == btn) || stones.Exists(elemet1 => elemet1 == btn))) //check that next place is brick or stone
            {
                if (water1.Exists(elemet2 => elemet2 == btn))        //if next position is  water then disappear the tank (Player died )              
                {
                    tankDisappear(pre);
                }
                else                                                 //if next position is available then tank move that place
                {
                    tankDisappear(pre);                             //disappear previous  place
                    tankDisplay(btn, playerNo, d);                  //Display tank in the new place
                }
            }
        }

        // Calculate and display Brick damage
        public void brickDamage(Button btn,int dam)
        {
            int d = 100-(dam * 25);
            btn.Text = d.ToString()+"%";
            if (dam == 4)                   //if gamage is in level 4(100%) Disappear the brick
                brickDisappear(btn);

        }
        public void brickDisappear(Button btn) {
            bricks.Remove(btn);
            btn.BackgroundImage = Properties.Resources.blank;
            btn.Text = "";
        }
        private void waterDisapear(Button btn)
        {
            water1.Remove(btn);
            btn.BackgroundImage = Properties.Resources.blank;

        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                client.send("UP#", this);
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                client.send("DOWN#", this);
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                client.send("LEFT#", this);
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                client.send("RIGHT#", this);
                return true;
            }
            if (keyData == Keys.Space)
            {
                client.send("SHOOT#", this);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
