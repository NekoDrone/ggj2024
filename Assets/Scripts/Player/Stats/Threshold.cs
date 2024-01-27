using Events;

namespace Player.Stats
{
    public class Threshold
    {
        public int Value { get; set; }
        
        public Threshold()
        {
            BaseEvents.ReduceShield += this.Reduce;
            BaseEvents.IncreaseShield += this.Increase;
        }

        private void Reduce(int value)
        {
            this.Value -= value;
        }
        
        private void Increase(int value)
        {
            this.Value += value;
        }
    }
}