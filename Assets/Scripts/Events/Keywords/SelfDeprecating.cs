using System;

namespace Events.Keywords
{
    public class SelfDeprecating : IKeyword
    {
        
        public void ExecuteEffect()
        {
            KeywordEvents.InvokeSelfDeprecatingEvent();
            BaseEvents.IncreaseShield(1);
        }
    }
}