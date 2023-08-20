using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotReading_Labb1.Tarot;

namespace TarotReading_Labb1.Observer
{
    public interface IObserver
    {
        void Update(List<Card> cards);
    }
}
