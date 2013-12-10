
namespace MonopolyBoard
{
    public class Square
    {
        private string name;
        private int price;

        public Square() /* Nödvändig? */
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

        public void SetName(string setName)
        {
            name = setName;
        }

        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int setPrice)
        {
            price = setPrice;
        }
        public string GetInfo()
        {
            if (price == 0)
                return name;
            else
                return name + " \n" + price; /* Formatera för bättre visning. */
        }
    }

}
