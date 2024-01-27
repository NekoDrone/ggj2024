using System;

namespace Events.KeywordEvents
{
    public class Slapstick : IKeyword
    {
        public int SlapstickValue { get; set; }
        public static event Action SlapstickEvent;

        public Slapstick(int slapstickValue)
        {
            this.SlapstickValue = slapstickValue;
        }
        
        public void ExecuteEffect()
        {
            SlapstickEvent?.Invoke();
            BaseEvents.ReduceShield(this.SlapstickValue);
            BaseEvents.DealDirectDamage(this.SlapstickValue);
        }
        
    }
}