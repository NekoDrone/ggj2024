using System;

namespace Events.KeywordEvents
{
    public class SelfDeprecating : IKeyword
    {
        public static event Action SelfDeprecatingEvent;
        public void ExecuteEffect()
        {
            SelfDeprecatingEvent?.Invoke();
            BaseEvents.IncreaseShield(1);
        }
    }
}