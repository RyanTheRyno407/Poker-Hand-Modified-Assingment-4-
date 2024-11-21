namespace Assignment_4
{
    partial class Assignment4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment4));
            btnDeal = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            picCard1 = new PictureBox();
            picCard2 = new PictureBox();
            picCard3 = new PictureBox();
            picCard4 = new PictureBox();
            picCard5 = new PictureBox();
            imglstDeck = new ImageList(components);
            saveFileHand = new SaveFileDialog();
            openFileHand = new OpenFileDialog();
            btnShowDeck = new Button();
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(33, 18);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(75, 23);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "&Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(590, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(703, 18);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // chkKeep1
            // 
            chkKeep1.AutoSize = true;
            chkKeep1.Location = new Point(33, 101);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(61, 19);
            chkKeep1.TabIndex = 3;
            chkKeep1.Text = "Keep &1";
            chkKeep1.UseVisualStyleBackColor = true;
            chkKeep1.CheckedChanged += chkKeep1_CheckedChanged;
            // 
            // chkKeep2
            // 
            chkKeep2.AutoSize = true;
            chkKeep2.Location = new Point(170, 101);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(61, 19);
            chkKeep2.TabIndex = 4;
            chkKeep2.Text = "Keep &2";
            chkKeep2.UseVisualStyleBackColor = true;
            chkKeep2.CheckedChanged += chkKeep2_CheckedChanged;
            // 
            // chkKeep3
            // 
            chkKeep3.AutoSize = true;
            chkKeep3.Location = new Point(312, 101);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(61, 19);
            chkKeep3.TabIndex = 5;
            chkKeep3.Text = "Keep &3";
            chkKeep3.UseVisualStyleBackColor = true;
            chkKeep3.CheckedChanged += chkKeep3_CheckedChanged;
            // 
            // chkKeep4
            // 
            chkKeep4.AutoSize = true;
            chkKeep4.Location = new Point(475, 101);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(61, 19);
            chkKeep4.TabIndex = 6;
            chkKeep4.Text = "Keep &4";
            chkKeep4.UseVisualStyleBackColor = true;
            chkKeep4.CheckedChanged += chkKeep4_CheckedChanged;
            // 
            // chkKeep5
            // 
            chkKeep5.AutoSize = true;
            chkKeep5.Location = new Point(641, 101);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(61, 19);
            chkKeep5.TabIndex = 7;
            chkKeep5.Text = "Keep &5";
            chkKeep5.UseVisualStyleBackColor = true;
            chkKeep5.CheckedChanged += chkKeep5_CheckedChanged;
            // 
            // picCard1
            // 
            picCard1.Location = new Point(12, 126);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(120, 212);
            picCard1.TabIndex = 8;
            picCard1.TabStop = false;
            picCard1.Click += picCard1_Click_1;
            // 
            // picCard2
            // 
            picCard2.Location = new Point(142, 126);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(125, 214);
            picCard2.SizeMode = PictureBoxSizeMode.Zoom;
            picCard2.TabIndex = 9;
            picCard2.TabStop = false;
            picCard2.Click += picCard2_Click;
            // 
            // picCard3
            // 
            picCard3.Location = new Point(286, 126);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(121, 212);
            picCard3.SizeMode = PictureBoxSizeMode.Zoom;
            picCard3.TabIndex = 10;
            picCard3.TabStop = false;
            picCard3.Click += picCard3_Click;
            // 
            // picCard4
            // 
            picCard4.Location = new Point(446, 126);
            picCard4.Name = "picCard4";
            picCard4.Size = new Size(127, 212);
            picCard4.SizeMode = PictureBoxSizeMode.Zoom;
            picCard4.TabIndex = 11;
            picCard4.TabStop = false;
            picCard4.Click += picCard4_Click;
            // 
            // picCard5
            // 
            picCard5.Location = new Point(610, 124);
            picCard5.Name = "picCard5";
            picCard5.Size = new Size(122, 214);
            picCard5.SizeMode = PictureBoxSizeMode.Zoom;
            picCard5.TabIndex = 12;
            picCard5.TabStop = false;
            picCard5.Click += picCard5_Click;
            // 
            // imglstDeck
            // 
            imglstDeck.ColorDepth = ColorDepth.Depth32Bit;
            imglstDeck.ImageStream = (ImageListStreamer)resources.GetObject("imglstDeck.ImageStream");
            imglstDeck.TransparentColor = Color.Transparent;
            imglstDeck.Images.SetKeyName(0, "King of Clubs");
            imglstDeck.Images.SetKeyName(1, "Ace of Clubs");
            imglstDeck.Images.SetKeyName(2, "2 of Clubs");
            imglstDeck.Images.SetKeyName(3, "3 of Clubs");
            imglstDeck.Images.SetKeyName(4, "4 of Clubs");
            imglstDeck.Images.SetKeyName(5, "5 of Clubs");
            imglstDeck.Images.SetKeyName(6, "6 of Clubs");
            imglstDeck.Images.SetKeyName(7, "7 of Clubs");
            imglstDeck.Images.SetKeyName(8, "8 of Clubs");
            imglstDeck.Images.SetKeyName(9, "9 of Clubs");
            imglstDeck.Images.SetKeyName(10, "10 of Clubs");
            imglstDeck.Images.SetKeyName(11, "Queen of Clubs");
            imglstDeck.Images.SetKeyName(12, "King of Diamonds");
            imglstDeck.Images.SetKeyName(13, "Ace of Diamonds");
            imglstDeck.Images.SetKeyName(14, "2 of Diamonds");
            imglstDeck.Images.SetKeyName(15, "3 of Diamonds");
            imglstDeck.Images.SetKeyName(16, "4 of Diamonds");
            imglstDeck.Images.SetKeyName(17, "5 of Diamonds");
            imglstDeck.Images.SetKeyName(18, "6 of Diamonds");
            imglstDeck.Images.SetKeyName(19, "7 of Diamonds");
            imglstDeck.Images.SetKeyName(20, "8 of Diamonds");
            imglstDeck.Images.SetKeyName(21, "9 of Diamonds");
            imglstDeck.Images.SetKeyName(22, "10 of Diamonds");
            imglstDeck.Images.SetKeyName(23, "Jack of Diamonds");
            imglstDeck.Images.SetKeyName(24, "Queen of Diamonds");
            imglstDeck.Images.SetKeyName(25, "King of Hearts");
            imglstDeck.Images.SetKeyName(26, "Ace of Hearts");
            imglstDeck.Images.SetKeyName(27, "2 of Hearts");
            imglstDeck.Images.SetKeyName(28, "3 of Hearts");
            imglstDeck.Images.SetKeyName(29, "4 of Hearts");
            imglstDeck.Images.SetKeyName(30, "5 of Hearts");
            imglstDeck.Images.SetKeyName(31, "6 of Hearts");
            imglstDeck.Images.SetKeyName(32, "7 of Hearts");
            imglstDeck.Images.SetKeyName(33, "8 of Hearts");
            imglstDeck.Images.SetKeyName(34, "9 of Hearts");
            imglstDeck.Images.SetKeyName(35, "10 of Hearts");
            imglstDeck.Images.SetKeyName(36, "Jack of Hearts");
            imglstDeck.Images.SetKeyName(37, "Queen of Hearts");
            imglstDeck.Images.SetKeyName(38, "King of Spades");
            imglstDeck.Images.SetKeyName(39, "Ace of Spades");
            imglstDeck.Images.SetKeyName(40, "2 of Spades");
            imglstDeck.Images.SetKeyName(41, "3 of Spades");
            imglstDeck.Images.SetKeyName(42, "4 of Spades");
            imglstDeck.Images.SetKeyName(43, "5 of Spades");
            imglstDeck.Images.SetKeyName(44, "6 of Spades");
            imglstDeck.Images.SetKeyName(45, "7 of Spades");
            imglstDeck.Images.SetKeyName(46, "8 of Spades");
            imglstDeck.Images.SetKeyName(47, "9 of Spades");
            imglstDeck.Images.SetKeyName(48, "10 of Spades");
            imglstDeck.Images.SetKeyName(49, "Jack of Spades");
            imglstDeck.Images.SetKeyName(50, "Queen of Spades");
            // 
            // btnShowDeck
            // 
            btnShowDeck.Location = new Point(498, 20);
            btnShowDeck.Name = "btnShowDeck";
            btnShowDeck.Size = new Size(75, 23);
            btnShowDeck.TabIndex = 13;
            btnShowDeck.Text = "S&how Deck";
            btnShowDeck.UseVisualStyleBackColor = true;
            btnShowDeck.Click += btnShowDeck_Click;
            // 
            // Assignment4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowDeck);
            Controls.Add(picCard5);
            Controls.Add(picCard4);
            Controls.Add(picCard3);
            Controls.Add(picCard2);
            Controls.Add(picCard1);
            Controls.Add(chkKeep5);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnDeal);
            Name = "Assignment4";
            Text = "Poker Hand simulator";
            Load += Assignment3_Load;
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeal;
        private Button btnSave;
        private Button btnLoad;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private PictureBox picCard1;
        private PictureBox picCard2;
        private PictureBox picCard3;
        private PictureBox picCard4;
        private PictureBox picCard5;
        private ImageList imglstDeck;
        private SaveFileDialog saveFileHand;
        private OpenFileDialog openFileHand;
        private Button btnShowDeck;
    }
}
