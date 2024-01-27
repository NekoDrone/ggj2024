using Events;
using Events.Keywords;
using Identity;
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
        public int Threshold = 5;
        public TurnHandler TurnHandler = new TurnHandler();
        public string Identity;
    
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

        private static bool CardPlayerIsMe(CardPlayer cardPlayer)
        {
            return cardPlayer == CardPlayer.Player;
        }
        
        private void HandleCringeEvent(CardPlayer cardPlayer)
        {
            if (!CardPlayerIsMe(cardPlayer))
            {
                BaseEvents.IncreaseShieldEvent += i =>
                {
                    this.Threshold += i;
                };
            }
        }

        private void HandleMemeEvent(CardPlayer cardPlayer)
        {
            // TODO: figure out how to repeat an action;
        }

        private void HandlePunEvent(CardPlayer cardPlayer)
        {
            
        }

        private void HandleSelfDeprecatingEvent(CardPlayer cardPlayer)
        {
            
        }

        private void HandleSetupEvent(CardPlayer cardPlayer)
        {
            
        }

        private void HandleSlapstickEvent(CardPlayer cardPlayer)
        {
            
        }

        private void HandleTickleEvent(CardPlayer cardPlayer)
        {
            
        }

        private void CleanupKeywordEvent()
        {
            
        }

    }
}