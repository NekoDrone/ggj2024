using System;

namespace Events.Keywords
{
    public class Tickle : IKeyword
    {
        public void ExecuteEffect()
        {
            KeywordEvents.InvokeTickleEvent();
            BaseEvents.ReduceShield(1);
        }
    }
}