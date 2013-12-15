using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class frmMonopoly : Form
    {
        public GFX GEngine; /* GFX engine */
        public PlayerClass[] Player = new PlayerClass[4]; /* Players */
        public Square[] SquaresArray = new Square[40];
        public ChanceCards[] Chances = new ChanceCards[16];
        public CommunityCards[] ComCard = new CommunityCards[16];
        public BindingList<Square> Squares;
        public FreeParking Freepark = new FreeParking();

        int paces = 0;
        const int PACES_PER_SQUARE = 6;
        const int PX_PER_PACE = 9;
        public int activePlayer = new Random().Next(0, 4);
        int diceEqualCount = 0;
        int chanceCard = 0, comCard = 0;

        public frmMonopoly()
        {
            InitializeComponent();

            AllocConsole(); // Show console.

            InstantiateSquares();
            InstantiateStreets();
            InstantiateStations();
            InstantiatePowerStations();
            InstantiateChanceCards();
            InstantiateCommunityCards();

            Squares = new BindingList<Square>(SquaresArray);
        }

        private void Monopoly_Load(object sender, EventArgs e) /* Monopoply loads, start new game. */
        {
            New_game newGame = new New_game();

            if (newGame.ShowDialog() == DialogResult.OK)
            {
                Player = newGame.GetPlayers();
                NextPlayer();
                HideInactivePlayers();
            }
            else
                Application.Exit();


        }

        private void pnlMainPanel_Paint(object sender, PaintEventArgs e) /* Paint monopoly board using GFX engine. */
        {
            Graphics panelToPaint = pnlMainPanel.CreateGraphics();
            GEngine = new GFX(panelToPaint);
        }

        /* Functions to animate and move player */
        #region MovePlayer functions

        public void MovePlayer(int steps) /* Move active player the specified number of steps. */
        {
            Player[activePlayer].MoveForward(steps);
            tmrMovePlayer.Start();
        }

        private void tmrMovePlayer_Tick(object sender, EventArgs e) /* Move player until its remaining steps = 0. */
        {
            MoveActivePlayer();
        }

        public void MoveActivePlayer() /* Move the active player. */
        {
            if (paces < PACES_PER_SQUARE) /* Move the player 16px five times for every square. */
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

            if (!Player[activePlayer].TakeStep())
            {
                tmrMovePlayer.Stop();

                if (diceEqualCount == 0)
                {
                    btnNextPlayer.Enabled = true;
                }
                else
                {
                    btnRollDices.Enabled = true;
                }


                Console.WriteLine(picPlayer2.Location.X + " - " + picPlayer2.Location.Y);

                ShowSquareInfo();
                RunSquareEvent();

                Console.WriteLine("Active player: {0}", activePlayer);
            }
        }

        public void MoveActivePlayerToJail()
        {
            int x = 30;
            int y = 570;
            if (activePlayer == 0)
            {
                picPlayer0.Location = new Point(x, y);
            }
            else if (activePlayer == 1)
            {
                picPlayer1.Location = new Point(x, y + 26);
            }
            else if (activePlayer == 2)
            {
                picPlayer2.Location = new Point(x + 26, y);
            }
            else if (activePlayer == 3)
            {
                picPlayer3.Location = new Point(x + 26, y + 26);
            }

            Player[activePlayer].MoveToJail();
        }

        private void MovePlayer0() /* Move player 0 one pace. */
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

        private void MovePlayer1() /* Move player 1 one pace. */
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

        private void MovePlayer2() /* Move player 2 one pace. */
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

        private void MovePlayer3() /* Move player 3 one pace. */
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

        #endregion

        /* Instantiate squares, streets, stations and PowerStations */
        #region Square instantiation

        public void InstantiateSquares() /* Instantiate all squares that are just squares. */
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

        public void InstantiateStations() /* Instantiate all squares that are stations. */
        {
            SquaresArray[5] = new Station("Södra station", 4000, 8);
            SquaresArray[15] = new Station("Östra station", 4000, 8);
            SquaresArray[25] = new Station("Centralstation", 4000, 8);
            SquaresArray[35] = new Station("Norra station", 4000, 8);
        }

        public void InstantiatePowerStations()/* Instantiate all squares that are powerstations. */
        {
            SquaresArray[12] = new PowerStation("Elverket", 3000, 9);
            SquaresArray[28] = new PowerStation("Vattenledningsverket", 3000, 9);
        }

        #endregion

        #region Cards instantiation

        public void InstantiateChanceCards()
        {
            Chances[0] = new ChanceCards("Gå vidare till Hamngatan.", 0,false, 24);
            Chances[1] = new ChanceCards("Gå till fängelset.", 0, false, -1);
            Chances[2] = new ChanceCards("Du kommer ut ur fängelset.", 0, true);
            Chances[3] = new ChanceCards("Du vann i en skönhetstävling, inkassera 2000 kr.", 2000);
            Chances[4] = new ChanceCards("Gå vidare till Gå.", 0, false, 0);
            Chances[5] = new ChanceCards("Gå vidare till S:t Eriksgatan", 0, false, 11);
            Chances[6] = new ChanceCards("Betala parkeringsbörter 150 kr", -150);
            Chances[7] = new ChanceCards("Banken har räknat fel, inkassera 2000", 2000);
            Chances[8] = new ChanceCards("Du kommer ut ur fängelset", 0, true);
            Chances[9] = new ChanceCards("Du vann i en skönhetstävling, inkassera 2000 kr", 2000);
            Chances[10] = new ChanceCards("Gå till fängelse", 0, false, -1);
            Chances[11] = new ChanceCards("Du kommer ut ur fängelset", 0, true);
            Chances[12] = new ChanceCards("Du vann i en skönhetstävling, inkassera 2000 kr", 2000);
            Chances[13] = new ChanceCards("Gå till fängelse", 0, false, -1);
            Chances[14] = new ChanceCards("Du kommer ut ur fängelset", 0, true);
            Chances[15] = new ChanceCards("Du kommer ut ur fängelset", 0, true);
        }

        public void InstantiateCommunityCards()
        {
            ComCard[0] = new CommunityCards("Hej", 0);
            ComCard[1] = new CommunityCards("Hej", 0);
            ComCard[2] = new CommunityCards("Hej", 0);
            ComCard[3] = new CommunityCards("Hej", 0);
            ComCard[4] = new CommunityCards("Hej", 0);
            ComCard[5] = new CommunityCards("Hej", 0);
            ComCard[6] = new CommunityCards("Hej", 0);
            ComCard[7] = new CommunityCards("Hej", 0);
            ComCard[8] = new CommunityCards("Hej", 0);
            ComCard[9] = new CommunityCards("Hej", 0);
            ComCard[10] = new CommunityCards("Hej", 0);
            ComCard[11] = new CommunityCards("Hej", 0);
            ComCard[12] = new CommunityCards("Hej", 0);
            ComCard[13] = new CommunityCards("Hej", 0);
            ComCard[14] = new CommunityCards("Hej", 0);
            ComCard[15] = new CommunityCards("Hej", 0);
        }

        #endregion

        /* All button event handlers for frmMonopoly goes here */
        #region Button event handlers

        private void btnQuit_Click(object sender, EventArgs e) /* Make sure user really wants to quit. */
        {
            if (MessageBox.Show("Quit monopoly", "Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTest_Click(object sender, EventArgs e) /* Use this function to test anything, remove before release. */
        {
            ((Street)Squares[1]).ChangeOwner(0);
            ((Street)Squares[3]).ChangeOwner(0);
            ((Street)Squares[6]).ChangeOwner(0);
            ((Street)Squares[8]).ChangeOwner(1);
            ((Street)Squares[9]).ChangeOwner(1);
            ((Street)Squares[11]).ChangeOwner(1);
            ((Street)Squares[13]).ChangeOwner(2);
            ((Street)Squares[14]).ChangeOwner(2);
            ((Street)Squares[16]).ChangeOwner(2);
            ((Street)Squares[18]).ChangeOwner(3);
            ((Street)Squares[19]).ChangeOwner(3);
            ((Street)Squares[21]).ChangeOwner(3);
            // Player[0].SetMoney(500);
            // Player[1].SetMoney(600);
            // Player[2].SetMoney(700);
            // Player[3].SetMoney(800);

            MoveActivePlayerToJail();
        }

        private void btnTurn_Click(object sender, EventArgs e) /* Roll dices and move active player. */
        {
            btnRollDices.Enabled = false;

            Color formColor = this.BackColor;
            Color doubleDiceColor = Color.LawnGreen;

            if (tmrMovePlayer.Enabled) /* No cheating */
                return;

            Random random = new Random(); //Skapar slumpgeneratorerna
            int dice1 = random.Next(1, 7); //sätter ett nummer mellan 1 och 6.
            int dice2 = random.Next(1, 7); //sätter ett nummer mellan 1 och 6.
            int result = dice1 + dice2; //räknar ihop tärningarna

            lblDice1.Text = Convert.ToString(dice1);
            lblDice2.Text = Convert.ToString(dice2);
            lblTotal.Text = Convert.ToString(result);

            if (dice1 == dice2)
            {
                diceEqualCount++;

                lblDice1.BackColor = doubleDiceColor;
                lblDice2.BackColor = doubleDiceColor;

                if (Player[activePlayer].IsInJail())
                {
                    Player[activePlayer].GetOutOfJail();
                }
            }
            else
            {
                diceEqualCount = 0;

                lblDice1.BackColor = formColor;
                lblDice2.BackColor = formColor;

                if (Player[activePlayer].IsInJail())
                {
                    btnNextPlayer.Enabled = true;
                    return;
                }
            }

            if (diceEqualCount == 3)
            {
                MoveActivePlayerToJail();
                return;
            }

            MovePlayer(result);

        }

        private void btnTrade_Click(object sender, EventArgs e) /* Open trade window. */
        {
            Trade TradeForm = new Trade();
            TradeForm.board = this;
            TradeForm.ShowDialog();
        }

        private void btnNextPlayer_Click(object sender, EventArgs e) /* Set activePlayer to the next one avaliable. */
        {
            btnRollDices.Enabled = true;
            btnNextPlayer.Enabled = false;
            btnBuyStreet.Hide();
            NextPlayer();
        }

        #endregion

        public void HideInactivePlayers() /* Hide players that are not in the game. */
        {
            if (Player[3].GetName() == "")
            {
                picPlayer3.Hide();
            }

            if (Player[2].GetName() == "")
            {
                picPlayer2.Hide();
            }
        }

        public void NextPlayer() /* Change activePlayer to next player. */
        {
            if (diceEqualCount == 0)
            {
                activePlayer++;
            }

            if (activePlayer > 3 || Player[activePlayer].GetName() == "")
            {
                activePlayer = 0;
            }
        }

        public void RunSquareEvent() /* Checks what kind of square the player landed on and acts accordingly. */
        {
            int position = Player[activePlayer].GetPosition();
            int owner = 0;

            try
            {
                owner = ((Station)Squares[position]).GetOwner();
            }
            catch (InvalidCastException)
            {
                // Ingen ägare, alltså Square.
            }

            Type squareType = Squares[position].GetType();

            if (squareType == typeof(Street))
            {
                if (owner == 5)
                {
                    btnBuyStreet.Show();
                }
                else if(owner != activePlayer)
                {
                    int rent = ((Street)Squares[position]).GetRent();
                    Player[activePlayer].SubtractMoney(rent);
                }
            }
            else if (squareType == typeof(Square))
            {
                if (position == 4 || position == 38)
                {
                    TaxActivePlayer();
                }

                else if (position == 20)
                {
                    Player[activePlayer].AddMoney(Freepark.TakeMoney());
                }

                else if (position == 30)
                {
                    MoveActivePlayerToJail();
                }
                else if (position == 7 || position == 22 || position == 36)
                {
                    MessageBox.Show(Chances[chanceCard].GetText());
                    if (chanceCard <= 15)
                        chanceCard = 0;
                    else
                        chanceCard++;
                }
                else if (position == 2 || position == 17 || position == 33)
                {
                    MessageBox.Show(ComCard[comCard].GetText());
                    if (comCard <= 15)
                        comCard = 0;
                    else
                        comCard++;
                }
            }
            else if (squareType == typeof(Station))
            {
                if (owner == 5)
                {
                    btnBuyStreet.Show();
                }
                else if (owner != activePlayer)
                {
                    int strent = ((Station)Squares[position]).GetRent();
                    Player[activePlayer].SubtractMoney(strent);
                }
            }
            else if (squareType == typeof(PowerStation))
            {
                if (owner == 5)
                {
                    btnBuyStreet.Show();
                }
                else if (owner != activePlayer)
                {
                    int psrent = ((PowerStation)Squares[position]).GetRent();
                    Player[activePlayer].SubtractMoney(psrent);
                }
            }
        }

        public void ShowSquareInfo() /* Show the squares info in lblSquareInfo. */
        {
            string info = "";
            string ownerName = "";
            int activePosition = Player[activePlayer].GetPosition();

            if (Squares[activePosition].GetType() == typeof(Street))
            {
                if (((Street)Squares[activePosition]).GetOwner() != 5 && Player[((Street)Squares[activePosition]).GetOwner()].GetName() != "")
                {
                    ownerName = "\nÄgare: " + Player[((Street)Squares[activePosition]).GetOwner()].GetName();
                }
                info = ((Street)Squares[activePosition]).GetInfo() + ownerName;
            }
            else if (Squares[activePosition].GetType() == typeof(Square))
            {
                info = ((Square)Squares[activePosition]).GetInfo();
            }
            else if (Squares[activePosition].GetType() == typeof(Station))
            {
                if (((Station)Squares[activePosition]).GetOwner() != 5 && Player[((Station)Squares[activePosition]).GetOwner()].GetName() != "")
                {
                    ownerName = "\nÄgare: " + Player[((Station)Squares[activePosition]).GetOwner()].GetName();
                }
                info = ((Station)Squares[activePosition]).GetInfo() + ownerName;
            }
            else if (Squares[activePosition].GetType() == typeof(PowerStation))
            {
                if (((PowerStation)Squares[activePosition]).GetOwner() != 5 && Player[((PowerStation)Squares[activePosition]).GetOwner()].GetName() != "")
                {
                    ownerName = "\nÄgare: " + Player[((PowerStation)Squares[activePosition]).GetOwner()].GetName();
                }
                info = ((PowerStation)Squares[activePosition]).GetInfo() + ownerName;
            }
            
            lblSquareInfo.Text = info;
        }

        public void TaxActivePlayer() /* Tax the active player and subtract the appropriate amount. */
        {
            int positionprice = SquaresArray[Player[activePlayer].GetPosition()].GetPrice();

            Player[activePlayer].SubtractMoney(positionprice);
            Freepark.AddMoney(positionprice);
            UpdateFreeParkValue();
        }

        public void UpdatePlayerInfo() /* Updates the on-screen info about the players. */
        {
            /*
             * Uppdatera information om alla spelare.
             * Visa:
             *  Namn
             *  Pengar
             *  Ägda gator (Visa vilka som tillhör samma kvarter)
             *  I fängelse
             */
        }

        private void btnBuyHouses_Click(object sender, EventArgs e) // Hjälp mig inne i formen
        {
            BuyHouse BHF = new BuyHouse();
            BHF.board = this;
            BHF.ShowDialog();
        }



        /* Allow command line to be seen during normal execution */
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnBuyStreet_Click(object sender, EventArgs e)
        {
            int playerMoney = Player[activePlayer].GetMoney();
            int position = Player[activePlayer].GetPosition();
            int streetPrice = Squares[position].GetPrice();
            string streetName = Squares[position].GetName();
            if (playerMoney < streetPrice)
            {
                MessageBox.Show("Du har inte råd att köpa denna gatan");
            }
            else
            {
                string prompt = "Vill du köpa " + streetName + " för " + streetPrice + " kr\nDu har "+ playerMoney+ " kr";
                if (MessageBox.Show(prompt, "Köpa gata", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Type squareType = Squares[position].GetType();

                    if (squareType == typeof(Street))
                    {
                    ((Street)Squares[position]).ChangeOwner(activePlayer);
                    }
                    else if (squareType == typeof(Station))
                    {
                        ((Station)Squares[position]).ChangeOwner(activePlayer);
                    }
                    else if (squareType == typeof(PowerStation))
                    {
                        ((PowerStation)Squares[position]).ChangeOwner(activePlayer);
                    }

                    
                    Player[activePlayer].SubtractMoney(streetPrice);
                    btnBuyStreet.Hide();
                    ShowSquareInfo();
                }   
                
            }
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            sfdSaveGame.ShowDialog();
        }


        private void UpdateFreeParkValue()
        {
            lblFreePark.Text = Freepark.GetValue().ToString();
        }
    }
}
