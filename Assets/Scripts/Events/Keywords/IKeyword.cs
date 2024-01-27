using Identity;

namespace Events.Keywords
{
    public interface IKeyword
    {
        public void ExecuteEffect(CardPlayer cardPlayer);
    }
}