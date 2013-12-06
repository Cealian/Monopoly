namespace MonopolyBoard
{
    class FreeParking
    {
        /*Classen skapar metod för att registrera in pengar i friparkering och 
         * metod för att skicka friparkerings pengar över till spelaren 
         
         Kod av : Elias Johansson */
        
        private int value = 0; //Value är bankens nuvarande pengar
        
        public void AddMoney(int amount)
        {
            value += amount; //Lägg till det som skickas in i metoden till bankens pengar (value)
        }
        
        public int TakeMoney()
        {
            int save = value; //Sparar ner bankens pengar till en variabel "save"
            value = 0;  // Nollställer bankens pengar
            return save; //Returnerar det som ligger sparat i "save"
        }
        
        /*Här skapas en metod GetValue som enbart returnerar det belopp som ligger i bankens pengar*/
        public int GetValue()
        {
            return value;
        }

        //TEst
    }
}
