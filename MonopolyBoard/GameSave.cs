using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoard
{
    class GameSave
    {
        /* ----- Members ----- */
        private FileStream saveStream;
        public frmMonopoly board;

        /* ----- Constructors ----- */
        public GameSave(ref FileStream newSaveStream)
        {
            saveStream = newSaveStream;
        }

        /* ----- Functions ----- */
        public void Save()
        {
            string gameState = "";


            // - Namn
            gameState += getPlayerNames(); /* name1:name2:name3:name4: */
            // - Positioner
            gameState += getPlayerPositions(); /* pos1:pos2:pos3:pos4: */
            // - Pengar
            gameState += getPlayerMoney(); /* money1:money2:money3:money4: */
            // - Gator
            gameState += getPlayerStreets(); /* 0:streetName1:streetName2:... :1:streetName3:streetName4:...  :2:... :3:... */
            // - Intecknade gator
            // - activePlayer
            // - Hus/Hotell
            // - Chanskortnummer?!
            // - Fritt ut ur fängelse
            // - inJail för alla spelare.
            // - Fir parkering.
            // -_-

            Console.WriteLine(gameState);
            byte[] byteData = null;
            byteData = Encoding.ASCII.GetBytes(gameState);

            saveStream.Write(byteData, 0, byteData.Length);
        }

        private string getPlayerNames() /* Gets the player names for the gameState string. */
        {
            string playerNames = "";

            foreach (PlayerClass player in board.Player)
            {
                playerNames += player.GetName() + ":";
            }

            return playerNames;
        }

        private string getPlayerPositions() /* Gets the player positions for the gameState string. */
        {
            string playerPositions = "";

            foreach (PlayerClass player in board.Player)
            {
                playerPositions += player.GetPosition() + ":";
            }

            return playerPositions;
        }

        private string getPlayerMoney() /* Gets the player money for the gameState string. */
        {
            string playerMoney = "";

            foreach (PlayerClass player in board.Player)
            {
                playerMoney += player.GetMoney() + ":";
            }

            return playerMoney;
        }

        private string getPlayerStreets()
        {
            string playerStreets = "";

            for (int i = 0; i < 5; i++)
            {
                playerStreets = i + ":";
                foreach (var square in board.Squares)
                {
                    Type squareType = square.GetType();
                    int owner = 5;

                    if (squareType == typeof(Street))
                    {
                        owner = ((Street)square).GetOwner();
                    }
                    else if (squareType == typeof(Station))
                    {
                        owner = ((Station)square).GetOwner();
                    }
                    else if (squareType == typeof(PowerStation))
                    {
                        owner = ((PowerStation)square).GetOwner();
                    }

                    if (owner == i)
                    {
                        playerStreets += square.GetName();
                    }
                }
            }

            return playerStreets;
        }
    }
}
