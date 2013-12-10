﻿
namespace MonopolyBoard
{
    public class Station : Square
    {
        private int owner, block;

        public Station() /* Nödvändig? */
        {
            SetName("");
            SetPrice(0);
            owner = 5;
            block = 0;
        }

        public Station(string setName, int setPrice, int setBlock)
        {
            /*
             * name = setName   ?
             * price = setPrice ?
             */

            SetName(setName);
            SetPrice(setPrice);
            owner = 5;
            block = setBlock;
        }

        public int GetOwner()
        {
            return owner;
        }

        public int GetBlock()
        {
            return block;
        }

        public void ChangeOwner(int newOwner)
        {
            owner = newOwner;
        }

        public int GetRent()
        {
            return GetPrice() / 4;
        }

        public int GetSellPrice()
        {
            return GetPrice() / 2;
        }

        public void SetBlock(int setBlock)
        {
            block = setBlock;
        }

        public void SetOwner(int setOwner)
        {
            owner = setOwner;
        }

        public string GetRents() /* Formatera för bättre visning */
        {
            return "Äger du en station: " + GetRent() + " kr\nÄger du två stationer: " + GetRent() * 2 + " kr\nÄger du tre stationer: " + GetRent() * 3 + " kr\nÄger du fyra stationer: " + GetRent() * 4+" kr";
        }

       new public string GetInfo()
       {
            return GetName() + " \n" + GetPrice() + " kr\n" + GetRents();
       }
       
        private int Round(int value) /* Rounds to the nearest value of VALUE_TO_ROUND_TO */
        {
            int newValue = 0;
            const int VALUE_TO_ROUND_TO = 50;

            newValue = (value / VALUE_TO_ROUND_TO) * VALUE_TO_ROUND_TO;

            if (value - newValue >= (VALUE_TO_ROUND_TO / 2))
            {
                newValue += VALUE_TO_ROUND_TO;
            }

            return newValue;
        }
    }
}
