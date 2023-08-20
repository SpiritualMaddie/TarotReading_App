using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TarotReading_Labb1.Tarot
{
    public class Card
    {
        public string CardName { get; set; }
        public string Description { get; set; }

        public Card(string cardName, string description)
        {
            CardName = cardName;
            Description = description;
        }
    }
}
