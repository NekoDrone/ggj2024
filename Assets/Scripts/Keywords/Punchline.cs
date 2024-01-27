namespace Keywords
{
    public class Punchline : IKeyword
    {
        public int PunchlineValue { get; set; } = 0;

        public void ExecuteEffect()
        {
            // trigger the Punchline event with the current PunchlineValue
        }
    }
}