using Events;
using Events.Keywords;
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
            KeywordEvents.CringeEvent += this.HandleCringeEvent;
            KeywordEvents.MemeEvent += this.HandleMemeEvent;
            KeywordEvents.PunEvent += this.HandlePunEvent;
            KeywordEvents.SelfDeprecatingEvent += this.HandleSelfDeprecatingEvent;
            KeywordEvents.SetupEvent += this.HandleSetupEvent;
            KeywordEvents.SlapstickEvent += this.HandleSlapstickEvent;
            KeywordEvents.TickleEvent += this.HandleTickleEvent;
        }

        private void HandleCringeEvent()
        {
            
        }

        private void HandleMemeEvent()
        {
            
        }

        private void HandlePunEvent()
        {
            
        }

        private void HandleSelfDeprecatingEvent()
        {
            
        }

        private void HandleSetupEvent()
        {
            
        }

        private void HandleSlapstickEvent()
        {
            
        }

        private void HandleTickleEvent()
        {
            
        }

    }
}