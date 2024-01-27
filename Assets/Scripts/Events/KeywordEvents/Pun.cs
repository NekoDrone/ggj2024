using System;

namespace Events.KeywordEvents
{
    public class Pun : IKeyword
    {
        public static event Action PunEvent;
        public void ExecuteEffect()
        {
            PunEvent?.Invoke();
            BaseEvents.DealDirectDamage(1);
        }
    }
}