
using System;
namespace MonopolyBoard
{
    public class PlayerClass
    {
        //MEMBERS
        private string name;
        private int money = 30000;
        private int position = 0;
        private bool inJail = false;
        private int steps;
        private int stepsLeft;


        public void Move(int steps)
        {
            stepsLeft = steps;
        }

        // funktioner
        public PlayerClass(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void MoveForward(int steps)
        {
            //flytta fram, om position > 39 efter position -= 39
            position += steps;  //addera steg
            if (position > 39)
            {
                position -= 40;
            }
        }

        public void MoveToJail()
        {
        inJail = true;
        position = 10;
        }

        public bool IsInJail()
        {
            return inJail;
        }

        public void GetOutOfJail()
        {
            inJail = false;
        }

        public void SubtractMoney(int GiveAmount)
        {
            if (money >= GiveAmount)
            {
                money -= GiveAmount;
            }
            else
            {
                // alternativ: konkurs, sälja av gator till bank, 
            }
        }

        public void AddMoney(int TakenAmount)
        {
            money += TakenAmount;
        }

        public int GetPosition()
        {
            return position;
        }

        public bool TakeStep()
        {
            stepsLeft--;
            bool moreSteps = (stepsLeft > 0);

            Console.WriteLine("Steps left: {0}", stepsLeft);

            return moreSteps;
        }

    }
}
