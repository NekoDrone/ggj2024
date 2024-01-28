using System;
using Identity;

namespace Events.Keywords
{
    public static class KeywordEvents
    {
        // TODO: Refactor to use targeting system
        public static event Action<CardPlayer, int> CringeEvent;

        public static void InvokeCringeEvent(CardPlayer cardPlayer, int value)
        {
            KeywordEvents.CringeEvent?.Invoke(cardPlayer, value);
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

        public static event Action<CardPlayer, int> SetupEvent;

        public static void InvokeSetupEvent(CardPlayer cardPlayer, int value)
        {
            KeywordEvents.SetupEvent?.Invoke(cardPlayer, value);
        }

        public static event Action<CardPlayer, int> SlapstickEvent;

        public static void InvokeSlapstickEvent(CardPlayer cardPlayer, int value)
        {
            KeywordEvents.SlapstickEvent?.Invoke(cardPlayer, value);
        }

        public static event Action<CardPlayer, int> TickleEvent;

        public static void InvokeTickleEvent(CardPlayer cardPlayer, int value)
        {
            KeywordEvents.TickleEvent?.Invoke(cardPlayer, value);
        }
    }
}