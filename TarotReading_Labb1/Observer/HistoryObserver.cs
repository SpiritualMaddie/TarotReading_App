using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotReading_Labb1.Tarot;

namespace TarotReading_Labb1.Observer
{
    internal class HistoryObserver : IObserver
    {
        // List of observed cards thats been drawn
        List<Card> observedDrawnCards = new List<Card>();
        public void Update(List<Card> cards)
        {
            foreach (var card in cards)
            {
                observedDrawnCards.Add(card);
            }
        }

        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("Cards thats been drawn:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            if (observedDrawnCards.Count == 0)
            {
                Console.WriteLine("No cards have been drawn yet.");
            }
            else
            {
                foreach (var item in observedDrawnCards)
                {
                    Console.WriteLine(item.CardName);
                }
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();
        }
    }
}
