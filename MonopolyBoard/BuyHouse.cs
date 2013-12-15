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
        public Street board2;

        public BuyHouse()
        {
            string test = board.Player[board.activePlayer].GetName();
            clbStreets.Items.Add(test);
            InitializeComponent();
            
        }
    }
}
