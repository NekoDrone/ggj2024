using System;

namespace Events.KeywordEvents
{
    public class Setup : IKeyword
    {
        public int SetupValue { get; set; }

        public Setup(int setupValue)
        {
            this.SetupValue = setupValue;
        }

        public static event Action<int> IncreasePunchline;
        public static event Action SetupEvent;
        
        public void ExecuteEffect()
        {
            SetupEvent?.Invoke();
            IncreasePunchline?.Invoke(this.SetupValue);
        }
    }
}