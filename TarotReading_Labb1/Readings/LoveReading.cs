using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotReading_Labb1.Readings
{
    internal class LoveReading : IReading
    {
        public void Reading()
        {
            Console.Clear();
            Application app = new Application();

            app.WriteLogo();

            Console.WriteLine(@"
LOVE READING
3 card reading
1. what in your past is highlighted 
2. what to be aware of in the present
3. what is to come if you continue on your path like this");

        }
    }
}
