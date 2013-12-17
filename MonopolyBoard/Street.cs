using System;

namespace MonopolyBoard/*Written by Sebastian Olsson and Lisa Sönnerhed*/
{
    public class Street : Station/*This class defines the streetsquares, innnheriting the Station class, which has innherited the Square class.*/
    {
        protected int noOfHouses;

        public Street(string setName, int setPrice, int setBlock)/*The constructor for this class. noOfHouses is set to 0 since there are no houses in the beginning.*/
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
            noOfHouses = 0;
            mortgaged = false;
        }

        public int GetNoOfHouses()/*Returns the number of houses on the street.*/
        {
            return noOfHouses;
        }

        public void BuildHouse()/*Adds a house on the street*/
        {
            noOfHouses++;
        }

        new public int GetRent()/*Returns the rent depending on the number of houses.*/
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

        new public string GetRentOutput()/*Returns all the different possible rents in a handier way.*/
        {
            return "Bara tomt: " + Round(Convert.ToInt32(GetPrice() * 0.08)) + "kr\nEtt hus: " + Round(Convert.ToInt32(GetPrice() * 0.38)) + "kr\nTvå hus: " + Round(Convert.ToInt32(GetPrice() * 1.08))
                + "kr\nTre hus: " + Round(Convert.ToInt32(GetPrice() * 2.78)) + "kr\nFyra hus: " + Round(Convert.ToInt32(GetPrice() * 3.78)) + "kr\nEtt hotell: " + Round(Convert.ToInt32(GetPrice() * 4.88)) + "kr";
        }

        public void SellHouse()/*Subtracts 1 house from the street.*/
        {
            noOfHouses--;
        }

        public int GetHousePrice()/*Returns the price for buying a house.*/
        {
            return Round(Convert.ToInt32(GetPrice() * 0.69));
        }

        public int GetSellHousePrice()/*Returns the price for selling a house.*/
        {
            return Round(Convert.ToInt32(GetPrice() * 0.345));
        }

        new public string GetInfo()/*Returns name, price, rent, house price and if the street is mortgaged.*/
        {
            string info = GetName() + " \n" + GetPrice() + "kr\n" + GetRentOutput() + "\nHus kostar: " + GetHousePrice() + "kr";

            if (GetMortgaged())
                info += "\nIntecknad";

            return info;
        }
    }
}
