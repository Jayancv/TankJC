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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroTile1.SuspendLayout();
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
            this.btnLeft.Location = new System.Drawing.Point(3, 45);
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
            this.btnRight.Location = new System.Drawing.Point(168, 45);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 30);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseSelectable = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
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
            this.metroTile1.Controls.Add(this.b9);
            this.metroTile1.Controls.Add(this.b8);
            this.metroTile1.Controls.Add(this.b7);
            this.metroTile1.Controls.Add(this.b6);
            this.metroTile1.Controls.Add(this.b5);
            this.metroTile1.Controls.Add(this.b4);
            this.metroTile1.Controls.Add(this.b3);
            this.metroTile1.Controls.Add(this.b2);
            this.metroTile1.Controls.Add(this.b1);
            this.metroTile1.Controls.Add(this.b0);
            this.metroTile1.Location = new System.Drawing.Point(308, 43);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(347, 310);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.UseSelectable = true;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 359);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(643, 135);
            this.txtBox.TabIndex = 9;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(17, 21);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(24, 24);
            this.b0.TabIndex = 0;
            this.b0.Text = "button2";
            this.b0.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(17, 51);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(24, 24);
            this.b1.TabIndex = 1;
            this.b1.Text = "button3";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(17, 79);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(24, 24);
            this.b2.TabIndex = 2;
            this.b2.Text = "button4";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(17, 105);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(24, 24);
            this.b3.TabIndex = 3;
            this.b3.Text = "button5";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(17, 134);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(24, 24);
            this.b4.TabIndex = 4;
            this.b4.Text = "button6";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(17, 164);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(24, 24);
            this.b5.TabIndex = 5;
            this.b5.Text = "button7";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(17, 190);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(24, 24);
            this.b6.TabIndex = 6;
            this.b6.Text = "button8";
            this.b6.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(17, 218);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(24, 24);
            this.b7.TabIndex = 7;
            this.b7.Text = "button9";
            this.b7.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(17, 244);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(24, 24);
            this.b8.TabIndex = 8;
            this.b8.Text = "button10";
            this.b8.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(17, 272);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(24, 24);
            this.b9.TabIndex = 9;
            this.b9.Text = "button11";
            this.b9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnJoin);
            this.Name = "Form1";
            this.Text = "TankJC";
            this.metroPanel1.ResumeLayout(false);
            this.metroTile1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJoin;
        private MetroFramework.Controls.MetroButton btnShoot;
        private MetroFramework.Controls.MetroButton btnUp;
        private MetroFramework.Controls.MetroButton btnDown;
        private MetroFramework.Controls.MetroButton btnLeft;
        private MetroFramework.Controls.MetroButton btnRight;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b0;

    }
}

