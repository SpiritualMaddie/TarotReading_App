using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TarotReading_Labb1.Observer;

namespace TarotReading_Labb1.Tarot
{
    public sealed class Deck
    {
        private List<Card>? cards;

        // private constructor for creating the singleton pattern
        private Deck()
        {
            cards = new List<Card>
            {
                new Card("The Fool","This is a new beginning"),
                new Card("The Magician","Now you have all the power to manifest"),
                new Card("The High Priestess", "Intuition is your answer now"),
                new Card("The Empress", "A very fertile time"),
                new Card("The Emperor","Structure is important now"),
                new Card("The Hierophant", "Tradition is highlighed now"),
                new Card("The Lovers", "Love, both for self and others is in the spotlight now"),
                new Card("The Chariot", "Control, healthy control is being asked of you"),
                new Card("Strength", "Courage is the key"),
                new Card("The Hermit", "Introspection is aksed of you now"),
                new Card("Wheel of Fortune","Destiny is at play here"),
                new Card("Justice","Fairness is coming your way"),
                new Card("The Hanged Man","Letting go is your best option now"),
                new Card("Death","Transformation is near"),
                new Card("Temperance","Balance is needed"),
                new Card("The Devil", "Addiction, whats holding you back?"),
                new Card("The Tower", "Sudden change is opon you"),
                new Card("The Star", "Faith is needed"),
                new Card("The Moon", "Illusion, things will be shown to you soon"),
                new Card("The Sun","Celebration, time to dance and enjoy!"),
                new Card("Judgement","What are you judging  youself for?"),
                new Card("The World",  "Completion, you got it!")
            };

        }
        private static Deck? _instance;

        // GetDeck method to get a single instance of the Deck class 
        public static Deck GetDeck()
        {
            if (_instance == null)
            {
                _instance = new Deck();
            }
            return _instance;
        }

        //List of observers
        private List<IObserver> observers = new List<IObserver>();

        //Register Observer
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        //Remove an observer, not used
        //public void RemoveObserver(IObserver observer)
        //{
        //    observers.Remove(observer);
        //}

        //Notify all observers about the drawn vard
        private void NotifyObeservers(List<Card> cards)
        {
            foreach (var observer in observers)
            {
                observer.Update(cards);
            }
        }

        public void ShuffleDeck()
        {
            cards?.Shuffle();

            Console.WriteLine(@"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Your cards are being shuffled");
            Console.WriteLine(@"
  _ _ _ _ ___ ___ _ _ _ ___ _ _ _________
 | | | | |   |    | | | |   | | |         |
 | | | | |   |    | | | |   | | |         |
 | | | | | + | +  | | | | + | | |    +    |
 | | | | | + | +  | | | | + | | |    +    |
 | | | | | + | +  | | | | + | | |    +    |
 | | | | |   |    | | | |   | | |         |
 |_|_|_|_|___|____|_|_|_|___|_|_|_________|
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
", Color.Gold);
            Thread.Sleep(4000);
        }

        public List<Card> DrawCard(int count = 3)
        {
            if (cards == null || cards.Count < count)
            {
                Console.WriteLine("Not enough cards left in the deck. \nThe program will end");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            var drawnCards = cards.Take(count).ToList();
            cards.RemoveRange(0, count);

            //Observer being notified of drawn cards
            NotifyObeservers(drawnCards);
            return drawnCards;
        }
    }
}
