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
            Mortgage();
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
                    Street street = ((Street)board.SquaresArray[i]);
                    block = street.GetBlock();
                    int streetsOnBlock = 0;
                    if (street.GetNoOfHouses() > 0)
                    {
                        btnSellHouse.Enabled = true;
                        btnMortgage.Enabled = false;
                    }
                    else
                    {
                        btnSellHouse.Enabled = false;
                        btnMortgage.Enabled = true;
                    }

                    if (street.GetNoOfHouses() == 5)
                        info = street.GetInfo() + "\nEtt Hotell";
                    else
                        info = street.GetInfo() + "\nAntal hus: " + street.GetNoOfHouses();

                    for (int j = 0; j < board.SquaresArray.Length; j++)
                    {
                        if (board.SquaresArray[j].GetType() == typeof(Street) && block == ((Street)board.SquaresArray[j]).GetBlock()
                                && ((Street)board.SquaresArray[j]).GetOwner() == board.activePlayer)
                        {
                            streetsOnBlock++;
                        }
                    }
                    if (!street.GetMortgaged() && street.GetNoOfHouses() < 5)
                    {
                        if (streetsOnBlock == 2)
                        {
                            if (block == 0 || block == 7)
                                btnBuyHouse.Enabled = true;
                            else
                                btnBuyHouse.Enabled = false;
                        }
                        else if (streetsOnBlock == 3)
                            btnBuyHouse.Enabled = true;
                        else
                            btnBuyHouse.Enabled = false;
                    }
                    else
                        btnBuyHouse.Enabled = false;

                    if (street.GetMortgaged())
                    {
                        btnMortgage.Text = "Lös ut";
                    }
                    else
                    {
                        btnMortgage.Text = "Inteckna";
                    }
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
            board.ShowSquareInfo();
            board.UpdatePlayerInfo();
        }

        private void Mortgage()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
