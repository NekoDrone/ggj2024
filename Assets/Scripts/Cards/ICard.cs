using System.Collections.Generic;
using Keywords;

namespace Cards
{
    public interface ICard
    {
        public void SetKeywords(List<IKeyword> keywords);
    }
}
