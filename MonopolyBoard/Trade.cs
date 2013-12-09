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
    public partial class Trade : Form
    {
        public frmMonopoly board;
        public Trade()
        {
            InitializeComponent();
        }

        private void AtoB_Click(object sender, EventArgs e)
        {
            if (cbMoneyA.Checked)
            {
                int moneyToMove = 0;
                try
                {
                    moneyToMove = int.Parse(txtMoneyA.Text);
                }
                catch
                {
                    moneyToMove = 0;
                }
                board.Player[board.activePlayer].SubtractMoney(moneyToMove);
                for (int j = 0; j < board.Player.Length; j++)
                {
                    if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName())
                    {
                        board.Player[j].AddMoney(moneyToMove);
                        mtxtMoneyB.Text = board.Player[j].GetMoney().ToString();
                    }
                }
                txtMoneyA.Text = "";
                mtxtMoneyA.Text = board.Player[board.activePlayer].GetMoney().ToString();
            }
            while (clbPlayerA.CheckedItems.Count > 0)
            {
                clbPlayerB.Items.Add(clbPlayerA.CheckedItems[0]);
                clbPlayerA.Items.Remove(clbPlayerA.CheckedItems[0]);
            }
        }

        private void BtoA_Click(object sender, EventArgs e)
        {
            if (cbMoneyB.Checked)
            {
                string moneyToMove = txtMoneyA.Text;
                int pAMoney = board.Player[board.activePlayer].GetMoney(), pBMoney = 0;
                for (int j = 0; j < board.Player.Length; j++)
                {
                    if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName())
                        pBMoney = board.Player[j].GetMoney();

                }
                //TradeMoney(ref pAMoney, ref pBMoney, ref moneyToMove);
                txtMoneyA.Text = moneyToMove;
                cbMoneyA.Checked = false;
            }
            while (clbPlayerB.CheckedItems.Count > 0)
            {
                clbPlayerA.Items.Add(clbPlayerB.CheckedItems[0]);
                clbPlayerB.Items.Remove(clbPlayerB.CheckedItems[0]);
            }
        }

        private void cbMoneyA_CheckedChanged(object sender, EventArgs e)
        {
            txtMoneyA.Focus();
        }

        private void cbMoneyB_CheckedChanged(object sender, EventArgs e)
        {
            txtMoneyB.Focus();
        }

        private void trade_Click(object sender, EventArgs e)
        {
            if (cbMoneyA.Checked)
            {
                string a = mtxtMoneyA.Text, b = mtxtMoneyB.Text, c = txtMoneyA.Text;
                //TradeMoney(ref a, ref b, ref c);
                cbMoneyA.Checked = false;
                mtxtMoneyA.Text = a;
                mtxtMoneyB.Text = b;
                txtMoneyA.Text = c;
            }
            while (clbPlayerA.CheckedItems.Count > 0)
            {
                clbPlayerB.Items.Add(clbPlayerA.CheckedItems[0]);
                clbPlayerA.Items.Remove(clbPlayerA.CheckedItems[0]);
            }

            if (cbMoneyB.Checked)
            {
                string a = mtxtMoneyB.Text, b = mtxtMoneyA.Text, c = txtMoneyB.Text;
                //TradeMoney(ref a, ref b, ref c);
                cbMoneyB.Checked = false;
                mtxtMoneyB.Text = a;
                mtxtMoneyA.Text = b;
                txtMoneyB.Text = c;
            }
            while (clbPlayerB.CheckedItems.Count > 0)
            {
                clbPlayerA.Items.Add(clbPlayerB.CheckedItems[0]);
                clbPlayerB.Items.Remove(clbPlayerB.CheckedItems[0]);
            }
        }

        private void Trade_Load(object sender, EventArgs e)
        {
            gbAPlayer.Text = board.Player[board.activePlayer].GetName();
            mtxtMoneyA.Text = board.Player[board.activePlayer].GetMoney().ToString();
            for (int i = 0; i < board.Player.Length; i++)
            {
                if (i != board.activePlayer)
                    lbPlayers.Items.Add(board.Player[i].GetName());
            }
            lbPlayers.SetSelected(0, true);
            gbSPlayer.Text = lbPlayers.SelectedItem.ToString();
            ChangePlayers();
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePlayers();
            gbSPlayer.Text = lbPlayers.SelectedItem.ToString();
        }

        public void ChangePlayers()
        {
            clbPlayerA.Items.Clear();
            clbPlayerB.Items.Clear();

            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                if (board.SquaresArray[i].GetType() == typeof(Street))
                {
                    if (((Street)board.SquaresArray[i]).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((Street)board.SquaresArray[i]).GetName());
                }
                else if (board.SquaresArray[i].GetType() == typeof(Station))
                {
                    if (((Station)board.SquaresArray[i]).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((Station)board.SquaresArray[i]).GetName());
                }
                else if (board.SquaresArray[i].GetType() == typeof(PowerStation))
                {
                    if (((PowerStation)board.SquaresArray[i]).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((PowerStation)board.SquaresArray[i]).GetName());
                }

                for (int j = 0; j < board.Player.Length; j++)
                {
                    if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName())
                        mtxtMoneyB.Text = board.Player[j].GetMoney().ToString();
                    if (board.SquaresArray[i].GetType() == typeof(Street))
                    {
                        if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName()
                            && ((Street)board.SquaresArray[i]).GetOwner() == j)
                            clbPlayerB.Items.Add(((Street)board.SquaresArray[i]).GetName());
                    }
                    else if (board.SquaresArray[i].GetType() == typeof(Station))
                    {   
                        if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName()
                            && ((Station)board.SquaresArray[i]).GetOwner() == j)
                            clbPlayerB.Items.Add(((Station)board.SquaresArray[i]).GetName());
                    }
                    else if (board.SquaresArray[i].GetType() == typeof(PowerStation))
                    {
                        if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName()
                            && ((PowerStation)board.SquaresArray[i]).GetOwner() == j)
                            clbPlayerB.Items.Add(((PowerStation)board.SquaresArray[i]).GetName());
                    }
                }
            }
        }
    }
}
