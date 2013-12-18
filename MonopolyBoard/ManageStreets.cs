using System;
using System.Windows.Forms;

namespace MonopolyBoard/*Written by Sebastian Olsson*/
{
    public partial class frmManageStreets : Form/*This is the street management form.*/
    {
        public frmMonopoly board;
        public frmManageStreets()
        {
            InitializeComponent();
        }

        private void SellStreet_Load(object sender, EventArgs e)/*Loads the listbox with the streets the active player owns*/
        {
            UpdateSquares();
            if (lbStreets.Items.Count > 0)
            {
                lbStreets.SetSelected(0, true);
                UpdateInfo();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)/*Mortgage the selected street and updates all fields.*/
        {
            Mortgage();
            UpdateInfo();
        }

        private void UpdateSquares()/*Updates the listbox.*/
        {
            lbInfo.Text = "";
            lbStreets.Items.Clear();
            int player = board.activePlayer;
            foreach (Square square in board.Squares)
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

        private void UpdateInfo()/*Updates all the buttons and the infolabel with the correct data.*/
        {
            string info = "";
            int block = 10;
            for (int i = 0; i < board.Squares.Length; i++)/*I looping through all squares in the game.*/
            {
                string name = board.Squares[i].GetName();
                Type squareType = board.Squares[i].GetType();
                if (lbStreets.SelectedItem.ToString() == name && squareType == typeof(Street))/*When I find a Street with the same name as the selected object this if ist true.*/
                {
                    Street street = ((Street)board.Squares[i]);
                    block = street.GetBlock();
                    int streetsOnBlock = 0, isMortgaged = 0, anyHouses = 0;/*Here I create three diffrent counters to count through the second loop.*/
                    for (int j = 0; j < board.Squares.Length; j++)/*Here I loop through all the squares one more time to see which streets are in the same block as the selected street.*/
                    {
                        if (board.Squares[j].GetType() == typeof(Street))
                        {
                            if (block == ((Street)board.Squares[j]).GetBlock()
                                    && ((Street)board.Squares[j]).GetOwner() == board.activePlayer)/*If the active player owns a street in the same block as the selected street this if is true.*/
                            {
                                streetsOnBlock++;/*If the player owns a street in the same block as the selcted street this will increase with one.*/
                                if (((Street)board.Squares[j]).GetMortgaged())
                                    isMortgaged++;/*If the player owns a street in the same block as the selected street but the street is mortgaged this will increase with one.*/
                                else if (((Street)board.Squares[j]).GetNoOfHouses() > 0)
                                    anyHouses++;/*If there is any street on the block with any houses on it this will increase with one.*/
                            }
                        }
                    }
                    if (!street.GetMortgaged() && street.GetNoOfHouses() < 5 && isMortgaged == 0)/*If the selected street isn't mortgaged, dosen't have 5 houses and there isn't any mortgaged streets on the block this if is true.*/
                    {
                        if (streetsOnBlock == 2)/*If the player owns two streets on the same block I checks if it's the first or last block because they only have two streets while all the other streets have three.*/
                        {
                            if (block == 0 || block == 7)/*If it's the first or last block you only have to own two streets to be able to build houses.*/
                                btnBuyHouse.Enabled = true;
                            else
                                btnBuyHouse.Enabled = false;
                        }
                        else if (streetsOnBlock == 3)/*If it's not the first or last streets you need to own three streets to build houses.*/
                            btnBuyHouse.Enabled = true;
                        else
                            btnBuyHouse.Enabled = false;
                    }
                    else
                        btnBuyHouse.Enabled = false;


                    if (street.GetNoOfHouses() > 0)/*If the selected street have any houses you wont be able to mortgage the selected street.*/
                    {
                        btnSellHouse.Enabled = true;
                        btnMortgage.Enabled = false;
                    }
                    else if (street.GetNoOfHouses() == 0 && anyHouses > 0)/*If any street on the block have any houses you won't be able to mortgage any of the other streets on the block.*/
                    {
                        btnSellHouse.Enabled = false;
                        btnMortgage.Enabled = false;
                    }
                    else
                    {
                        btnSellHouse.Enabled = false;
                        btnMortgage.Enabled = true;
                    }

                    if (street.GetNoOfHouses() == 5)/*If you have 5 houses it's the same as the one hotel.*/
                        info = street.GetInfo() + "\nEtt Hotell";
                    else
                        info = street.GetInfo() + "\nAntal hus: " + street.GetNoOfHouses();

                    if (street.GetMortgaged())/*If the street is mortgaged the text on the botton changes.*/
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
                    if (((Station)board.Squares[i]).GetMortgaged())
                        btnMortgage.Text = "Lös ut";
                    else
                        btnMortgage.Text = "Inteckna";
                    info = ((Station)board.Squares[i]).GetInfo();
                }
                else if (lbStreets.SelectedItem.ToString() == name && squareType == typeof(PowerStation))
                {
                    btnBuyHouse.Enabled = false;
                    btnSellHouse.Enabled = false;
                    if (((PowerStation)board.Squares[i]).GetMortgaged())
                        btnMortgage.Text = "Lös ut";
                    else
                        btnMortgage.Text = "Inteckna";
                    info = ((PowerStation)board.Squares[i]).GetInfo();
                }
            }
            lbInfo.Text = info;
            board.ShowSquareInfo();
            board.UpdatePlayerInfo();
        }

        private void Mortgage()/*Mortgage the selceted object.*/
        {
            for (int i = 0; i < board.Squares.Length; i++)
            {
                Square sellSquare = board.Squares[i];

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

        private void lbStreets_SelectedIndexChanged(object sender, EventArgs e)/*Updates all the buttons and the infolabel with the correct data.*/
        {
            UpdateInfo();
        }

        private void btnBuyHouse_Click(object sender, EventArgs e)/*Builds a house on the selected street.*/
        {
            for (int i = 0; i < board.Squares.Length; i++)
            {
                Type streetType = board.Squares[i].GetType();
                if (streetType == typeof(Street))
                {
                    Street street = ((Street)board.Squares[i]);
                    if (lbStreets.SelectedItem.ToString() == street.GetName())
                    {
                        street.BuildHouse();
                        board.Player[board.activePlayer].SubtractMoney(street.GetHousePrice());
                    }
                }
            }
            UpdateInfo();
        }

        private void btnSellHouse_Click(object sender, EventArgs e)/*Sells a house on the selected street.*/
        {
            for (int i = 0; i < board.Squares.Length; i++)
            {
                Type streetType = board.Squares[i].GetType();
                if (streetType == typeof(Street))
                {
                    Street street = ((Street)board.Squares[i]);
                    if (lbStreets.SelectedItem.ToString() == street.GetName())
                    {
                        street.SellHouse();
                        board.Player[board.activePlayer].AddMoney(street.GetSellHousePrice());
                    }
                }
            }
            UpdateInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)/*Closes the form.*/
        {
            Dispose();
            Close();
        }
    }
}
