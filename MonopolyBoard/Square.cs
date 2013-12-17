
namespace MonopolyBoard/*Written by Sebastian Olsson and Lisa Sönnerhed*/
{
    public class Square/*This class defines all squares on the board which is innherited by the other classes concerning the board.*/
    {
        protected string name;
        protected int price;

        public Square()/*An empty constructor which is needed in order to be innherited by the other classes*/
        {
            name = "";
            price = 0;
        }

        public Square(string setName, int setPrice = 0)/*The constructor for the class. setPrice is 0 by default because some squares dosen't have a price.*/
        {
            name = setName;
            price = setPrice;
        }

        public string GetName()/*Returns the name of the object.*/
        {
            return name;
        }

        public int GetPrice()/*Returns the price of the object*/
        {
            return price;
        }

        public string GetInfo()/*Returns the name and price(if there is any) of the object*/
        {
            if (price == 0)
                return name;
            else
                return name + " \n" + price + "kr"; /* Formatera för bättre visning. */
        }
    }
}
