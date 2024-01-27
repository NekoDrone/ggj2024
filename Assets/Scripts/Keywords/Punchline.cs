namespace Keywords
{
    public class Punchline : IKeyword
    {
        public int PunchlineValue { get; set; } = 0;

        public void ExecuteEffect()
        {
            // TODO: trigger the Punchline event with the current PunchlineValue
        }

        public void SetupPunchline(int value)
        {
            this.PunchlineValue += value;
        }
    }
}