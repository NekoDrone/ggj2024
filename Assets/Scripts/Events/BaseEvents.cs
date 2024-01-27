using System;

namespace Events
{
    public static class BaseEvents
    {
        public static event Action<int> NormalDamageEvent;
        public static void DealNormalDamage(int damageValue)
        {
            NormalDamageEvent?.Invoke(damageValue);
        }

        public static event Action<int> DirectDamageEvent;
        public static void DealDirectDamage(int damageValue)
        {
            DirectDamageEvent?.Invoke(damageValue);
        }

        public static event Action<int> IncreaseShieldEvent;
        public static void IncreaseShield(int shieldValue)
        {
            IncreaseShieldEvent?.Invoke(shieldValue);
        }
        
        public static event Action<int> ReduceShieldEvent;
        public static void ReduceShield(int shieldValue)
        {
            ReduceShieldEvent?.Invoke(shieldValue);
        }

    }
}