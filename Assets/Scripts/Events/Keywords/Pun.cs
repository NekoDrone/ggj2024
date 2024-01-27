using System;

namespace Events.Keywords
{
    public class Pun : IKeyword
    {
        public void ExecuteEffect()
        {
            KeywordEvents.InvokePunEvent();
            BaseEvents.DealDirectDamage(1);
        }
    }
}