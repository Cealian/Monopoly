using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class New_game : Form
    {

        frmMonopoly board = new frmMonopoly();

        public New_game()
        {
            InitializeComponent();
            txtBoxPlayer1.Focus();
        }

        public PlayerClass[] GetPlayers() /* Instantiates players and sends them to the main program. */
        {
            PlayerClass[] players = new PlayerClass[4];

            players[0] = new PlayerClass(txtBoxPlayer1.Text);
            players[1] = new PlayerClass(txtBoxPlayer2.Text);
            players[2] = new PlayerClass(txtBoxPlayer3.Text);
            players[3] = new PlayerClass(txtBoxPlayer4.Text);

            return players;
        }

        private void btnStart_Click(object sender, EventArgs e) /* Makes sure there are at least 2 player names entered. */
        {
            if (CheckPlayers() == 0)
            {
                MessageBox.Show("Ange namn för minst första och andra spelaren.");
                txtBoxPlayer1.Focus();
                return;
            }
            else if(CheckPlayers() == 1)
            {
                MessageBox.Show("Ange namn för minst första och andra spelaren.");
                txtBoxPlayer2.Focus();
                return;
            }
            
            this.DialogResult = DialogResult.OK;
        }

        public int CheckPlayers()  /* Returns the number of players with names */
        {
            int noOfPlayers = 0;

            if (txtBoxPlayer1.Text != "")
            {
                noOfPlayers = 1;
            }
            if (txtBoxPlayer2.Text != "")
            {
                noOfPlayers = 2;
            }
            if (txtBoxPlayer3.Text != "")
            {
                noOfPlayers = 3;
            }
            if (txtBoxPlayer4.Text != "")
            {
                noOfPlayers = 4;
            }

            return noOfPlayers;
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e) /* Make sure you can't type the name of a player unless the players name before have been entered */
        {
            TextBox txtBoxPlayer = sender as TextBox;
            Color inactiveColor = Color.LightGray;

            if (txtBoxPlayer == txtBoxPlayer1 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer2.Enabled = true;
                txtBoxPlayer2.BackColor = board.GetPlayerColor(1);
            }
            else if (txtBoxPlayer == txtBoxPlayer1 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer2.Enabled = false;
                txtBoxPlayer2.Text = "";
                txtBoxPlayer2.BackColor = inactiveColor;
            }

            if (txtBoxPlayer == txtBoxPlayer2 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer3.Enabled = true;
                txtBoxPlayer3.BackColor = board.GetPlayerColor(2);
            }
            else if (txtBoxPlayer == txtBoxPlayer2 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer3.Enabled = false;
                txtBoxPlayer3.Text = "";
                txtBoxPlayer3.BackColor = inactiveColor;
            }

            if (txtBoxPlayer == txtBoxPlayer3 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer4.Enabled = true;
                txtBoxPlayer4.BackColor = board.GetPlayerColor(3);
                
            }
            else if (txtBoxPlayer == txtBoxPlayer3 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer4.Enabled = false;
                txtBoxPlayer4.Text = "";
                txtBoxPlayer4.BackColor = inactiveColor;
            }
        }
    }
}
