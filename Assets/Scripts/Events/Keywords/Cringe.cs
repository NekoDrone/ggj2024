namespace Events.Keywords
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
            KeywordEvents.InvokeCringeEvent();
            BaseEvents.IncreaseShield(this.CringeValue);
        }
    }
}