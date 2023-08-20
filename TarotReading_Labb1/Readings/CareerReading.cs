using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotReading_Labb1.Readings
{
    internal class CareerReading : IReading
    {
        public void Reading()
        {
            Console.Clear();
            Application app = new Application();
            app.WriteLogo();

            Console.WriteLine(@"
CAREER READING 
3 card reading.
1. whats holding you back
2. what can you do to move ahead
3. What should you focus on now?");

        }
    }
}
