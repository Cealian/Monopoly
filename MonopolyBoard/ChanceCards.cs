using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoard
{
    public class ChanceCards
    {
        /* ----- Members ----- */
        public frmMonopoly board;
        private string text;
        private int value, position;
        private bool jailCard;

        /* ----- Function ----- */
        public ChanceCards(string setText, int setValue, bool setJailCard = false, int setPosition = 0)
        {
            text = setText;
            value = setValue;
            position = setPosition;
            jailCard = setJailCard;
        }

        public void GiveJailCard()
        {
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

        public bool GetJailCard()
        {
            return jailCard;
        }

        public void ChangePosition(int startPosition)
        {
            int stepsToMove = 0;
            if (startPosition > GetPosition())
            {
                stepsToMove = GetPosition() - startPosition + 40;
            }
            else
                stepsToMove = GetPosition() - startPosition;

            board.MovePlayer(stepsToMove);
        }

        public void GoToJail()
        {
            board.MoveActivePlayerToJail();
        }

        public void GetMoneyFromAll()
        {
            for (int i = 0; i < board.Player.Length; i++)
            {
                if (board.Player[i].GetName() != "" && i != board.activePlayer)
                {
                    board.Player[i].SubtractMoney(GetValue());
                    board.Player[board.activePlayer].AddMoney(GetValue());
                }
            }
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
