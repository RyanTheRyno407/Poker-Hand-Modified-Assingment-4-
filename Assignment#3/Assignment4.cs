using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_4
{

    public partial class Assignment4 : Form
    {
        Card[] hand = new Card[5];
        private Deck deck;
        private const string FILE_PATH = @"C:\Users\ryanh\source\repos\Assignment#3\Assignment#3\Hands\";
        DeckForm deckForm;

        public Assignment4()
        {
            InitializeComponent();
            deck = new Deck(imglstDeck);
            deckForm = new DeckForm(deck);
        }





        private Card DealCard()
        {
            return deck.DealCards();

            //either replace with Deck.dealCard or replace every instance of this with Deck.DealCard


        }

        public bool IsAnyKeepChecked()
        {


            if (chkKeep1.Checked)
            {
                return true;
            }
            if (chkKeep2.Checked)
            {
                return true;
            }
            if (chkKeep3.Checked)
            {
                return true;
            }
            if (chkKeep4.Checked)
            {
                return true;
            }
            if (chkKeep5.Checked)
            {
                return true;
            }

            return false;

        }

        public void DealHand()
        {

            // if any keeps do not shuffle

            if (!IsAnyKeepChecked())
                deck.Shuffle();
                deckForm.UpdateDeck();

            //if any checkboxes are checked return true. if not any check box checked, rebuild deck
            if (chkKeep1.Checked == false)
            {
                hand[0] = DealCard();
            }
            if (chkKeep2.Checked == false)
            {
                hand[1] = DealCard();
            }
            if (chkKeep3.Checked == false)
            {
                hand[2] = DealCard();
            }
            if (chkKeep4.Checked == false)
            {
                hand[3] = DealCard();
            }
            if (chkKeep5.Checked == false)
            {
                hand[4] = DealCard();
            }
            PictureBoxes();
            
        }

        public void PictureBoxes()
        {
            picCard1.Image = hand[0].CardImage;
            picCard2.Image = hand[1].CardImage;
            picCard3.Image = hand[2].CardImage;
            picCard4.Image = hand[3].CardImage;
            picCard5.Image = hand[4].CardImage;
        }


        private void btnDeal_Click(object sender, EventArgs e)
        {


            DealHand();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName;
            saveFileHand.InitialDirectory = FILE_PATH;
            if (saveFileHand.ShowDialog() == DialogResult.OK)
            {

                fileName = saveFileHand.FileName;
                SaveFile(fileName);


            }
        }

        private void SaveFile(string fileName)
        {
            deck.SaveHand(fileName, hand);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string fileName;
            openFileHand.InitialDirectory = FILE_PATH;
            if (openFileHand.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileHand.FileName;
                LoadFile(fileName);
            }
            else
            {
                MessageBox.Show("Load cancelled.");
            }

        }
        private void LoadFile(string fileName)
        {
            if (deck.LoadHand(fileName, hand))
            {
                PictureBoxes();
            }
            else
            {
                MessageBox.Show(" Couldn't load file");
            }
        }


        private void chkKeep1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKeep2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKeep3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKeep4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKeep5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            chkKeep3.Checked = !chkKeep3.Checked;
        }

        private void picCard1_Click(object sender, EventArgs e)
        {
            //also checks the checkbox
            chkKeep1.Checked = !chkKeep1.Checked;
        }

        private void Assignment3_Load(object sender, EventArgs e)
        {
            DealHand();
            saveFileHand.InitialDirectory = FILE_PATH;
            openFileHand.InitialDirectory = FILE_PATH;
        }

        private void picCard1_Click_1(object sender, EventArgs e)
        {
            chkKeep1.Checked = !chkKeep1.Checked;
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            chkKeep2.Checked = !chkKeep2.Checked;
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            chkKeep4.Checked = !chkKeep4.Checked;
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            chkKeep5.Checked = !chkKeep5.Checked;
        }

        private void btnShowDeck_Click(object sender, EventArgs e)
        {
            DeckForm deckForm = new DeckForm(deck);

            if (deckForm == null || !deckForm.Visible)
            {
                deckForm = new DeckForm(deck);
                deckForm.Show();
            }
            //deckForm.ShowDialog();
        
        }
    }
}
