using System;

namespace MonopolyBoard
{
    public class Street : Station
    {
        protected int noOfHouses;

        public Street()
        {
            name = "";
            price = 0;
            owner = 5;
            block = 0;
            noOfHouses = 0;
        }

        public Street(string setName, int setPrice, int setBlock)
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
            noOfHouses = 0;
        }

        public int GetNoOfHouses()
        {
            return noOfHouses;
        }

        public void BuildHouse()
        {
            noOfHouses++;
        }
        
        new public int GetRent()
        {
            if (noOfHouses == 0)
                return Round(Convert.ToInt32(GetPrice() * 0.08));
            else if (noOfHouses == 1)
                return Round(Convert.ToInt32(GetPrice() * 0.38));
            else if (noOfHouses == 2)
                return Round(Convert.ToInt32(GetPrice() * 1.08));
            else if (noOfHouses == 3)
                return Round(Convert.ToInt32(GetPrice() * 2.78));
            else if (noOfHouses == 4)
                return Round(Convert.ToInt32(GetPrice() * 3.78));
            else
                return Round(Convert.ToInt32(GetPrice() * 4.88));
        }
        
        new public string GetRentOutput()
        {
            return "Bara tomt: " + Round(Convert.ToInt32(GetPrice() * 0.08)) + "kr\nEtt hus: " + Round(Convert.ToInt32(GetPrice() * 0.38)) + "kr\nTvå hus: " + Round(Convert.ToInt32(GetPrice() * 1.08))
                + "kr\nTre hus: " + Round(Convert.ToInt32(GetPrice() * 2.78)) + "kr\nFyra hus: " + Round(Convert.ToInt32(GetPrice() * 3.78)) + "kr\nEtt hotell: " + Round(Convert.ToInt32(GetPrice() * 4.88)) + "kr";
        }
        
        public void SellHouse()
        {
            noOfHouses--;
        }
        
        public int GetHousePrice()
        {
            return Round(Convert.ToInt32(GetPrice() * 0.69));
        }
        
        public int GetSellHousePrice()
        {
            return Round(Convert.ToInt32(GetPrice() * 0.345));
        }

        new public string GetInfo()
        {
            return GetName() + " \n" + GetPrice() + "kr\n" + GetRentOutput() + "\nHus kostar: " + GetHousePrice() + "kr";
        }
    }
}
