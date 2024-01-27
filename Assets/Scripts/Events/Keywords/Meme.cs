namespace Events.Keywords
{
    public class Meme : IKeyword
    {
        public void ExecuteEffect()
        {
            KeywordEvents.InvokeMemeEvent();
            // TODO: figure out how to replay a card
        }
        
    }
}