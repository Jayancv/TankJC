namespace Tank1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJoin = new MetroFramework.Controls.MetroButton();
            this.btnShoot = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnLeft = new MetroFramework.Controls.MetroButton();
            this.btnRight = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnJoin.Location = new System.Drawing.Point(23, 63);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(78, 32);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseSelectable = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShoot.Location = new System.Drawing.Point(86, 45);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(60, 30);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseSelectable = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(86, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 30);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(86, 86);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.Location = new System.Drawing.Point(163, 45);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 30);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseSelectable = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Location = new System.Drawing.Point(15, 45);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 30);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseSelectable = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnRight);
            this.metroPanel1.Controls.Add(this.btnLeft);
            this.metroPanel1.Controls.Add(this.btnUp);
            this.metroPanel1.Controls.Add(this.btnShoot);
            this.metroPanel1.Controls.Add(this.btnDown);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 132);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(247, 123);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(308, 43);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(257, 310);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(38, 369);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(477, 93);
            this.txtBox.TabIndex = 9;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 480);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJoin);
            this.Name = "Form1";
            this.Text = "TankJC";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJoin;
        private MetroFramework.Controls.MetroButton btnShoot;
        private MetroFramework.Controls.MetroButton btnUp;
        private MetroFramework.Controls.MetroButton btnDown;
        private MetroFramework.Controls.MetroButton btnLeft;
        private MetroFramework.Controls.MetroButton btnRight;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.RichTextBox txtBox;

    }
}

