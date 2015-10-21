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



       
    }
}
