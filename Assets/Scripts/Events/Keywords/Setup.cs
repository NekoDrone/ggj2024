using System;
using Identity;

namespace Events.Keywords
{
    public class Setup : IKeyword
    {
        public int SetupValue { get; set; }

        public Setup(int setupValue)
        {
            this.SetupValue = setupValue;
        }
        
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeSetupEvent(cardPlayer, this.SetupValue);
        }
    }
}