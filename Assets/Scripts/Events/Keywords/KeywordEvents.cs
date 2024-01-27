using System;

namespace Events.Keywords
{
    public static class KeywordEvents
    {
        // TODO: Refactor to use targeting system
        public static event Action CringeEvent;
        public static void InvokeCringeEvent()
        {
            KeywordEvents.CringeEvent?.Invoke();
        }
        
        public static event Action MemeEvent;
        public static void InvokeMemeEvent()
        {
            KeywordEvents.MemeEvent?.Invoke();
        }
        
        public static event Action PunEvent;
        public static void InvokePunEvent()
        {
            KeywordEvents.PunEvent?.Invoke();
        }
        
        public static event Action SelfDeprecatingEvent;
        public static void InvokeSelfDeprecatingEvent()
        {
            KeywordEvents.SelfDeprecatingEvent?.Invoke();
        }
        
        public static event Action SetupEvent;
        public static void InvokeSetupEvent()
        {
            KeywordEvents.SetupEvent?.Invoke();
        }
        
        public static event Action SlapstickEvent;
        public static void InvokeSlapstickEvent()
        {
            KeywordEvents.SlapstickEvent?.Invoke();
        }
        
        public static event Action TickleEvent;
        public static void InvokeTickleEvent()
        {
            KeywordEvents.TickleEvent?.Invoke();
        }
    }
}