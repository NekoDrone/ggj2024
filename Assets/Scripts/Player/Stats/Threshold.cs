using Events;

namespace Player.Stats
{
    public class Threshold
    {
        public int Value { get; set; }
        
        public Threshold()
        {
            BaseEvents.ReduceShieldEvent += this.Reduce;
            BaseEvents.IncreaseShieldEvent += this.Increase;
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