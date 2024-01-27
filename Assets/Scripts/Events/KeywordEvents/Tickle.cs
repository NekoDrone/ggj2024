namespace Events.KeywordEvents
{
    public class Tickle : IKeyword
    {
        public void ExecuteEffect()
        {
            BaseEvents.InvokeReduceShield(1);
        }
    }
}