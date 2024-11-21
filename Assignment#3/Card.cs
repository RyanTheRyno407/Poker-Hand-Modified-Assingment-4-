using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Card
    {
        public int Id { get; }


        public Card(int id, Image? cardImage,string name)
        {
            Id = id;
            CardImage = cardImage;
            Name = name; 
        }

        public  Image? CardImage { get; }

        public static readonly Card NoCard = new Card(-1, null, "No Card");

        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }



    }
}
