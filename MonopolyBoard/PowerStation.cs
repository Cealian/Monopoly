
namespace MonopolyBoard
{
    public class PowerStation:Station
    {
        public PowerStation()
        {
            SetName("");
            SetPrice(0);
            SetOwner(0);
            SetBlock (0);
        }

        public PowerStation(string setName, int setPrice, int setBlock)
        {
            SetName(setName);
            SetPrice(setPrice);
            SetOwner(0);
            SetBlock(setBlock);
        }
        new public int GetRent(int dice)
        {
            return (100 * dice);
        }
    }
}
