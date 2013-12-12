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
    public partial class BuyHouse : Form
    {
        public frmMonopoly board;
        public BuyHouse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuyHouse_Load(object sender, EventArgs e)
        {
            foreach (Square square in board.SquaresArray) 
            {                                            
                if (square.GetType() == typeof(Street))  
                {                                        
                    if (((Street)square).GetOwner() == board.activePlayer)
                        lbStreets.Items.Add(((Street)square).GetName());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                if (lbStreets.SelectedItem.ToString() == board.SquaresArray[i].GetName())
                {
                    lblShowPrice.Text = ((Street)board.SquaresArray[i]).GetHousePrice().ToString();
                }           
            }
        }
    }
}
