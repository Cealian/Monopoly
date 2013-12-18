using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyBoard/*Written by Sebastian Olsson*/
{
    public partial class frmTrade : Form//This is the trade form.
    {
        public frmMonopoly board;
        public frmTrade()
        {
            InitializeComponent();
        }

        private void MoneyToMove()//Moves money between the players.
        {
            int moneyToMove = 0;
            try
            {
                if (cbMoneyA.Checked)
                    moneyToMove = int.Parse(txtMoneyA.Text);
                else if (cbMoneyB.Checked)
                    moneyToMove = int.Parse(txtMoneyB.Text);

            }
            catch (FormatException)
            {
                if (cbMoneyA.Checked)
                {
                    moneyToMove = 0;
                    txtMoneyA.Text = "";
                    MessageBox.Show("Skriv in ett heltal.");
                }
                else if (cbMoneyB.Checked)
                {
                    moneyToMove = 0;
                    txtMoneyB.Text = "";
                    MessageBox.Show("Skriv in ett heltal,");
                }
            }

            if (moneyToMove < 0)
                moneyToMove = 0;

            if (cbMoneyA.Checked)
            {
                if (moneyToMove > board.Player[board.activePlayer].GetMoney())
                    moneyToMove = board.Player[board.activePlayer].GetMoney();
                board.Player[board.activePlayer].SubtractMoney(moneyToMove);
                board.Player[GetSelectedPlayer()].AddMoney(moneyToMove);
                txtMoneyA.Text = "";
                cbMoneyA.Checked = false;
            }
            else if (cbMoneyB.Checked)
            {
                if (moneyToMove > board.Player[GetSelectedPlayer()].GetMoney())
                    moneyToMove = board.Player[GetSelectedPlayer()].GetMoney();
                board.Player[GetSelectedPlayer()].SubtractMoney(moneyToMove);
                board.Player[board.activePlayer].AddMoney(moneyToMove);
                txtMoneyB.Text = "";
                cbMoneyB.Checked = false;
            }
        }

        private void cbMoneyA_CheckedChanged(object sender, EventArgs e)//Sets txtMoneyA into focus and sets the second checkbox to false.
        {
            cbMoneyB.Checked = !cbMoneyA.Checked;
            txtMoneyA.Focus();
        }

        private void cbMoneyB_CheckedChanged(object sender, EventArgs e)//Sets txtMoneyB into focus and sets the first checkbox to false.
        {
            cbMoneyA.Checked = !cbMoneyB.Checked;
            txtMoneyB.Focus();
        }

        private void trade_Click(object sender, EventArgs e)//Moves money and streets between the players.
        {
            MoneyToMove();
            MoveStreets(GetSelectedPlayer());
            MoveStreets(board.activePlayer);
            ChangePlayers();
            board.CheckOwnership();
        }

        private void Trade_Load(object sender, EventArgs e)//Loads all varibles that we need when the form opens.
        {
            for (int i = 0; i < board.Player.Length; i++)
            {
                if (i != board.activePlayer && board.Player[i].GetName() != "")
                    lbPlayers.Items.Add(board.Player[i].GetName());
            }
            lbPlayers.SetSelected(0, true);
            ChangePlayers();
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)//Change the second player so you can trade with the player you want.
        {
            ChangePlayers();
        }

        private void ChangePlayers()//Updates all listbox and textfields with the correct data.
        {
            clbPlayerA.Items.Clear();
            clbPlayerB.Items.Clear();

            mtxtMoneyA.Text = board.Player[board.activePlayer].GetMoney().ToString();
            mtxtMoneyB.Text = board.Player[GetSelectedPlayer()].GetMoney().ToString();

            txtMoneyA.Text = "0";
            txtMoneyB.Text = "0";

            cbMoneyA.Checked = true;

            gbAPlayer.Text = board.Player[board.activePlayer].GetName();
            gbSPlayer.Text = lbPlayers.SelectedItem.ToString();

            string selectedPlayerList = lbPlayers.SelectedItem.ToString();
            string selectedPlayerName = board.Player[GetSelectedPlayer()].GetName();

            board.ShowSquareInfo();
            board.UpdatePlayerInfo();

            foreach (Square square in board.Squares)
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
        }

        private int GetSelectedPlayer()//Return the index of the player you are trading with.
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
        }

        private void MoveStreets(int toPlayer)//Moves streets between players.
        {
            for (int i = 0; i < board.Squares.Length; i++)/*Here I loop through all the squares in the game.*/
            {
                foreach (object itemChecked in clbPlayerA.CheckedItems)/*Here I loop through all the checked items in the left listbox.*/
                {
                    if (lbPlayers.SelectedItem.ToString() == board.Player[toPlayer].GetName()/*Here I find the checked square in the array.*/
                        && itemChecked.ToString() == board.Squares[i].GetName())
                    {
                        if (board.Squares[i].GetType() == typeof(Street))/*If it's a street I change owner of the checked street to the other player.*/
                        {
                            ((Street)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                        else if (board.Squares[i].GetType() == typeof(Station))/*If it's a station I change owner of the checked station to the other player.*/
                        {
                            ((Station)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                        else if (board.Squares[i].GetType() == typeof(PowerStation))/*If it's a powerstation I change owner of the checked powerstation to the other player.*/
                        {
                            ((PowerStation)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                    }
                }
                foreach (object itemChecked in clbPlayerB.CheckedItems)/*Then I do the same thing but in the right listbox. I have to do the same thing two times because it's two diffrent listbox.*/
                {
                    if (itemChecked.ToString() == board.Squares[i].GetName())
                    {
                        if (board.Squares[i].GetType() == typeof(Street))
                        {
                            ((Street)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                        else if (board.Squares[i].GetType() == typeof(Station))
                        {
                            ((Station)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                        else if (board.Squares[i].GetType() == typeof(PowerStation))
                        {
                            ((PowerStation)board.Squares[i]).ChangeOwner(toPlayer);
                            board.GEngine.UpdateOwner(i, toPlayer);
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)//Closes the form.
        {
            Dispose();
            Close();
        }
    }
}
