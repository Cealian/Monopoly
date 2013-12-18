namespace MonopolyBoard
{
    public class FreeParking
    {
        /*Written by Elias Johansson*/

        /*This class is storing methods for handling the freeparking square on the monopoly board.*/
        
        private int value = 0; 
        
        /*Method for addíng money to freeparking*/
        public void AddMoney(int amount)
        {
            value += amount;
        }
        
        /*Method for taking the money from freeparking and store the amount of money in a variable
         The variable will be used in main prog for adding the money to the player who lands on freeparking*/
        public int TakeMoney()
        {
            int save = value; // Saves the current money to the save variable
            value = 0;  // Reset the freeparking money
            return save; //Returns the saved money
        }
        
        /*Method that just returns the current amount of money in freeparking*/
        public int GetValue()
        {
            return value;
        }
    }
}
