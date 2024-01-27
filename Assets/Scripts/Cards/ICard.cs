using System.Collections.Generic;
using Events.KeywordEvents;

namespace Cards
{
    public interface ICard
    {
        public void SetKeywords(List<IKeyword> keywords);
    }
}
