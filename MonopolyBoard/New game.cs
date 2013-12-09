using System;
using System.Windows.Forms;

namespace MonopolyBoard
{
    public partial class New_game : Form
    {
        public New_game()
        {
            InitializeComponent();
            txtBoxPlayer1.Focus();
        }

        public PlayerClass[] GetPlayers()
        {
            PlayerClass[] player = new PlayerClass[4];

            
            
            player[0] = new PlayerClass(txtBoxPlayer1.Text);
            player[1] = new PlayerClass(txtBoxPlayer2.Text);
            player[2] = new PlayerClass(txtBoxPlayer3.Text);
            player[3] = new PlayerClass(txtBoxPlayer4.Text);

            return player;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (CheckPlayers() == 0)
            {
                MessageBox.Show("Inget i ettan");
                txtBoxPlayer1.Focus();
                return;
            }
            else if(CheckPlayers() == 1)
            {
                MessageBox.Show("Inget i tvåan");
                txtBoxPlayer2.Focus();
                return;
            }
            
            this.DialogResult = DialogResult.OK;
        }

        public int CheckPlayers() 
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

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBoxPlayer = sender as TextBox;

            if (txtBoxPlayer == txtBoxPlayer1 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer2.Enabled = true;
            }
            else if (txtBoxPlayer == txtBoxPlayer1 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer2.Enabled = false;
                txtBoxPlayer2.Text = "";
            }

            if (txtBoxPlayer == txtBoxPlayer2 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer3.Enabled = true;
            }
            else if (txtBoxPlayer == txtBoxPlayer2 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer3.Enabled = false;
                txtBoxPlayer3.Text = "";
            }

            if (txtBoxPlayer == txtBoxPlayer3 && txtBoxPlayer.Text != "")
            {
                txtBoxPlayer4.Enabled = true;
                
            }
            else if (txtBoxPlayer == txtBoxPlayer3 && txtBoxPlayer.Text == "")
            {
                txtBoxPlayer4.Enabled = false;
                txtBoxPlayer4.Text = "";
            }
        }
    }
}
