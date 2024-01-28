using Events;

namespace Player.Stats
{
    public class Punchline
    {
        public int Value { get; set; }
        
        public static void Trigger(int punchlineValue)
        {
            BaseEvents.DealNormalDamage(punchlineValue);
        }

        public void Increase(int value)
        {
            this.Value += value;
        }
    }
}