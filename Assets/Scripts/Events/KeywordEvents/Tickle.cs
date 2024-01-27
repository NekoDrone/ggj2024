using System;

namespace Events.KeywordEvents
{
    public class Tickle : IKeyword
    {
        public static event Action TickleEvent;
        public void ExecuteEffect()
        {
            TickleEvent?.Invoke();
            BaseEvents.ReduceShield(1);
        }
    }
}