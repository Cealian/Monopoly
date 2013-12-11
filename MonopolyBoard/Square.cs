
namespace MonopolyBoard
{
    public class Square
    {
        protected string name;
        protected int price;

        public Square()
        {
            name = "";
            price = 0;
        }

        public Square(string setName, int setPrice = 0)
        {
            name = setName;
            price = setPrice;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }

        public string GetInfo()
        {
            if (price == 0)
                return name;
            else
                return name + " \n" + price + " kr"; /* Formatera för bättre visning. */
        }
    }
}
