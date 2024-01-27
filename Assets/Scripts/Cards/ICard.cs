using System.Collections.Generic;
using Events.Keywords;

namespace Cards
{
    public interface ICard
    {
        public void SetKeywords(List<IKeyword> keywords);
    }
}
