

using TarotReading_Labb1.Factory;
using TarotReading_Labb1.Observer;
using TarotReading_Labb1.Tarot;

namespace TarotReading_Labb1
{
    internal class Application
    {      
        HistoryObserver hiObs = new HistoryObserver();
        
        public void Start()
        {
            Console.Title = "Tarot Reading";

            // Menu
            string prompt = "Please choose a reading:\n(Choose with arrows and \nselect with Enter)\n";
            string[] options = { "Love", "Career", "Guidence", "Exit", "Observer List" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            ReadingFactory reading = new ReadingFactory();

            switch (menuSelect)
            {
                case 0:
                    reading.createReading("Love").Reading();
                    DrawCards();
                    break;
                case 1:
                    reading.createReading("Career").Reading();
                    DrawCards();
                    break;
                case 2:
                    reading.createReading("guidence").Reading();
                    DrawCards();
                    break;
                case 3:
                    ExitApp();
                    break;
                case 4:
                    hiObs.PrintInfo();
                    Start();
                    break;
            }

        }
        public void WriteLogo()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to Spiritual Maddie's tarot reading app");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            string logo = @"
     (
     )\
     {_}
    .-;-.
   |'-=-'|
   |     |
   |     |
   |     |
   |     |
   '.___.'
                        ";
            Console.WriteLine(logo, Color.Coral);
        }

        public void DrawCards()
        {
            var deck = Deck.GetDeck();
            deck.ShuffleDeck();

            // Register the observer
            deck.RegisterObserver(hiObs);

            // Drawing cards will also notify the observer and log the drawn cards
            var myCards = deck.DrawCard();

            foreach (var item in myCards)
            {
                Console.WriteLine(item.CardName);
                Console.WriteLine(item.Description);

            }

            Console.WriteLine("\nPress Enter to get back to the menu");
            Console.ReadKey();
            Start();
        }
        private void ExitApp()
        {
            Console.Clear();
            Console.WriteLine("You have chosen to exit the app. The program will end.");
            Thread.Sleep(3500);
            Environment.Exit(0);
        }

    }
}
