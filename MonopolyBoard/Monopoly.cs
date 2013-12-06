using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class Monopoly : Form
    {

        public GFX GEngine; /* GFX engine */
        public Player[] Player = new Player[4]; /* Players */
        public Square[] SquaresArray = new Square[40];
        public BindingList<Square> Squares;
        public FreeParking Freepark = new FreeParking();

        int paces = 0;
        const int PACES_PER_SQUARE = 6;
        const int PX_PER_PACE = 9;
        int activePlayer = new Random().Next(-1, 5);
        int diceEqualCount = 0;

        public Monopoly()
        {
            InitializeComponent();
            AllocConsole();

            InstantiateSquares();
            InstantiateStreets();
            InstantiateStations();
            InstantiatePowerStations();

            Squares = new BindingList<Square>(SquaresArray);

            for (int i = 0; i < 4; i++)
            {
                Player[i] = new Player("Kalle");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) /* Make sure user really wants to quit. */
        {

            if (MessageBox.Show("Quit monopoly", "Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pnlMainPanel_Paint(object sender, PaintEventArgs e) /* Paint monopoly board using GFX engine */
        {
            Graphics panelToPaint = pnlMainPanel.CreateGraphics();
            GEngine = new GFX(panelToPaint);
        }
       
        private void btnMove_Click(object sender, EventArgs e) /* Move the selected player the specified number of steps */
        {
            if(!tmrMovePlayer.Enabled)
            {
                MovePlayer( Convert.ToInt16(txtNumberOfSteps.Text));
            }
        }

        public void MovePlayer(int steps)
        {
            Player[activePlayer].Move(steps);
            tmrMovePlayer.Start();
        }

        private void tmrMovePlayer_Tick(object sender, EventArgs e) /* Move player until its remaining steps = 0 */
        {
            MoveActivePlayer();
        }

        public void MoveActivePlayer() /* Move the active player */
        {
            if(paces < PACES_PER_SQUARE) /* Move the player 16px five times for every square. */
            {
                if (activePlayer == 0)
                {
                    MovePlayer0();
                    return;
                }
                else if (activePlayer == 1)
                {
                    MovePlayer1();
                    return;
                }
                else if (activePlayer == 2)
                {
                    MovePlayer2();
                    return;
                }
                else if (activePlayer == 3)
                {
                    MovePlayer3();
                    return;
                }
            }
            paces = 0;

            if(!Player[activePlayer].TakeStep())
            {
                tmrMovePlayer.Stop();

                Console.WriteLine(picPlayer2.Location.X + " - " + picPlayer2.Location.Y);

                NextPlayer();
                Console.WriteLine("Active player: {0}", activePlayer);
            }
        }

        private void MovePlayer0() /* Move player 0 one pace */
        {
            int X = picPlayer0.Location.X;
            int Y = picPlayer0.Location.Y;

            if (X < 38 && Y > 38)
            {
                Y -= PX_PER_PACE;
            }
            else if (X < 569 && Y < 38)
            {
                X += PX_PER_PACE;
            }
            else if (X > 569 && Y < 569)
            {
                Y += PX_PER_PACE;
            }
            else if (X > 38 && Y > 569)
            {
                X -= PX_PER_PACE;
            }

            picPlayer0.Location = new Point(X, Y);


            paces++;
        }

        private void MovePlayer1() /* Move player 1 one pace */
        {
            int X = picPlayer1.Location.X;
            int Y = picPlayer1.Location.Y;

            if (X < 38 && Y > 64)
            {
                Y -= PX_PER_PACE;
            }
            else if (X < 569 && Y < 64)
            {
                X += PX_PER_PACE;
            }
            else if (X > 569 && Y < 595)
            {
                Y += PX_PER_PACE;
            }
            else if (X > 38 && Y > 595)
            {
                X -= PX_PER_PACE;
            }

            picPlayer1.Location = new Point(X, Y);

            paces++;
        }

        private void MovePlayer2() /* Move player 2 one pace */
        {
            int X = picPlayer2.Location.X;
            int Y = picPlayer2.Location.Y;

            if (X < 64 && Y > 38)
            {
                Y -= PX_PER_PACE;
            }
            else if (X < 595 && Y < 38)
            {
                X += PX_PER_PACE;
            }
            else if (X > 595 && Y < 569)
            {
                Y += PX_PER_PACE;
            }
            else if (X > 64 && Y > 569)
            {
                X -= PX_PER_PACE;
            }

            picPlayer2.Location = new Point(X, Y);

            paces++;
        }

        private void MovePlayer3() /* Move player 3 one pace */
        {
            int X = picPlayer3.Location.X;
            int Y = picPlayer3.Location.Y;

            if (X < 64 && Y > 64)
            {
                Y -= PX_PER_PACE;
            }
            else if (X < 595 && Y < 64)
            {
                X += PX_PER_PACE;
            }
            else if (X > 595 && Y < 595)
            {
                Y += PX_PER_PACE;
            }
            else if (X > 64 && Y > 595)
            {
                X -= PX_PER_PACE;
            }

            picPlayer3.Location = new Point(X, Y);

            paces++;
        }

        public void NextPlayer() /* Change activePlayer to next player */
        {
            if (diceEqualCount == 0)
            {
                activePlayer++;
            }

            if(activePlayer > 3)
            {
                activePlayer = 0;
            }
        }

        public void InstantiateSquares() /* Instantiate all squares that are just squares */
        {
            SquaresArray[0] = new Square("Gå", 4000);
            SquaresArray[2] = new Square("Allmänning");
            SquaresArray[4] = new Square("Inkomstskatt", 4000);
            SquaresArray[7] = new Square("Chans");
            SquaresArray[10] = new Square("Fängelse");
            SquaresArray[17] = new Square("Allmänning");
            SquaresArray[20] = new Square("Fri parkering");
            SquaresArray[22] = new Square("Chans");
            SquaresArray[30] = new Square("Gå i fängelse");
            SquaresArray[33] = new Square("Allmänning");
            SquaresArray[36] = new Square("Chans");
            SquaresArray[38] = new Square("Lyxskatt", 2000);


        }

        public void InstantiateStreets() /* Instantiate all squares that are streets. */
        {
            SquaresArray[1] = new Street("Västerlångatan", 1200, 0);
            SquaresArray[3] = new Street("Hornsgatan", 1200, 0);

            SquaresArray[6] = new Street("Folkungagatan", 2000, 1);
            SquaresArray[8] = new Street("Götgatan", 2000, 1);
            SquaresArray[9] = new Street("Ringvägen", 2400, 1);

            SquaresArray[11] = new Street("S:t Eriksgatan", 2800, 2);
            SquaresArray[13] = new Street("Odengatan", 2800, 2);
            SquaresArray[14] = new Street("Valhallavägen", 3200, 2);

            SquaresArray[16] = new Street("Sturegatan", 3600, 3);
            SquaresArray[18] = new Street("Karlavägen", 3600, 3);
            SquaresArray[19] = new Street("Narvavägen", 4000, 3);

            SquaresArray[21] = new Street("Strandvägen", 4400, 4);
            SquaresArray[23] = new Street("Kungsträdgårdsgatan", 4400, 4);
            SquaresArray[24] = new Street("Hamngatan", 4800, 4);

            SquaresArray[26] = new Street("Vasagatan", 5200, 5);
            SquaresArray[27] = new Street("Kungsgatan", 5200, 5);
            SquaresArray[29] = new Street("Stureplan", 5600, 5);

            SquaresArray[31] = new Street("Gustav Adolfs torg", 6000, 6);
            SquaresArray[32] = new Street("Drottninggatan", 6000, 6);
            SquaresArray[34] = new Street("Diplomatstaden", 6400, 6);

            SquaresArray[37] = new Street("Centrum", 7000, 7);
            SquaresArray[39] = new Street("Norrmalmstorg", 8000, 7);
        }

        public void InstantiateStations() /* Instantiate all squares that are stations */
        {
            SquaresArray[5] = new Station("Södra station", 4000, 8);
            SquaresArray[15] = new Station("Östra station", 4000, 8);
            SquaresArray[25] = new Station("Centralstation", 4000, 8);
            SquaresArray[35] = new Station("Norra station", 4000, 8);
        }

        public void InstantiatePowerStations()/* Instantiate all squares that are powerstations */
        {
            SquaresArray[12] = new PowerStation("Elverket", 3000, 9);
            SquaresArray[28] = new PowerStation("Vattenledningsverket", 3000, 9);
        }

        /* Allow command line to be seen during normal execution */
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnTurn_Click(object sender, EventArgs e) /*To turn dices*/
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);                             //Skapar slumpgeneratorerna                           
            int dice2 = random.Next(1, 7);                              //sätter ett nummer mellan 1 och 6.
            int result = dice1 + dice2;                                 //räknar ihop tärningarna

            if (dice1 == dice2)
            {
                diceEqualCount++;
            }
            else
            {
                diceEqualCount = 0;
            }

            if (diceEqualCount == 3)
            {
                Player[activePlayer].MoveToJail();
            }

            lbldice1.Text = Convert.ToString(dice1);
            lbldice2.Text = Convert.ToString(dice2);
            lblresult.Text = Convert.ToString(result);

            MovePlayer(result);

        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            New_game newGame = new New_game();

            if (newGame.ShowDialog() == DialogResult.OK)
            {
               //Player = newGame.GetPlayers();
            }
        }
        public void TaxActivePlayer()
        {
            int positionprice = SquaresArray[Player[activePlayer].GetPosition()].GetPrice();
            Player[activePlayer].SubtractMoney(positionprice);
            Freepark.AddMoney(positionprice);
        }
        //TEST
    }
}
