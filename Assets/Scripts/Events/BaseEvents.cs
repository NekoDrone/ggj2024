using System;

namespace Events
{
    public static class BaseEvents
    {
        public static event Action<int> DealNormalDamage;
        public static void InvokeDealNormalDamage(int damageValue)
        {
            DealNormalDamage?.Invoke(damageValue);
        }

        public static event Action<int> DealDirectDamage;
        public static void InvokeDealDirectDamage(int damageValue)
        {
            DealDirectDamage?.Invoke(damageValue);
        }

        public static event Action<int> IncreaseShield;
        public static void InvokeGainShield(int shieldValue)
        {
            IncreaseShield?.Invoke(shieldValue);
        }
        
        public static event Action<int> ReduceShield;
        public static void InvokeReduceShield(int shieldValue)
        {
            ReduceShield?.Invoke(shieldValue);
        }

    }
}