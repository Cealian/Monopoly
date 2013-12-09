using System;

namespace MonopolyBoard
{
    public class Street:Station
    {
        private int noOfHouses;
  
         public Street()
        {
            SetName("");
            SetPrice(0);
            SetOwner(0);
            SetBlock (0);
            noOfHouses = 0;
        }

        public Street(string setName, int setPrice, int setBlock)
        {
            SetName(setName);
            SetPrice(setPrice);
            SetOwner(0);
            SetBlock(setBlock);
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
                return Convert.ToInt32(GetPrice()*0.08);
            else if (noOfHouses == 1)
                return Convert.ToInt32(GetPrice()*0.38);
            else if (noOfHouses == 2)
                return Convert.ToInt32(GetPrice()*1.08);
            else if (noOfHouses == 3)
                return Convert.ToInt32(GetPrice()*2.78);
            else if (noOfHouses == 4)
                return Convert.ToInt32(GetPrice()*3.78);
            else
                return Convert.ToInt32(GetPrice()*4.88);
        }
        new public string GetRents()
        {
            return "Bara tomt: " + Convert.ToInt32(GetPrice() * 0.08) + " \nEtt hus: " + Convert.ToInt32(GetPrice() * 0.38) + " \nTvå hus: " + Convert.ToInt32(GetPrice() * 1.08)
                + " \nTre hus: " + Convert.ToInt32(GetPrice() * 2.78) + " \nFyra hus: " + Convert.ToInt32(GetPrice() * 3.78) + " \nEtt hotell: " + Convert.ToInt32(GetPrice() * 4.88);
        }
        public void SellHouse()
        {
            noOfHouses--;
        }
        public int GetHousePrice()
        {
            return Convert.ToInt32(GetPrice() * 0.69);
        }
        public int GetSellHousePrice()
        {
            return Convert.ToInt32(GetPrice() * 0.345);
        }

        new public string GetInfo()
        {
            return GetName()+" \n" + GetPrice()+" \n" + GetRents()+" \nHus kostar: " + GetHousePrice();
        }

    }
}
