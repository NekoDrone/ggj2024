using System;
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
        private readonly Punchline _punchline = new();
        public int threshold = 5;
        private TurnHandler _turnHandler = new TurnHandler();
    
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
            this._turnHandler.TurnChange += this.ChangeTurn;
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
        
        private void HandleCringeEvent(CardPlayer cardPlayer, int value)
        {
            if (CardPlayerIsMe(cardPlayer)) return;
            this.IncreaseShieldBy(value);
        }

        private void HandleMemeEvent(CardPlayer cardPlayer)
        {
            // TODO: figure out how to repeat an action;
        }

        private void HandlePunEvent(CardPlayer cardPlayer)
        {
            if (CardPlayerIsMe(cardPlayer)) return;
            this.TakeDamage(1);
        }

        private void HandleSelfDeprecatingEvent(CardPlayer cardPlayer)
        {
            if (CardPlayerIsMe(cardPlayer)) this.IncreaseShieldBy(1);
        }

        private void HandleSetupEvent(CardPlayer cardPlayer, int value)
        {
            if (CardPlayerIsMe(cardPlayer)) this._punchline.Increase(value);
        }

        private void HandleSlapstickEvent(CardPlayer cardPlayer, int value)
        {
            if (CardPlayerIsMe(cardPlayer)) this.TakeDamage(value);
            else this.DecreaseShieldBy(value);
        }

        private void HandleTickleEvent(CardPlayer cardPlayer, int value)
        {
            if (CardPlayerIsMe(cardPlayer)) return;
            this.DecreaseShieldBy(value);
        }

        private void IncreaseShieldBy(int value)
        {
            this.threshold += value;
        }

        private void DecreaseShieldBy(int value)
        {
            this.threshold -= value;
        }
    }
}