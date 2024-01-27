using System;
using Identity;

namespace Events.Keywords
{
    public static class KeywordEvents
    {
        // TODO: Refactor to use targeting system
        public static event Action<CardPlayer> CringeEvent;
        public static void InvokeCringeEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.CringeEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> MemeEvent;
        public static void InvokeMemeEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.MemeEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> PunEvent;
        public static void InvokePunEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.PunEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> SelfDeprecatingEvent;
        public static void InvokeSelfDeprecatingEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.SelfDeprecatingEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> SetupEvent;
        public static void InvokeSetupEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.SetupEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> SlapstickEvent;
        public static void InvokeSlapstickEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.SlapstickEvent?.Invoke(cardPlayer);
        }
        
        public static event Action<CardPlayer> TickleEvent;
        public static void InvokeTickleEvent(CardPlayer cardPlayer)
        {
            KeywordEvents.TickleEvent?.Invoke(cardPlayer);
        }
    }
}