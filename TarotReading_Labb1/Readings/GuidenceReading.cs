using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotReading_Labb1.Readings
{
    internal class GuidenceReading : IReading
    {
        public void Reading()
        {
            Console.Clear();
            Application app = new Application();
            app.WriteLogo();

            Console.WriteLine(@"
GUIDENCE READING 
3 cards reading
1. what you have learned 
2. what to focus on and cultivate in the present
3. what is to come if you continue on your path like this");

        }
    }
}
