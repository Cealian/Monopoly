using System;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class BuildHouses : Form
    {
        public frmMonopoly board;
        public BuildHouses()
        {
            InitializeComponent();
        }

        private void SellStreet_Load(object sender, EventArgs e)
        {
            UpdateSquares();
            if (lbStreets.Items.Count > 0)
            {
                lbStreets.SetSelected(0, true);
                UpdateInfo();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sell();
            UpdateInfo();
        }

        private void UpdateSquares()
        {
            lbInfo.Text = "";
            lbStreets.Items.Clear();
            int player = board.activePlayer;
            foreach (Square square in board.SquaresArray)
            {
                if (square.GetType() == typeof(Street) && ((Street)square).GetOwner() == player)
                {
                    lbStreets.Items.Add(((Street)square).GetName());
                }
                else if (square.GetType() == typeof(Station) && ((Station)square).GetOwner() == player)
                {
                    lbStreets.Items.Add(((Station)square).GetName());
                }
                else if (square.GetType() == typeof(PowerStation) && ((PowerStation)square).GetOwner() == player)
                {
                    lbStreets.Items.Add(((PowerStation)square).GetName());
                }
            }
        }

        private void UpdateInfo()
        {
            string info = "";
            int block = 10;
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                string name = board.SquaresArray[i].GetName();
                Type squareType = board.SquaresArray[i].GetType();
                if (lbStreets.SelectedItem.ToString() == name && squareType == typeof(Street))
                {
                    if (((Street)board.SquaresArray[i]).GetNoOfHouses() > 0)
                        btnSellHouse.Enabled = true;
                    else
                        btnSellHouse.Enabled = false;

                    if (((Street)board.SquaresArray[i]).GetMortgaged())
                        btnMortgage.Text = "Lös ut";
                    else
                        btnMortgage.Text = "Inteckna";
                    block = ((Street)board.SquaresArray[i]).GetBlock();
                    if (((Street)board.SquaresArray[i]).GetNoOfHouses() == 5)
                        info = ((Street)board.SquaresArray[i]).GetInfo() + "\nEtt Hotell";
                    else
                        info = ((Street)board.SquaresArray[i]).GetInfo() + "\nAntal hus: " + ((Street)board.SquaresArray[i]).GetNoOfHouses();
                }
                else if (lbStreets.SelectedItem.ToString() == name && squareType == typeof(Station))
                {
                    btnBuyHouse.Enabled = false;
                    btnSellHouse.Enabled = false;
                    if (((Station)board.SquaresArray[i]).GetMortgaged())
                        btnMortgage.Text = "Lös ut";
                    else
                        btnMortgage.Text = "Inteckna";
                    info = ((Station)board.SquaresArray[i]).GetInfo();
                }
                else if (lbStreets.SelectedItem.ToString() == name && squareType == typeof(PowerStation))
                {
                    btnBuyHouse.Enabled = false;
                    btnSellHouse.Enabled = false;
                    if (((PowerStation)board.SquaresArray[i]).GetMortgaged())
                        btnMortgage.Text = "Lös ut";
                    else
                        btnMortgage.Text = "Inteckna";
                    info = ((PowerStation)board.SquaresArray[i]).GetInfo();
                }
            }
            lbInfo.Text = info;
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                Type squareType = board.SquaresArray[i].GetType();
                if (squareType == typeof(Street) && ((Street)board.SquaresArray[i]).GetBlock() == block)
                {
                    Street street = ((Street)board.SquaresArray[i]);
                    if (street.GetOwner() == board.activePlayer && street.GetNoOfHouses() < 5)
                        btnBuyHouse.Enabled = true;
                    else
                    {
                        btnBuyHouse.Enabled = false;
                        break;
                    }
                }
            }
            board.ShowSquareInfo();
            board.UpdatePlayerInfo();
        }

        private void Sell()
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                Square sellSquare = board.SquaresArray[i];

                if (lbStreets.SelectedItem.ToString() == sellSquare.GetName())
                {
                    if (sellSquare.GetType() == typeof(Street))
                    {
                        if (((Street)sellSquare).GetMortgaged())
                        {
                            ((Street)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].SubtractMoney(((Street)sellSquare).GetMortgagePrice());
                        }
                        else
                        {
                            ((Street)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].AddMoney(((Street)sellSquare).GetMortgagePrice());
                        }
                    }
                    else if (sellSquare.GetType() == typeof(Station))
                    {
                        if (((Station)sellSquare).GetMortgaged())
                        {
                            ((Station)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].SubtractMoney(((Station)sellSquare).GetMortgagePrice());
                        }
                        else
                        {
                            ((Station)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].AddMoney(((Station)sellSquare).GetMortgagePrice());
                        }
                    }
                    else if (sellSquare.GetType() == typeof(PowerStation))
                    {
                        if (((PowerStation)sellSquare).GetMortgaged())
                        {
                            ((PowerStation)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].SubtractMoney(((PowerStation)sellSquare).GetMortgagePrice());
                        }
                        else
                        {
                            ((PowerStation)sellSquare).ToggleMortage();
                            board.Player[board.activePlayer].AddMoney(((PowerStation)sellSquare).GetMortgagePrice());
                        }
                    }
                }

            }
        }

        private void lbStreets_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void btnBuyHouse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                Type streetType = board.SquaresArray[i].GetType();
                if (streetType == typeof(Street))
                {
                    Street street = ((Street)board.SquaresArray[i]);
                    if (lbStreets.SelectedItem.ToString() == street.GetName())
                    {
                        street.BuildHouse();
                        board.Player[board.activePlayer].SubtractMoney(street.GetHousePrice());
                    }
                }
            }
            UpdateInfo();
        }

        private void btnSellHouse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                Type streetType = board.SquaresArray[i].GetType();
                if (streetType == typeof(Street))
                {
                    Street street = ((Street)board.SquaresArray[i]);
                    if (lbStreets.SelectedItem.ToString() == street.GetName())
                    {
                        street.SellHouse();
                        board.Player[board.activePlayer].AddMoney(street.GetSellHousePrice());
                    }
                }
            }
            UpdateInfo();
        }
    }
}
