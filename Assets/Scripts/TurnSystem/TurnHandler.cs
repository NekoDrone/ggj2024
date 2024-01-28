using System;

namespace TurnSystem
{
    public class TurnHandler
    {
        public Turn CurrentTurn = Turn.Player;
        public event Action TurnChange;

        public void ChangeTurn()
        {
            this.CurrentTurn = this.CurrentTurn == Turn.Player ? Turn.Enemy : Turn.Player;
            this.TurnChange?.Invoke();
        }
    }
}