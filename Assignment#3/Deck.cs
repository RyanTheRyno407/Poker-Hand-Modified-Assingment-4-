using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Deck
    {
        private List<Card> cards = new();
        private ImageList imgLst;

        public Deck(ImageList imageList)
        {
            imgLst = imageList;
        }

        public void Shuffle()
        {
            Random rng = new Random();
            cards.Clear();
            for (int i =1; i < imgLst.Images.Count; i++)
            {
                cards.Add( new Card(i, imgLst.Images[i], imgLst.Images.Keys[i]));
            }

            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealCards()
        {
            if(cards.Count == 0)
            {
                Card noCard = Card.NoCard;
                return noCard;
            }

            Card cardDealt = cards[0];
            cards.RemoveAt(0);
            return cardDealt;

            
        }

        public bool SaveHand(string fileName, Card[] hand)
        {
            try 
            { 
                using StreamWriter writer = new(fileName);
                foreach (Card i in hand)
                {
                    writer.WriteLine(i.Id);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool LoadHand(string fileName, Card[] hand)
        {
            try 
            { 
                using StreamReader reader = new StreamReader(fileName);
                string? line = string.Empty;
                for (int l = 0; l < 5; l++)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        int Id = int.Parse(line);
                        hand[l] = new Card(Id, imgLst.Images[Id], imgLst.Images.Keys[Id]);
                    }
                }
            }
            catch
            {
                return false;
            }
                return true;

            
        } 


        public int Count 
        {
            get { return cards.Count; }
        }

        public Card GetCard(int Index)
        {
            if (Index >= 0 && Index < cards.Count)
            {

                Card CardIndex = cards[Index];
                return CardIndex;
            }
            else
            {
                return Card.NoCard;
            }
        }

        public void SwapCards(int Index1, int Index2)
        {
            
            if (Index1 >= 0 && Index1 < cards.Count && Index2 >= 0 && Index2 < cards.Count)
            {
               
                Card CardTemp = cards[Index1];


                CardTemp = cards[Index1];
                cards[Index1] = cards[Index2];
                cards[Index2] = CardTemp;
            }
        }

        
        
    }

}
