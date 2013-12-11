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

        private void MoneyToMove()
        {
            string[] text = new string[2];
            int[] moneyToMove = new int[2] {0,0};
            text[0] = txtMoneyA.Text;
            text[1] = txtMoneyB.Text;
            try
            {
                if (cbMoneyA.Checked && cbMoneyB.Checked)
                {
                    moneyToMove[0] = int.Parse(txtMoneyA.Text);
                    moneyToMove[1] = int.Parse(txtMoneyB.Text);
                }
                else if (cbMoneyA.Checked)
                    moneyToMove[0] = int.Parse(txtMoneyA.Text);
                else if (cbMoneyB.Checked)
                    moneyToMove[1] = int.Parse(txtMoneyB.Text);
                
            }
            catch (FormatException)
            {
                if (cbMoneyA.Checked && cbMoneyB.Checked)
                {
                    moneyToMove[0] = 0;
                    moneyToMove[1] = 0;
                    txtMoneyA.Text = "";
                    txtMoneyB.Text = "";
                    MessageBox.Show("Skriv in ett heltal.");
                }
                else if (cbMoneyA.Checked)
                {
                    moneyToMove[0] = 0;
                    txtMoneyA.Text = "";
                    MessageBox.Show("Skriv in ett heltal.");
                }
                else if (cbMoneyB.Checked)
                {
                    moneyToMove[1] = 0;
                    txtMoneyB.Text = "";
                    MessageBox.Show("Skriv in ett heltal");
                }
            }

            if (cbMoneyA.Checked && cbMoneyB.Checked)
            {
                board.Player[board.activePlayer].SubtractMoney(moneyToMove[0]);
                board.Player[GetSelectedPlayer()].AddMoney(moneyToMove[0]);
                board.Player[GetSelectedPlayer()].SubtractMoney(moneyToMove[1]);
                board.Player[board.activePlayer].AddMoney(moneyToMove[1]);
                txtMoneyA.Text = "";
                txtMoneyB.Text = "";
                cbMoneyA.Checked = false;
                cbMoneyB.Checked = false;
            }
            else if (cbMoneyA.Checked)
            {
                board.Player[board.activePlayer].SubtractMoney(moneyToMove[0]);
                board.Player[GetSelectedPlayer()].AddMoney(moneyToMove[0]);
                txtMoneyA.Text = "";
                cbMoneyA.Checked = false;
            }
            else if (cbMoneyB.Checked)
            {
                board.Player[GetSelectedPlayer()].SubtractMoney(moneyToMove[1]);
                board.Player[board.activePlayer].AddMoney(moneyToMove[1]);
                txtMoneyB.Text = "";
                cbMoneyB.Checked = false;
            }
        }

        private void cbMoneyA_CheckedChanged(object sender, EventArgs e)
        {
            txtMoneyA.Focus();
        }   //Sets txtMoneyA into focus.

        private void cbMoneyB_CheckedChanged(object sender, EventArgs e)
        {
            txtMoneyB.Focus();
        }   //Sets txtMoneyB into focus.

        private void trade_Click(object sender, EventArgs e)
        {
            MoneyToMove();
            MoveStreets(GetSelectedPlayer());
            MoveStreets(board.activePlayer);
            ChangePlayers();
        }   //Moves money and streets from PlayerA to B and from B to A.

        private void Trade_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < board.Player.Length; i++)
            {
                if (i != board.activePlayer && board.Player[i].GetName()!="")
                    lbPlayers.Items.Add(board.Player[i].GetName());
            }
            lbPlayers.SetSelected(0, true);
            ChangePlayers();
        }   //Loads all veribles that we need from the mainprogram and insert them where they should be.

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePlayers();
        }   //Change the second player so you can trade with the player you want.

        private void ChangePlayers()
        {
            clbPlayerA.Items.Clear();
            clbPlayerB.Items.Clear();

            mtxtMoneyA.Text = board.Player[board.activePlayer].GetMoney().ToString();
            mtxtMoneyB.Text = board.Player[GetSelectedPlayer()].GetMoney().ToString();

            gbAPlayer.Text = board.Player[board.activePlayer].GetName();
            gbSPlayer.Text = lbPlayers.SelectedItem.ToString();

            string selectedPlayerList = lbPlayers.SelectedItem.ToString();
            string selectedPlayerName = board.Player[GetSelectedPlayer()].GetName();

            board.ShowSquareInfo();
            
            foreach (Square square in board.SquaresArray)
            {
                if (square.GetType() == typeof(Street))
                {
                    if (((Street)square).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((Street)square).GetName());
                    else if (selectedPlayerList == selectedPlayerName
                        && ((Street)square).GetOwner() == GetSelectedPlayer())
                        clbPlayerB.Items.Add(((Street)square).GetName());
                }
                else if (square.GetType() == typeof(Station))
                {
                    if (((Station)square).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((Station)square).GetName());
                    else if (selectedPlayerList == selectedPlayerName
                        && ((Station)square).GetOwner() == GetSelectedPlayer())
                        clbPlayerB.Items.Add(((Station)square).GetName());
                }
                else if (square.GetType() == typeof(PowerStation))
                {
                    if (((PowerStation)square).GetOwner() == board.activePlayer)
                        clbPlayerA.Items.Add(((PowerStation)square).GetName());
                    else if (selectedPlayerList == selectedPlayerName
                        && ((Station)square).GetOwner() == GetSelectedPlayer())
                        clbPlayerB.Items.Add(((Station)square).GetName());
                }
            }
        }   //Reloads all listbox and textfields with the corect data.

        private int GetSelectedPlayer()
        {
            int player = 0;
            for (int j = 0; j < board.Player.Length; j++)
            {
                if (lbPlayers.SelectedItem.ToString() == board.Player[j].GetName())
                {
                    player = j;
                }
            }
            return player;
        }   //Return the index of the player you are trading with.

        private void MoveStreets(int toPlayer)
        {
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                foreach (object itemChecked in clbPlayerA.CheckedItems)
                {
                    if (lbPlayers.SelectedItem.ToString() == board.Player[toPlayer].GetName()
                        && itemChecked.ToString() == board.SquaresArray[i].GetName())
                    {
                        if (board.SquaresArray[i].GetType() == typeof(Street))
                        {
                            ((Street)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                        else if (board.SquaresArray[i].GetType() == typeof(Station))
                        {
                            ((Station)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                        else if (board.SquaresArray[i].GetType() == typeof(PowerStation))
                        {
                            ((PowerStation)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                    }
                }
                foreach (object itemChecked in clbPlayerB.CheckedItems)
                {
                    if (itemChecked.ToString() == board.SquaresArray[i].GetName())
                    {
                        if (board.SquaresArray[i].GetType() == typeof(Street))
                        {
                            ((Street)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                        else if (board.SquaresArray[i].GetType() == typeof(Station))
                        {
                            ((Station)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                        else if (board.SquaresArray[i].GetType() == typeof(PowerStation))
                        {
                            ((PowerStation)board.SquaresArray[i]).ChangeOwner(toPlayer);
                        }
                    }
                }
            }
        }
    }
}
