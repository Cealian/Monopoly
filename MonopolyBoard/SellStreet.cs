using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class SellStreet : Form
    {
        public frmMonopoly board;
        public SellStreet()
        {
            InitializeComponent();
        }

        private void SellStreet_Load(object sender, EventArgs e)
        {
            int player = board.activePlayer;
            foreach (Square square in board.SquaresArray)
            {
                if (square.GetType() == typeof(Street) && ((Street)square).GetOwner() == player)
                {
                    clbStreets.Items.Add(((Street)square).GetName());
                }
                else if (square.GetType() == typeof(Station) && ((Station)square).GetOwner() == player)
                {
                    clbStreets.Items.Add(((Station)square).GetName());
                }
                else if (square.GetType() == typeof(PowerStation) && ((PowerStation)square).GetOwner() == player)
                {
                    clbStreets.Items.Add(((PowerStation)square).GetName());
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                Square sellSquare = board.SquaresArray[i];
                foreach (object square in clbStreets.CheckedItems)
                {
                    if (square.ToString() == board.SquaresArray[i].GetName())
                    {
                        if (square.GetType() == typeof(Street))
                        {
                            ((Street)sellSquare).ChangeOwner(5);
                            board.Player[board.activePlayer].AddMoney(((Street)sellSquare).GetSellPrice());
                        }
                        else if (square.GetType() == typeof(Station))
                        {
                            ((Station)sellSquare).ChangeOwner(5);
                            board.Player[board.activePlayer].AddMoney(((Station)sellSquare).GetSellPrice());
                        }
                        else if (square.GetType() == typeof(PowerStation))
                        {
                            ((PowerStation)sellSquare).ChangeOwner(5);
                            board.Player[board.activePlayer].AddMoney(((PowerStation)sellSquare).GetSellPrice());
                        }
                    }
                }
            }

        }

        private void clbStreets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
