
namespace MonopolyBoard
{
    public class Station : Square
    {
        protected int owner, block;
        protected bool mortgaged;
        protected frmMonopoly board;

        public Station()
        {
            name = "";
            price = 0;
            owner = 5;
            block = 0;
            mortgaged = false;
        }

        public Station(string setName, int setPrice, int setBlock)
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
            mortgaged = false;
        }

        public int GetOwner()
        {
            return owner;
        }

        public int GetBlock()
        {
            return block;
        }

        public bool GetMortgaged()
        {
            return mortgaged;
        }

        public void ToggleMortage()
        {
            mortgaged = !mortgaged;
        }

        public void ChangeOwner(int newOwner)
        {
            owner = newOwner;
        }

        public int GetRent()
        {
            return Round(GetPrice() / 4);
        }

        public int GetMortgagePrice()
        {
            return Round(GetPrice() / 2);
        }

        public string GetRentOutput()
        {
            return "Äger du en station: " + GetRent() + "kr\nÄger du två stationer: " + GetRent() * 2 + "kr\nÄger du tre stationer: " + GetRent() * 3 + "kr\nÄger du fyra stationer: " + GetRent() * 4 + "kr";
        }

        new public string GetInfo()
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
