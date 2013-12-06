
namespace MonopolyBoard
{
    public class Station:Square
    {
        private int owner, block;

        public Station()
        {
            SetName("");
            SetPrice(0);
            owner = 0;
            block = 0;
        }

        public Station(string setName, int setPrice, int setBlock)
        {
            SetName(setName);
            SetPrice(setPrice);
            owner = 0;
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

    }
}
