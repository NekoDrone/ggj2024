using Events;
using Player.Stats;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        
        public int maxHealth = 100;
        public int currentHealth;
        public Punchline Punchline = new();
        public Threshold Threshold = new();
    
        private void Start()
        {
            this.currentHealth = this.maxHealth;
            BaseEvents.NormalDamageEvent += this.TakeDamage;
            BaseEvents.DirectDamageEvent += this.TakeDamage;
        }

        private void TakeDamage(int damage)
        {
            this.currentHealth -= damage;
        }
    }
}