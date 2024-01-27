namespace Keywords
{
    public class SelfDeprecating : IKeyword
    {
        public void ExecuteEffect()
        {
            // TODO: trigger SelfDeprecating event to increase own threshold value by 1
        }
    }
}