namespace Keywords
{
    public class Setup : IKeyword
    {
        public int SetupValue { get; set; }

        public Setup(int setupValue)
        {
            this.SetupValue = setupValue;
        }
        
        public void ExecuteEffect()
        {
            throw new System.NotImplementedException();
        }
    }
}