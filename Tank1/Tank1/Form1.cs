using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Text.RegularExpressions;


namespace Tank1
{
    public partial class Form1 : MetroForm
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
            client = new Client();
        }

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



        public void displayData(String input)
        {
            txtBox.Text += "\n" + input;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            txtBox.SelectionStart = txtBox.Text.Length; //Set the current caret position at the end
            txtBox.ScrollToCaret();
        }

        public void updateBtn(Button btn,int n)
        { 
        if(n==2){
        btn.Text = n.ToString();
        btn.BackgroundImage = Properties.Resources.brick;
        }
        else if (n == 3)
        {
            btn.Text = n.ToString();
            btn.BackgroundImage = Properties.Resources.stone;
        }
        else if (n == 4)
        {
            btn.Text = n.ToString();
            btn.BackgroundImage = Properties.Resources.water;
                //Image.FromFile(@"C:\Users\Jayan\Desktop\Tank\TankJC\Tank1\Tank1\image\water.jpg");

        }
            
        }
        public Button selectbtn(int a, int b)
        {
            Button[,] btns = new Button[,] {{b0,b1,b2,b3,b4,b5,b6,b7,b8,b9},{b10,b11,b12,b13,b14,b15,b16,b17,b18,b19},{b20,b21,b22,b23,b24,b25,b26,b27,b28,b29},
            {b30,b31,b32,b33,b34,b35,b36,b37,b38,b39},{b40,b41,b42,b43,b44,b45,b46,b47,b48,b49},{b50,b51,b52,b53,b54,b55,b56,b57,b58,b59},{b60,b61,b62,b63,b64,b65,b66,b67,b68,b69},
            {b70,b71,b72,b73,b74,b75,b76,b77,b78,b79},{b80,b81,b82,b83,b84,b85,b86,b87,b88,b89},{b90,b91,b92,b93,b94,b95,b96,b97,b98,b99}};
           
               
               return (btns[a, b]);


        }
        public void coinDisplay(Button btn) {
            btn.BackgroundImage = Properties.Resources.coin;
                //Image.FromFile(@"C:\Users\Jayan\Desktop\Tank\TankJC\Tank1\Tank1\image\coin.png");
        }
        public void coinDiassapear(Button btn) {
            btn.BackgroundImage = Properties.Resources.blank;
        
        }


    }
}
