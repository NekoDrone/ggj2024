namespace Keywords
{
    public class Slapstick : IKeyword
    {
        public int SlapstickValue { get; set; }

        public Slapstick(int slapstickValue)
        {
            this.SlapstickValue = slapstickValue;
        }
        
        public void ExecuteEffect()
        {
            // TODO: trigger Slapstick event with current SlapstickValue to reduce enemy threshold by value and take value of damage
        }
    }
}