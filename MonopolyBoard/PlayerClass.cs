﻿using System;

namespace MonopolyBoard
{
    public class PlayerClass
    {
        /* ----- Members ----- */
        private string name;
        private int money = 10000;
        private int position = 0;
        private bool jailCard = false;
        private bool inJail = false;
        private int stepsLeft; // Used when moving player to see how many steps he/she has left.
        public frmMonopoly board;

        /* ----- Functions -----*/
        public PlayerClass(string newName) /* Constructor, sets player name. */
        {
            name = newName;
            board = new frmMonopoly();
        }

        public string GetName() /* Return the name of the player. */
        {
            return name;
        }

        public void MoveForward(int steps) /* increment position. Reset position and give player 4000 if he/she passes square 0. */
        {
            stepsLeft = steps;
            position += steps;
            if (position > 39)
            {
                position -= 40;
                money += 4000;
            }
        }

        public void MoveToJail() /* Set inJail and position to values according to him/her being in jail. */
        {
            inJail = true;
            position = 10;
        }

        public bool IsInJail() /* Used to determine wheter the player is in jail. Returns true if he/she is. */
        {
            return inJail;
        }

        public void GetOutOfJail() /* Set inJail to values according to him/her being out of jail. */
        {
            inJail = false;
        }

        public void SubtractMoney(int amount) /* decreases the players money by the specified amount. */
        {
            if (money >= amount)
            {
                money -= amount;
                return;
            }

            money -= amount;

            Console.WriteLine("Can't afford it!");

            board.btnBankrupt.Show();
            board.btnNextPlayer.Enabled = false;
            board.btnRollDices.Enabled = false;
        }

        public void AddMoney(int amount) /* Increases the players money by the specified amount. */
        {
            money += amount;

            if (money > 0 && board.btnBankrupt.Visible)
            {
                board.btnBankrupt.Hide();
                if (board.diceEqualCount > 0)
                {
                    board.btnRollDices.Enabled = true;
                }
                else
                {
                    board.btnNextPlayer.Enabled = true;
                }
            }
        }

        public int GetPosition() /* Returns the players position (0 - 39) */
        {
            return position;
        }

        public int GetMoney() /* Returns the players avaliable money. */
        {
            return money;
        }

        public bool TakeStep() /* stepsLeft is used when moving player to see how many steps he/she has left. */
        {
            stepsLeft--;
            bool moreSteps = (stepsLeft > 0);

            return moreSteps;
        }

        public bool HasJailCard()
        {
            return jailCard;
        }

        public void GetJailCard()
        {
            jailCard = true;
        }

        public void UseJailCard()
        {
            jailCard = false;
        }

        public void GoBankrupt()
        {
            name = "";
            money = 0;
        }

        //SETMONEY Ta bort sen
        public void SetMoney(int newMoney)
        {
            money = newMoney;
        }
    }
}
