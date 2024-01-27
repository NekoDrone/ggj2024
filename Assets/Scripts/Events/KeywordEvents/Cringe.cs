using System;

namespace Events.KeywordEvents
{
    public class Cringe : IKeyword
    {
        public int CringeValue { get; set; }
        public static event Action CringeEvent;

        public Cringe(int cringeValue)
        {
            this.CringeValue = cringeValue;
        }
        
        public void ExecuteEffect()
        {
            CringeEvent?.Invoke();
            BaseEvents.IncreaseShield(this.CringeValue);
        }
    }
}