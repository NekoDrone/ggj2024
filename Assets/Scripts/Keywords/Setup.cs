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
            // TODO: trigger Setup event to add current SetupValue to the Punchline Value
        }
    }
}