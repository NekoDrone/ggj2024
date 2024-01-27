using System;

namespace Events.KeywordEvents
{
    public class Meme : IKeyword
    {
        public static event Action MemeEvent;
        public void ExecuteEffect()
        {
            MemeEvent?.Invoke();
            // TODO: figure out how to replay a card
        }
        
    }
}