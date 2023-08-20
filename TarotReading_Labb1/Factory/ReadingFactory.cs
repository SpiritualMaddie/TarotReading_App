using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotReading_Labb1.Readings;

namespace TarotReading_Labb1.Factory
{
    internal class ReadingFactory
    {
        // Here different tarot readings are being created by the readings factory
        // Depending on the reading the user chooses in the menu the right reading will get created
        public IReading createReading(string type)
        {
            IReading obj = null;

            switch (type.ToLower())
            {
                case "love":
                    obj = new LoveReading();
                    break;
                case "career":
                    obj = new CareerReading();
                    break;
                case "guidence":
                    obj = new GuidenceReading();
                    break;
                default:
                    Console.WriteLine("Ops, something went wrong. \nPlease press Enter to continue.");
                    Console.ReadKey();
                    break;
            }
            return obj;
        }
    }
}
