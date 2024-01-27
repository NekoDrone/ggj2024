namespace Keywords
{
    public class Cringe : IKeyword
    {
        public int CringeValue { get; set; }

        public Cringe(int cringeValue)
        {
            this.CringeValue = cringeValue;
        }
        
        public void ExecuteEffect()
        {
            // TODO: increase enemy threshold by CringeValue when triggered
        }
    }
}