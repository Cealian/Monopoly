
namespace MonopolyBoard/*Written by Sebastian Olsson and Lisa Sönnerhed*/
{
    public class PowerStation : Station/*This class defines the powerstationsquares, innnheriting the Station class, which has innherited the Square class.*/
    {
        public PowerStation(string setName, int setPrice, int setBlock)/*Constructor for the class.*/
        {
            name = setName;
            price = setPrice;
            owner = 5;
            block = setBlock;
            mortgaged = false;
        }

        public int GetRent(int dice)/*Returns the rent which depends on the value of the dice.*/
        {
            return (100 * dice);
        }

        new public string GetRentOutput()/*Returns the possible rents.*/
        {
            return "Äger du ETT kraftverk blir hyran 100 * värdet tärningarna visar.\nÄger du TVÅ kraftverk blir hyran 200 * värdet tärningarna visar."; 
        }

        new public string GetInfo()/*Returns name, price, rent and if the powerstation is mortgaged.*/
        {
            string info=GetName() +"\n"+ GetPrice() +"kr\n"+ GetRentOutput();

            if (GetMortgaged())
                info += "\nIntecknad";

            return info;
        }
    }
}
