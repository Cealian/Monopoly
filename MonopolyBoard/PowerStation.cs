﻿
namespace MonopolyBoard
{
    public class PowerStation:Station
    {
        public PowerStation()
        {
            SetName("");
            SetPrice(0);
            SetOwner(5);
            SetBlock (0);
        }

        public PowerStation(string setName, int setPrice, int setBlock)
        {
            SetName(setName);
            SetPrice(setPrice);
            SetOwner(5);
            SetBlock(setBlock);
        }
        public int GetRent(int dice)
        {
            return (100 * dice);
        }

        new public string GetRents()
        {
            return "Om du äger ETT kraftverk blir hyran 100 * värdet tärningarna visar.\n Äger du TVÅ kraftverk blir hyran 200 * värdet tärningarna visar, osv"; 
        }

        new public string GetInfo()
        {
            return GetName() + GetOwner() + GetPrice() + GetRents();
        }
    }
}
