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

        public static event Action<int> IncreasePunchline;
        
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeSetupEvent(cardPlayer);
            IncreasePunchline?.Invoke(this.SetupValue);
        }
    }
}