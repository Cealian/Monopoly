﻿using System;
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
        public Monopoly board;
        public Trade()
        {
            
            
            InitializeComponent();
            //int a = board.SquaresArray.Length;
            int moneyA = 1000, moneyB = 1000;
            //Square[] playerA = board.SquaresArray;
            //string[] playerB = { "arne", "arne2", "arne3", "arne4", "arne5" };
            
            //for (int i = 0; i <= playerA.Length; i++)
            //{
                //clbPlayerA.Items.Add(board.SquaresArray[0].GetName());
                //clbPlayerA.Items.Add(board.SquaresArray[i].GetName());
                
                
            
            //}
            //for (int i = 0; i < playerB.Length; i++)
                //clbPlayerB.Items.Add(playerB[i]);

            mtxtMoneyA.Text = moneyA.ToString();
            mtxtMoneyB.Text = moneyB.ToString();

        }

        static void TradeMoney(ref string fromMoney, ref string toMoney, ref string toMove)
        {
            int a = 0, b = 0, aTob = 0;
            a = int.Parse(fromMoney);
            b = int.Parse(toMoney);
            try
            {
                aTob = int.Parse(toMove);
            }
            catch
            {
                aTob = 0;
            }
            a -= aTob;
            b += aTob;
            fromMoney = a.ToString();
            toMoney = b.ToString();
            toMove = "";
        }

        private void AtoB_Click(object sender, EventArgs e)
        {
            if (cbMoneyA.Checked)
            {
                string a = mtxtMoneyA.Text, b = mtxtMoneyB.Text, c = txtMoneyA.Text;
                TradeMoney(ref a, ref b, ref c);
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
        }

        private void BtoA_Click(object sender, EventArgs e)
        {
            if (cbMoneyB.Checked)
            {
                string a = mtxtMoneyB.Text, b = mtxtMoneyA.Text, c = txtMoneyB.Text;
                TradeMoney(ref a, ref b, ref c);
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
                TradeMoney(ref a, ref b, ref c);
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
                TradeMoney(ref a, ref b, ref c);
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
            for (int i = 0; i < board.SquaresArray.Length; i++)
            {
                if (board.SquaresArray[i].GetType().ToString() == "MonopolyBoard.Street")
                {
                    Street newStreet = (Street)board.SquaresArray[i];
                    if(i%2==0)
                        newStreet.ChangeOwner(1);
                    if (newStreet.GetOwner() == 1)
                        clbPlayerA.Items.Add(newStreet.GetName());
                    else if (newStreet.GetOwner() == 0)
                        clbPlayerB.Items.Add(newStreet.GetName());
                }
                else if (board.SquaresArray[i].GetType().ToString() == "MonopolyBoard.Station")
                {
                    Station newStation = (Station)board.SquaresArray[i];
                    if (i % 2 == 0)
                        newStation.ChangeOwner(1);
                    if (newStation.GetOwner() == 1)
                        clbPlayerA.Items.Add(newStation.GetName());
                    else if (newStation.GetOwner() == 0)
                        clbPlayerB.Items.Add(newStation.GetName());
                }
                else if (board.SquaresArray[i].GetType().ToString() == "MonopolyBoard.PowerStation")
                {
                    PowerStation newPower = (PowerStation)board.SquaresArray[i];
                    if (i % 2 == 0)
                        newPower.ChangeOwner(1);
                    if (newPower.GetOwner() == 1)
                        clbPlayerA.Items.Add(newPower.GetName());
                    else if (newPower.GetOwner() == 0)
                        clbPlayerB.Items.Add(newPower.GetName());
                }
            }
            
            //txtMoneyA.Text = board.Player[board.activePlayer]
            //txtMoneyB.Text = board.Player[board.activePlayer]
        }
    }
}