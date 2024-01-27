using Events;
using Events.KeywordEvents;

namespace Player.Stats
{
    public class Punchline
    {
        public int Value { get; set; }
        
        public Punchline()
        {
            Setup.IncreasePunchline += this.Increase;
        }
        
        public static void Trigger(int punchlineValue)
        {
            BaseEvents.InvokeDealNormalDamage(punchlineValue);
        }

        private void Increase(int value)
        {
            this.Value += value;
        }
    }
}