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

        private void updateBtbn(Button btn,int n)
        {
            btn.Text = n.ToString();
        }
        public void stringEvaluate(String data)
        {
            Button[ , ] btns =new Button[ , ] {{b1,b2,b3,b4,b5,b6,b7,b8,b9,b0} };
            string[] lines = Regex.Split(data, ":");
            if (lines[0] == "I")
            {
                for (int x = 2; x < lines.Length; x++) {
                    string[] sublines = Regex.Split(lines[x], ";");
                    for (int y = 0; y < sublines.Length; y++) {
                        string[] cell = Regex.Split(sublines[y], ",");
                        if (Int32.Parse(cell[0]) == 0) {
                            updateBtbn(btns[Int32.Parse(cell[0]), Int32.Parse(cell[1])], x);
                        }
                    }
                }
            }

        }
    }
}
