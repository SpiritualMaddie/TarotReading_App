using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotReading_Labb1.Factory
{
    internal interface IReadingFactory
    {
        void createReading(string type);
    }
}
