using System;

namespace Events.Keywords
{
    public class Slapstick : IKeyword
    {
        public int SlapstickValue { get; set; }

        public Slapstick(int slapstickValue)
        {
            this.SlapstickValue = slapstickValue;
        }
        
        public void ExecuteEffect()
        {
            KeywordEvents.InvokeSlapstickEvent();
            BaseEvents.ReduceShield(this.SlapstickValue);
            BaseEvents.DealDirectDamage(this.SlapstickValue);
        }
        
    }
}