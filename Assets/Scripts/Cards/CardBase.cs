using System.Collections.Generic;
using Keywords;

namespace Cards
{
    public class CardBase : ICard
    {
        public string CardName { get; set; }
        public int Cost { get; set; }
        public List<PossibleKeywords> Keywords { get; set; }
        public CardBase(string cardName, int cost)
        {
            this.CardName = cardName;
            this.Cost = cost;
            this.Keywords = new List<PossibleKeywords>();
        }


        public void AddKeyword(PossibleKeywords keyword)
        {
            this.Keywords.Add(keyword);
        }
    }
}