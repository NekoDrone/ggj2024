using System.Collections.Generic;
using Events.Keywords;
using Identity;

namespace Cards
{
    public class CardBase : ICard
    {
        public string CardName { get; set; }
        public int Cost { get; set; }
        public List<IKeyword> Keywords { get; set; }
        
        public CardBase(string cardName, int cost)
        {
            this.CardName = cardName;
            this.Cost = cost;
            this.Keywords = new List<IKeyword>();
        }

        public void SetKeywords(List<IKeyword> keywords)
        {
            this.Keywords = keywords;
        }

        public void PlayCard(CardPlayer cardPlayer)
        {
            foreach (var keyword in this.Keywords)
            {
                keyword.ExecuteEffect(cardPlayer);
            }
        }
    }
}