using Events;
using Player.Stats;
using TurnSystem;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        
        public int maxHealth = 100;
        public int currentHealth;
        public bool isMyTurn = true;
        public Punchline Punchline = new();
        public Threshold Threshold = new();
        public TurnHandler TurnHandler = new TurnHandler();
    
        private void Start()
        {
            this.currentHealth = this.maxHealth;
            this.SubscribeToBaseEvents();
            this.SubscribeToKeywordEvents();
        }
        
        private void SubscribeToBaseEvents()
        {
            BaseEvents.NormalDamageEvent += this.TakeDamage;
            BaseEvents.DirectDamageEvent += this.TakeDamage;
            this.TurnHandler.TurnChange += this.ChangeTurn;
        }

        private void TakeDamage(int damage)
        {
            this.currentHealth -= damage;
        }

        private void ChangeTurn()
        {
            this.isMyTurn = !this.isMyTurn;
        }


        private void SubscribeToKeywordEvents()
        {
            
        }

    }
}