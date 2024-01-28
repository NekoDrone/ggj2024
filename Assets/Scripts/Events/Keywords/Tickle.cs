using System;
using Identity;

namespace Events.Keywords
{
    public class Tickle : IKeyword
    {
        public int TickleValue { get; set; }

        public Tickle(int tickleValue)
        {
            this.TickleValue = tickleValue;
        }
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeTickleEvent(cardPlayer, this.TickleValue);
        }
    }
}