using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class DeckForm : Form
    {
        private Deck _deck;
        public DeckForm(Deck deck)
        {
            InitializeComponent();
            _deck = deck;

        }
        public void UpdateDeck()
        {
            lstbCards.Items.Clear();

            for (int i = 0; i < _deck.Count; i++)
            {
                lstbCards.Items.Add(_deck.GetCard(i));
            }
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            UpdateDeck();
        }

        private void lstbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make sure you understand the ?'s do here
            Card? card = (Card?)lstbCards.SelectedItem;

            // the ? here does something related but slightly different
            // make sure you understand what it is doing

            picSelectedCard.Image = card?.CardImage;
        }

        private void picSelectedCard_Click(object sender, EventArgs e)
        {

        }

        private void btnCardUp_Click(object sender, EventArgs e)
        {
            // +1 to index for going up
            if(lstbCards.SelectedItem != null)
            {
                int upIndex = lstbCards.SelectedIndex -1;
                _deck.SwapCards(lstbCards.SelectedIndex, upIndex);
                UpdateDeck();
                lstbCards.SetSelected(upIndex, true);

                
            }
        }

        private void btnCardDown_Click(object sender, EventArgs e)
        {
            // -1 to index for going down
            if(lstbCards.SelectedItem != null)
            {
                int downIndex = lstbCards.SelectedIndex +1;
                _deck.SwapCards(lstbCards.SelectedIndex, downIndex);
                UpdateDeck();
                lstbCards.SetSelected(downIndex, true);
            }
        }
    }
}
