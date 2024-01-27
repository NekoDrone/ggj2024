using System;

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
        
        public void ExecuteEffect()
        {
            KeywordEvents.InvokeSetupEvent();
            IncreasePunchline?.Invoke(this.SetupValue);
        }
    }
}