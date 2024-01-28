using System;
using Identity;

namespace Events.Keywords
{
    public class Pun : IKeyword
    {
        public void ExecuteEffect(CardPlayer cardPlayer)
        {
            KeywordEvents.InvokePunEvent(cardPlayer);
        }
    }
}