using System;
using Identity;

namespace Events.Keywords
{
    public class Tickle : IKeyword
    {
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeTickleEvent(cardPlayer);
            BaseEvents.ReduceShield(1);
        }
    }
}