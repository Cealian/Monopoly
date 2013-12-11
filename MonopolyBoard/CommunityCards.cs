using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoard
{
    public class CommunityCards
    {
        public frmMonopoly board;
        private string text;
        private int value, position;
        private bool jailCard;

        /* ----- Function ----- */
        public CommunityCards(string setText, int setValue, bool setJailCard = false, int setPosition = 0)
        {
            text = setText;
            value = setValue;
            position = setPosition;
            jailCard = setJailCard;
        }

        public void GiveJailCard()
        {
            if (jailCard)
                board.Player[board.activePlayer].GetJailCard();
        }

        public string GetText()
        {
            return text;
        }

        public int GetValue()
        {
            return value;
        }

        public int GetPosition()
        {
            return position;
        }

        public void ChangePosition()
        {
            if (GetPosition() == -1)
                board.MoveActivePlayerToJail();

            int startPosition = board.Player[board.activePlayer].GetPosition();
            int stepsToMove = 0;
            if (startPosition > GetPosition())
            {
                stepsToMove = GetPosition() - startPosition + 40;
            }
            else
                stepsToMove = GetPosition() - startPosition;

            board.MovePlayer(stepsToMove);
        }

        public void GetOrPay()
        {
            if (GetValue() < 0)
            {
                board.Player[board.activePlayer].SubtractMoney(GetValue() * -1);
                board.Freepark.AddMoney(GetValue() * -1);
            }
            else
                board.Player[board.activePlayer].AddMoney(GetValue());
        }
    }
}
