
namespace MonopolyBoard/*Written by Sebastian Olsson and Lisa Sönnerhed*/
{
    public class Station : Square/*This class defines the stationsquares, innnheriting the Square class.*/
    {
        protected int owner, block;
        protected bool mortgaged;
        protected frmMonopoly board;

        public Station()/*An empty constructor which is needed in order to be innherited by the other classes*/
        {
            name = "";
            price = 0;
            owner = 5;
            block = 0;
            mortgaged = false;
        }

        public Station(string setName, int setPrice, int setBlock)/*The constructor for the class. The owner is set to 5 because 5 is the bank. Mortgaged is set to false because no square is mortgaged from the start.*/
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
            mortgaged = false;
        }

        public int GetOwner()/*Returns the owner of the object*/
        {
            return owner;
        }

        public int GetBlock()/*Returns the block of object*/
        {
            return block;
        }

        public bool GetMortgaged()/*Returns if the object is mortgaged or not*/
        {
            return mortgaged;
        }

        public void ToggleMortage()/*Toggle mortgage between true and false.*/
        {
            mortgaged = !mortgaged;
        }

        public void ChangeOwner(int newOwner)/*Changes the owner of the object.*/
        {
            owner = newOwner;
        }

        public int GetRent()/*Returns the rent of the object.*/
        {
            return Round(GetPrice() / 4);
        }

        public int GetMortgagePrice()/*Returns the price for mortgaging the object.*/
        {
            return Round(GetPrice() / 2);
        }

        public string GetRentOutput()/*Returns all the different possible rents in a handier way.*/
        {
            return "Äger du en station: " + GetRent() + "kr\nÄger du två stationer: " + GetRent() * 2 + "kr\nÄger du tre stationer: " + GetRent() * 3 + "kr\nÄger du fyra stationer: " + GetRent() * 4 + "kr";
        }

        new public string GetInfo()/*Returns the name, price, rents and if the object is mortgaged.*/
        {
            string info = GetName() + "\n" + GetPrice() + "kr\n" + GetRentOutput();

            if (GetMortgaged())
                info += "\nIntecknad";

            return info;
        }

        protected int Round(int value) /* Rounds to the nearest value of VALUE_TO_ROUND_TO */
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
