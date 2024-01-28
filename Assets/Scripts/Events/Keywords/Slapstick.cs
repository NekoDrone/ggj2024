using System;
using Identity;

namespace Events.Keywords
{
    public class Slapstick : IKeyword
    {
        public int SlapstickValue { get; set; }

        public Slapstick(int slapstickValue)
        {
            this.SlapstickValue = slapstickValue;
        }
        
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeSlapstickEvent(cardPlayer, this.SlapstickValue);
        }
        
    }
}