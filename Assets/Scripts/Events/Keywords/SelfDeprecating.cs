using System;
using Identity;

namespace Events.Keywords
{
    public class SelfDeprecating : IKeyword
    {
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeSelfDeprecatingEvent(cardPlayer);
        }
    }
}