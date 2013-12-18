using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoard/*Written by Sebastian Olsson*/
{
    public class CommunityCards/*This class defines the Community chest cards in the game.*/
    {
        public frmMonopoly board;
        private string text;
        private int value, position;
        private bool jailCard;

        public CommunityCards(string setText, int setValue, bool setJailCard = false, int setPosition = 0)/*The counstructor for this class.*/
        {
            text = setText;
            value = setValue;
            position = setPosition;
            jailCard = setJailCard;
        }

        public void GiveJailCard()/*Gives the active player a get-out-of-jail-card.*/
        {
            board.Player[board.activePlayer].GetJailCard();
        }

        public string GetText()/*Returns the text of the card.*/
        {
            return text;
        }

        public int GetValue()/*Returns the value of the card.*/
        {
            return value;
        }

        public int GetPosition()/*Returns the position of the card.*/
        {
            return position;
        }

        public bool GetJailCard()/*Returns if it's a get-out-of-jail-card or not.*/
        {
            return jailCard;
        }

        public void ChangePosition(int startPosition)/*Moves the active player to the position that the card says.*/
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

        public void GoToJail()/*Moves the active player to jail.*/
        {
            board.MoveActivePlayerToJail();
        }

        public void GetMoneyFromAll()/*Takes money from all the other players and gives it to the active player.*/
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

        public void GetOrPay()/*Either gives to the active pleyer or takes money from the active player and gives it to freeparking.*/
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
