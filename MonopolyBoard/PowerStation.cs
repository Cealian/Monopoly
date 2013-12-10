
namespace MonopolyBoard
{
    public class PowerStation:Station
    {
        public PowerStation()
        {
            name = "";
            price = 0;
            owner=5;
            block = 0;
        }

        public PowerStation(string setName, int setPrice, int setBlock)
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
        }

        public int GetRent(int dice)
        {
            return (100 * dice);
        }

        new public string GetRentOutput()
        {
            return "Äger du ETT kraftverk blir hyran 100 * värdet tärningarna visar.\nÄger du TVÅ kraftverk blir hyran 200 * värdet tärningarna visar."; 
        }

        new public string GetInfo()
        {
            return GetName() +"\n"+ GetPrice() +" kr\n"+ GetRentOutput();
        }
    }
}
