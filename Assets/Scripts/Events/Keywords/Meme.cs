using Identity;

namespace Events.Keywords
{
    public class Meme : IKeyword
    {
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokeMemeEvent(cardPlayer);
            // TODO: figure out how to replay a card
        }
        
    }
}