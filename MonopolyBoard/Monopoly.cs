using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Text;

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
        int ply1turnsInJail = 0; 
        int ply2turnsInJail = 0;
        int ply3turnsInJail = 0;
        int ply4turnsInJail = 0;
        int chanceCard = new Random().Next(0, 16), comCard = new Random().Next(0, 16);

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

            UpdatePlayerInfo();

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
                UpdatePlayerInfo();

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
            UpdatePlayerInfo();
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

        /* Instantiation of all chance and community cards */
        #region Cards instantiation

        public void InstantiateChanceCards()
        {
            Chances[0] = new ChanceCards("Betala skolavgifter 3000 kr.", -3000);
            Chances[1] = new ChanceCards("Gå i fängelset! Gå direkt till fängelset utan att passera Gå.", 0, false, -1);
            Chances[2] = new ChanceCards("Ta en tripp till Östra station och om ni passerar Gå så inkassera 4000 kr.", 0, false, 15);
            Chances[3] = new ChanceCards("Betala böter för fortkörningsböter, 300 kr", -300);
            Chances[4] = new ChanceCards("Gå vidare till Gå.", 0, false, 0);
            Chances[5] = new ChanceCards("Gå vidare till Hamngatan. Om ni passerar Gå så inkassera 4000 kr.", 0, false, 24);
            Chances[6] = new ChanceCards("Ni lyfter sparkasseräntan från banken, inkassera 1000 kr", 1000);
            Chances[7] = new ChanceCards("Gå vidare till Norrmalmstorg.", 0, false, 39);
            Chances[8] = new ChanceCards("Gå vidare till S:t Eriksgatan. Om ni passerar Gå så inkassera 4000 kr", 0, false, 11);
            Chances[9] = new ChanceCards("Utbetalning på ert byggnadslån, inkassera 3000 kr", 3000);
            Chances[10] = new ChanceCards("Ni har vunnit en korsordstävling, inkassera 2000 kr", 2000);
            Chances[11] = new ChanceCards("Ni slipper ut ur fängelset, detta kort får behålla tills det används eller säljs.", 0, true);
            Chances[12] = new ChanceCards("Du vann i en skönhetstävling, inkassera 2000 kr", 2000);
            Chances[13] = new ChanceCards("Du fyller år, inkassera 200 kr från varje motspelare.", 200, false, -2);
            Chances[14] = new ChanceCards("Oförstånd i ämbetet, böta 400 kr", -400, false, 0);
            Chances[15] = new ChanceCards("Betala trängselskatt, betala 200 kr", -200);
        }

        public void InstantiateCommunityCards()
        {
            ComCard[0] = new CommunityCards("Gå vidare till Gå.", 0, false, 0);
            ComCard[1] = new CommunityCards("Betala sjukhusräkning, 2000 kr.", -2000);
            ComCard[2] = new CommunityCards("Ni slipper ut ur fängelset, detta kort får sparas tills det används eller säljs.", 0, true);
            ComCard[3] = new CommunityCards("Livsräntan förfaller, inkassera 2000.", 2000);
            ComCard[4] = new CommunityCards("Betala försäkringspremie 1000 kr.", -1000);
            ComCard[5] = new CommunityCards("Det är din födelsedag, inkassera 200 kr från varje motspelare.", 200, false, -2);
            ComCard[6] = new CommunityCards("Ni ärver 2000 kr.", 2000);
            ComCard[7] = new CommunityCards("Felräkning i banken till er favör, inkassera 4000 kr.", 4000);
            ComCard[8] = new CommunityCards("Läkararvode, betala 1000 kr.", -1000);
            ComCard[9] = new CommunityCards("Gå till Västerlånggatan, om ni passerar Gå så inkassera 4000 kr.", 0, false, 1);
            ComCard[10] = new CommunityCards("Återbäring av skatt, inkassera 400 kr.", 400);
            ComCard[11] = new CommunityCards("Utdelning på 7% preferensaktier, inkassera 500 kr.", 500);
            ComCard[12] = new CommunityCards("Likvid för försålda aktier, inkassera 1000 kr", 1000);
            ComCard[13] = new CommunityCards("Ni har vunnit andra pris i en skönhetstävling, inkassera 200 kr", 200);
            ComCard[14] = new CommunityCards("Gå i fängelse! Gå direkt till fängelset utan att passera Gå.", 0, false, -1);
            ComCard[15] = new CommunityCards("Gå till friparkering.", 0, false, 20);
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
            //((Street)Squares[1]).ChangeOwner(0);
            //((Street)Squares[3]).ChangeOwner(0);
            //((Street)Squares[6]).ChangeOwner(0);
            //((Station)Squares[5]).ChangeOwner(0);
            //((Station)Squares[15]).ChangeOwner(0);
            //((PowerStation)Squares[12]).ChangeOwner(0);
            //((Street)Squares[8]).ChangeOwner(1);
            //((Street)Squares[9]).ChangeOwner(1);
            //((Street)Squares[11]).ChangeOwner(1);
            //((Street)Squares[13]).ChangeOwner(2);
            //((Street)Squares[14]).ChangeOwner(2);
            //((Street)Squares[16]).ChangeOwner(2);
            //((Street)Squares[18]).ChangeOwner(3);
            //((Street)Squares[19]).ChangeOwner(3);
            //((Street)Squares[21]).ChangeOwner(3);
            //Player[0].SetMoney(500);
            //Player[1].SetMoney(600);
            //Player[2].SetMoney(700);
            //Player[3].SetMoney(800);
            ((Street)Squares[1]).ChangeOwner(0);
            ((Street)Squares[3]).ChangeOwner(0);
            ((Street)Squares[6]).ChangeOwner(0);
            ((Station)Squares[5]).ChangeOwner(0);
            ((Station)Squares[15]).ChangeOwner(0);
            ((PowerStation)Squares[12]).ChangeOwner(0);
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
            //MovePlayer(7);
            MoveActivePlayerToJail();

            UpdatePlayerInfo();
            //UpdatePlayerInfo();
            //GEngine.UpdateOwner(1, 2);
            //GEngine.UpdateOwner(5, 2);
            //GEngine.UpdateOwner(6, 2);
            //GEngine.UpdateOwner(13, 2);
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

            UpdatePlayerInfo();

        }

        private void btnTrade_Click(object sender, EventArgs e) /* Open trade window. */
        {
            Trade TradeForm = new Trade();
            TradeForm.board = this;
            TradeForm.ShowDialog();

            UpdatePlayerInfo();
        }

        private void btnNextPlayer_Click(object sender, EventArgs e) /* Set activePlayer to the next one avaliable. */
        {
            btnRollDices.Enabled = true;
            btnNextPlayer.Enabled = false;
            btnBuyStreet.Hide();
            NextPlayer();
            UpdatePlayerInfo();
            if (Player[activePlayer].IsInJail() == true)
            JailCount();
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
            catch (InvalidCastException) /* No GetOwner() function, it's a Square. */
            {
                if (position == 4 || position == 38) /* It's a tax square */
                {
                    MessageBox.Show("Skatt " + Squares[position].GetPrice() + " kr.");
                    TaxActivePlayer();
                }

                else if (position == 20) /* Free parking, money! */
                {
                    MessageBox.Show("Fri parkering!\nDu får " + Freepark.GetValue() + " kr.");
                    Player[activePlayer].AddMoney(Freepark.TakeMoney());
                }

                else if (position == 30) /* It's jailtime for you boy! */
                {
                    MessageBox.Show("Du får stå i fängelse tills du slår jämnt.");
                    MoveActivePlayerToJail();
                }
                else if (position == 7 || position == 22 || position == 36) /* Take a chance card and hope for something good. */
                {

                    ChanceCards card = Chances[chanceCard];
                    card.board = this;

                    MessageBox.Show(card.GetText());

                    if (card.GetJailCard())
                    {
                        card.GiveJailCard();
                    }
                    else if (card.GetPosition() == -1)
                    {
                        card.GoToJail();
                    }
                    else if (card.GetPosition() == -2)
                    {
                        card.GetMoneyFromAll();
                    }
                    else if (card.GetValue() == 0)
                    {
                        card.ChangePosition(Player[activePlayer].GetPosition());
                    }
                    else
                    {
                        card.GetOrPay();
                    }

                    if (chanceCard >= 15)
                    {
                        chanceCard = 0;
                    }
                    else
                    {
                        chanceCard++;
                    }
                }
                else if (position == 2 || position == 17 || position == 33) /* Take a community card and hope for something good. */
                {
                    CommunityCards card = ComCard[comCard];
                    card.board = this;

                    MessageBox.Show(card.GetText());

                    if (card.GetJailCard())
                    {
                        card.GiveJailCard();
                    }
                    else if (card.GetPosition() == -1)
                    {
                        card.GoToJail();
                    }
                    else if (card.GetPosition() == -2)
                    {
                        card.GetMoneyFromAll();
                    }
                    else if (card.GetValue() == 0)
                    {
                        card.ChangePosition(Player[activePlayer].GetPosition());
                    }
                    else
                    {
                        card.GetOrPay();
                    }

                    if (comCard >= 15)
                    {
                        comCard = 0;
                    }
                    else
                    {
                        comCard++;
                    }
                }
                return;
            }

            Type squareType = Squares[position].GetType();
            int rent = 0;
            bool isMortgaged = false;

            if (owner == activePlayer)
            {
                return;
            }

            if (squareType == typeof(Street))
            {
                if (owner == 5)
                {
                    btnBuyStreet.Show();
                    return;
                }
                isMortgaged = ((Street)Squares[position]).GetMortgaged();
                rent = ((Street)Squares[position]).GetRent();
            }
            else if (squareType == typeof(Station))
            {
                if (owner == 5)
                {

                    btnBuyStreet.Show();
                    return;
                }
                isMortgaged = ((Station)Squares[position]).GetMortgaged();
                rent = ((Station)Squares[position]).GetRent();
            }
            else if (squareType == typeof(PowerStation))
            {
                if (owner == 5)
                {
                    btnBuyStreet.Show();
                    return;
                }
                isMortgaged = ((PowerStation)Squares[position]).GetMortgaged();
                rent = ((PowerStation)Squares[position]).GetRent();
            }


            if (isMortgaged)
            {
                MessageBox.Show("Du hamnade på " + Squares[position].GetName() + "\nInteknad.");
                return;
            }
            MessageBox.Show("Du hamnade på " + Squares[position].GetName() + "\nHyra: " + rent + " betalas till " + Player[owner].GetName());
            Player[activePlayer].SubtractMoney(rent);
            Player[owner].AddMoney(rent);

            UpdatePlayerInfo();
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

            UpdatePlayerInfo();
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
            
            string playerInfo, player1Info, player2Info, player3Info, player4Info;

            player1Info = Player[0].GetName() + ": " + Player[0].GetMoney();
            player2Info = Player[1].GetName() + ": " + Player[1].GetMoney();
            player3Info = "";
            player4Info = "";       
            
            playerInfo = Player[0].GetName() + ": " + Player[0].GetMoney() + "\n";
            playerInfo += Player[1].GetName() + ": " + Player[1].GetMoney() + "\n";
      

            if (Player[2].GetName() != "")
            {
                playerInfo += Player[2].GetName() + ": " + Player[2].GetMoney() + "\n";
                player3Info = Player[2].GetName() + ": " + Player[2].GetMoney() + "kr";
            }

            if (Player[3].GetName() != "")
            {
                playerInfo += Player[3].GetName() + ": " + Player[3].GetMoney() + "\n";
                player4Info = Player[3].GetName() + ": " + Player[3].GetMoney() + "kr";
            }

            lblPlayerInfo.Text = Player[activePlayer].GetName() + "\n" + playerInfo;
            lblPlayerInfo.ForeColor = GetPlayerColor(activePlayer);
            lblply1Info.ForeColor = GetPlayerColor(0);
            lblply2Inf.ForeColor = GetPlayerColor(1);
            lblply3Info.ForeColor = GetPlayerColor(2);
            lblply4Info.ForeColor = GetPlayerColor(3);
            lblply1Info.Text = player1Info + "kr";
            lblply2Inf.Text = player2Info + "kr";
            lblply3Info.Text = player3Info;
            lblply4Info.Text = player4Info;

            if (Player[0].IsInJail() == true)
            {
                lblply1InJail.Visible = true;
                lblply1NoTurnsInJail.Text = "Antal omgångar:" + ply1turnsInJail;
                lblply1NoTurnsInJail.ForeColor = Color.Red;
                lblply1NoTurnsInJail.Visible = true;
            }
            else
            {
                lblply1InJail.Visible = false;
                lblply1NoTurnsInJail.Visible = false;
            }
                if (Player[1].IsInJail() == true)
                {
                    lblply2InJail.Visible = true;
                    lblply2NoTurnsInJail.Text = "Antal omgångar:" + ply2turnsInJail;
                    lblply2NoTurnsInJail.ForeColor = Color.Red;
                    lblply2NoTurnsInJail.Visible = true;

                }
                else
                {
                    lblply2InJail.Visible = false;
                    lblply2NoTurnsInJail.Visible = false;
                }

                if (Player[2].IsInJail() == true)
                {
                    lblply3InJail.Visible = true;
                    lblply3NoTurnsInJail.Text = "Antal omgångar:" + ply3turnsInJail;
                    lblply3NoTurnsInJail.ForeColor = Color.Red;
                    lblply3NoTurnsInJail.Visible = true;

                }
                else
                {
                    lblply3InJail.Visible = false;
                    lblply3NoTurnsInJail.Visible = false;
                }

                if (Player[3].IsInJail() == true)
                {
                    lblply4InJail.Visible = true;
                    lblply4NoTurnsInJail.Text = "Antal omgångar:" + ply4turnsInJail;
                    lblply4NoTurnsInJail.ForeColor = Color.Red;
                    lblply4NoTurnsInJail.Visible = true;

                }
                else
                {
                    lblply4InJail.Visible = false;
                    lblply4NoTurnsInJail.Visible = false;
                }

            if (Player[activePlayer].IsInJail() == true)
            {
                //for (int turn = 0; turn < 4; turn++)
                //{
                btnJail.Visible = true;
                
                
                /*    if (turn == 3)
                    {
                        MessageBox.Show("Du måste betala 1000 i borgen");
                        Player[activePlayer].SubtractMoney(1000);
                        Player[activePlayer].GetOutOfJail();
                        turn = 0;
                    }
                 */
            }
            else
                btnJail.Visible = false;
                UpdateFreeParkValue();          

            Console.WriteLine(GetPlayerColor(activePlayer).ToString());

            /*
             * Uppdatera information om alla spelare.
             * Visa:
             *  Namn (Ett namn per splare...)
             *  Pengar (Hur många pengar har han?)
             *  Ägda gator (Visa vilka som tillhör samma kvarter) (ELLER?!)
             *  I fängelse (gör det coolt).
             */
        }
        public void JailCount()
        {
            string forcePay = "Du måste betala 1000kr i borgen";


            if (Player[0].IsInJail() == true && Player[activePlayer] == Player[0])
            {
                ply1turnsInJail++;

                if (ply1turnsInJail == 4)
                {
                    MessageBox.Show(forcePay);
                    btnBankrupt.Visible = true;
                    btnNextPlayer.Enabled = false;
                    btnRollDices.Enabled = false;
                }
            }
                if (Player[1].IsInJail() == true && Player[activePlayer] == Player[1])
                {
                    ply2turnsInJail++;
                    if (ply2turnsInJail == 4)
                    {
                        MessageBox.Show(forcePay);
                        btnBankrupt.Visible = true;
                        btnNextPlayer.Enabled = false;
                        btnRollDices.Enabled = false;
                    }
                }

                if (Player[2].IsInJail() == true && Player[activePlayer] == Player[2])
                {
                    ply3turnsInJail++;
                    if (ply3turnsInJail == 4)
                    {
                        MessageBox.Show(forcePay);
                        btnBankrupt.Visible = true;
                        btnNextPlayer.Enabled = false;
                        btnRollDices.Enabled = false;
                    }
                }


                if (Player[3].IsInJail() == true && Player[activePlayer] == Player[3])
                {
                    ply4turnsInJail++;
                    if (ply4turnsInJail == 4)
                    {
                        MessageBox.Show(forcePay);
                        btnBankrupt.Visible = true;
                        btnNextPlayer.Enabled = false;
                        btnRollDices.Enabled = false;
                    }

                }
  
        }
            
        

        private void btnBuyHouses_Click(object sender, EventArgs e)
        {
            BuyHouse BuyHouseForm = new BuyHouse();
            BuyHouseForm.board = this;
            BuyHouseForm.ShowDialog();

            UpdatePlayerInfo();
        }

        private void btnBuyStreet_Click(object sender, EventArgs e)
        {
            int playerMoney = Player[activePlayer].GetMoney();
            int position = Player[activePlayer].GetPosition();
            int streetPrice = Squares[position].GetPrice();
            string streetName = Squares[position].GetName();

            if (playerMoney < streetPrice)
            {
                MessageBox.Show("Du har inte råd att köpa denna gatan");
                return;
            }

            string prompt = "Vill du köpa " + streetName + " för " + streetPrice + " kr\nDu har " + playerMoney + " kr";

            if (MessageBox.Show(prompt, "Köpa gata", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

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

            GEngine.UpdateOwner(position, activePlayer);

        }

        private void btnSaveGame_Click(object sender, EventArgs e) /* Save the current monopoly game to be able to continue later */
        {
            sfdSaveGame.ShowDialog();
            if (sfdSaveGame.FileName != "")
            {
                FileStream fs = (FileStream)sfdSaveGame.OpenFile();

                GameSave newSave = new GameSave(ref fs);
                newSave.Save();

                fs.Close();
            }
        }

        private void UpdateFreeParkValue()
        {
            lblFreePark.Text = Freepark.GetValue().ToString();
        }


        private void btnSellStreet_Click(object sender, EventArgs e)
        {
            BuildHouses sellStreet = new BuildHouses();
            sellStreet.board = this;
            sellStreet.Show();
        }

        public Color GetPlayerColor(int player)
        {
            Color playerColor = Color.Transparent;

            if (player == 0)
            {
                playerColor = Color.Pink;
            }
            else if (player == 1)
            {
                playerColor = Color.Blue;
            }
            else if (player == 2)
            {
                playerColor = Color.Green;
            }
            else if (player == 3)
            {
                playerColor = Color.DarkOrange;
            }

            return playerColor;
        }
        
        private void CheckIfPlayerCantPay()
        {
            if (Player[activePlayer].GetMoney() < 0)
            {
                btnNextPlayer.Enabled = false;
                btnBankrupt.Visible = true;
            }
        }

        /* Allow command line to be seen during normal execution */
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnBankrupt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJail_Click(object sender, EventArgs e)
        {
           /* int plyrMoney = Player[activePlayer].GetMoney(); 
            string forcePay = "Du måste betala 1000 kr för att få komma ut.";
            string noMoney = "Du har inte råd att betala";

            if (MessageBox.Show(forcePay, "nDu har: " + plyrMoney, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (plyrMoney < 1000)
                {
                    MessageBox.Show(noMoney);
                }
                Player[activePlayer].SubtractMoney(1000); */
            }
        }
     
    }
}
