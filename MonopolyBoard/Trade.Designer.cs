﻿namespace MonopolyBoard
{
    partial class frmTrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAPlayer = new System.Windows.Forms.GroupBox();
            this.mtxtMoneyA = new System.Windows.Forms.MaskedTextBox();
            this.txtMoneyA = new System.Windows.Forms.TextBox();
            this.cbMoneyA = new System.Windows.Forms.CheckBox();
            this.clbPlayerA = new System.Windows.Forms.CheckedListBox();
            this.gbSPlayer = new System.Windows.Forms.GroupBox();
            this.mtxtMoneyB = new System.Windows.Forms.MaskedTextBox();
            this.txtMoneyB = new System.Windows.Forms.TextBox();
            this.cbMoneyB = new System.Windows.Forms.CheckBox();
            this.clbPlayerB = new System.Windows.Forms.CheckedListBox();
            this.btnTrade = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAPlayer.SuspendLayout();
            this.gbSPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAPlayer
            // 
            this.gbAPlayer.Controls.Add(this.mtxtMoneyA);
            this.gbAPlayer.Controls.Add(this.txtMoneyA);
            this.gbAPlayer.Controls.Add(this.cbMoneyA);
            this.gbAPlayer.Controls.Add(this.clbPlayerA);
            this.gbAPlayer.Location = new System.Drawing.Point(26, 36);
            this.gbAPlayer.Name = "gbAPlayer";
            this.gbAPlayer.Size = new System.Drawing.Size(200, 250);
            this.gbAPlayer.TabIndex = 0;
            this.gbAPlayer.TabStop = false;
            this.gbAPlayer.Text = "Player A";
            // 
            // mtxtMoneyA
            // 
            this.mtxtMoneyA.Location = new System.Drawing.Point(139, 224);
            this.mtxtMoneyA.Name = "mtxtMoneyA";
            this.mtxtMoneyA.ReadOnly = true;
            this.mtxtMoneyA.Size = new System.Drawing.Size(55, 20);
            this.mtxtMoneyA.TabIndex = 3;
            // 
            // txtMoneyA
            // 
            this.txtMoneyA.Location = new System.Drawing.Point(70, 224);
            this.txtMoneyA.Name = "txtMoneyA";
            this.txtMoneyA.Size = new System.Drawing.Size(55, 20);
            this.txtMoneyA.TabIndex = 2;
            this.txtMoneyA.Text = "0";
            // 
            // cbMoneyA
            // 
            this.cbMoneyA.AutoSize = true;
            this.cbMoneyA.Checked = true;
            this.cbMoneyA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMoneyA.Location = new System.Drawing.Point(6, 227);
            this.cbMoneyA.Name = "cbMoneyA";
            this.cbMoneyA.Size = new System.Drawing.Size(58, 17);
            this.cbMoneyA.TabIndex = 1;
            this.cbMoneyA.Text = "Money";
            this.cbMoneyA.UseVisualStyleBackColor = true;
            this.cbMoneyA.CheckedChanged += new System.EventHandler(this.cbMoneyA_CheckedChanged);
            // 
            // clbPlayerA
            // 
            this.clbPlayerA.CheckOnClick = true;
            this.clbPlayerA.FormattingEnabled = true;
            this.clbPlayerA.Location = new System.Drawing.Point(6, 19);
            this.clbPlayerA.Name = "clbPlayerA";
            this.clbPlayerA.Size = new System.Drawing.Size(188, 199);
            this.clbPlayerA.TabIndex = 0;
            // 
            // gbSPlayer
            // 
            this.gbSPlayer.Controls.Add(this.mtxtMoneyB);
            this.gbSPlayer.Controls.Add(this.txtMoneyB);
            this.gbSPlayer.Controls.Add(this.cbMoneyB);
            this.gbSPlayer.Controls.Add(this.clbPlayerB);
            this.gbSPlayer.Location = new System.Drawing.Point(345, 36);
            this.gbSPlayer.Name = "gbSPlayer";
            this.gbSPlayer.Size = new System.Drawing.Size(200, 250);
            this.gbSPlayer.TabIndex = 1;
            this.gbSPlayer.TabStop = false;
            this.gbSPlayer.Text = "Player B";
            // 
            // mtxtMoneyB
            // 
            this.mtxtMoneyB.Location = new System.Drawing.Point(139, 225);
            this.mtxtMoneyB.Name = "mtxtMoneyB";
            this.mtxtMoneyB.ReadOnly = true;
            this.mtxtMoneyB.Size = new System.Drawing.Size(55, 20);
            this.mtxtMoneyB.TabIndex = 3;
            // 
            // txtMoneyB
            // 
            this.txtMoneyB.Location = new System.Drawing.Point(70, 225);
            this.txtMoneyB.Name = "txtMoneyB";
            this.txtMoneyB.Size = new System.Drawing.Size(55, 20);
            this.txtMoneyB.TabIndex = 2;
            this.txtMoneyB.Text = "0";
            // 
            // cbMoneyB
            // 
            this.cbMoneyB.AutoSize = true;
            this.cbMoneyB.Location = new System.Drawing.Point(6, 227);
            this.cbMoneyB.Name = "cbMoneyB";
            this.cbMoneyB.Size = new System.Drawing.Size(58, 17);
            this.cbMoneyB.TabIndex = 1;
            this.cbMoneyB.Text = "Money";
            this.cbMoneyB.UseVisualStyleBackColor = true;
            this.cbMoneyB.CheckedChanged += new System.EventHandler(this.cbMoneyB_CheckedChanged);
            // 
            // clbPlayerB
            // 
            this.clbPlayerB.CheckOnClick = true;
            this.clbPlayerB.FormattingEnabled = true;
            this.clbPlayerB.Location = new System.Drawing.Point(6, 19);
            this.clbPlayerB.Name = "clbPlayerB";
            this.clbPlayerB.Size = new System.Drawing.Size(188, 199);
            this.clbPlayerB.TabIndex = 0;
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(246, 198);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 4;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.trade_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(246, 85);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(75, 82);
            this.lbPlayers.TabIndex = 5;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.lbPlayers_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(246, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Stäng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.gbSPlayer);
            this.Controls.Add(this.gbAPlayer);
            this.Name = "frmTrade";
            this.Text = "Byte";
            this.Load += new System.EventHandler(this.Trade_Load);
            this.gbAPlayer.ResumeLayout(false);
            this.gbAPlayer.PerformLayout();
            this.gbSPlayer.ResumeLayout(false);
            this.gbSPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAPlayer;
        private System.Windows.Forms.TextBox txtMoneyA;
        private System.Windows.Forms.CheckBox cbMoneyA;
        private System.Windows.Forms.CheckedListBox clbPlayerA;
        private System.Windows.Forms.GroupBox gbSPlayer;
        private System.Windows.Forms.TextBox txtMoneyB;
        private System.Windows.Forms.CheckBox cbMoneyB;
        private System.Windows.Forms.CheckedListBox clbPlayerB;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.MaskedTextBox mtxtMoneyA;
        private System.Windows.Forms.MaskedTextBox mtxtMoneyB;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Button btnClose;
    }
}

