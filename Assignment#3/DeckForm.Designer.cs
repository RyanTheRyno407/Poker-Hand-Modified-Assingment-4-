namespace Assignment_4
{
    partial class DeckForm
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
            label1 = new Label();
            lstbCards = new ListBox();
            picSelectedCard = new PictureBox();
            btnCardUp = new Button();
            btnCardDown = new Button();
            ((System.ComponentModel.ISupportInitialize)picSelectedCard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 37);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "&Cards";
            // 
            // lstbCards
            // 
            lstbCards.FormattingEnabled = true;
            lstbCards.ItemHeight = 15;
            lstbCards.Location = new Point(46, 55);
            lstbCards.Name = "lstbCards";
            lstbCards.Size = new Size(284, 289);
            lstbCards.TabIndex = 1;
            lstbCards.SelectedIndexChanged += lstbCards_SelectedIndexChanged;
            // 
            // picSelectedCard
            // 
            picSelectedCard.Location = new Point(573, 102);
            picSelectedCard.Name = "picSelectedCard";
            picSelectedCard.Size = new Size(145, 242);
            picSelectedCard.TabIndex = 2;
            picSelectedCard.TabStop = false;
            picSelectedCard.Click += picSelectedCard_Click;
            // 
            // btnCardUp
            // 
            btnCardUp.Location = new Point(376, 174);
            btnCardUp.Name = "btnCardUp";
            btnCardUp.Size = new Size(75, 23);
            btnCardUp.TabIndex = 2;
            btnCardUp.Text = "&Up";
            btnCardUp.UseVisualStyleBackColor = true;
            btnCardUp.Click += btnCardUp_Click;
            // 
            // btnCardDown
            // 
            btnCardDown.Location = new Point(376, 217);
            btnCardDown.Name = "btnCardDown";
            btnCardDown.Size = new Size(75, 23);
            btnCardDown.TabIndex = 3;
            btnCardDown.Text = "&Down";
            btnCardDown.UseVisualStyleBackColor = true;
            btnCardDown.Click += btnCardDown_Click;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCardDown);
            Controls.Add(btnCardUp);
            Controls.Add(picSelectedCard);
            Controls.Add(lstbCards);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            Load += DeckForm_Load;
            ((System.ComponentModel.ISupportInitialize)picSelectedCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbCards;
        private PictureBox picSelectedCard;
        private Button btnCardUp;
        private Button btnCardDown;
    }
}