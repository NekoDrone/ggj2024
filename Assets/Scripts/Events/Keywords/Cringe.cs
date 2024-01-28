using Identity;

namespace Events.Keywords
{
    public class Cringe : IKeyword
    {
        public int CringeValue { get; set; }

        public Cringe(int cringeValue)
        {
            this.CringeValue = cringeValue;
        }
        
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeCringeEvent(cardPlayer, this.CringeValue);
        }
    }
}