using System.Windows.Forms;
namespace MonopolyBoard
{
    partial class frmMonopoly
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

        protected override void WndProc(ref Message m) /* Make sure the form doesn't repaint on alt press. */
        {
            // Suppress the WM_UPDATEUISTATE message
            if (m.Msg == 0x128) return;
            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonopoly));
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.lblply2NoTurnsInJail = new System.Windows.Forms.Label();
            this.lblply1NoTurnsInJail = new System.Windows.Forms.Label();
            this.lblply3NoTurnsInJail = new System.Windows.Forms.Label();
            this.lblply4NoTurnsInJail = new System.Windows.Forms.Label();
            this.lblply2InJail = new System.Windows.Forms.Label();
            this.lblply1InJail = new System.Windows.Forms.Label();
            this.lblply4InJail = new System.Windows.Forms.Label();
            this.lblply3InJail = new System.Windows.Forms.Label();
            this.lblply4Info = new System.Windows.Forms.Label();
            this.lblply3Info = new System.Windows.Forms.Label();
            this.lblply2Inf = new System.Windows.Forms.Label();
            this.lblply1Info = new System.Windows.Forms.Label();
            this.lblPlayerInfo = new System.Windows.Forms.Label();
            this.lblFreePark = new System.Windows.Forms.Label();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tmrMovePlayer = new System.Windows.Forms.Timer(this.components);
            this.btnRollDices = new System.Windows.Forms.Button();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTrade = new System.Windows.Forms.Button();
            this.lblSquareInfo = new System.Windows.Forms.Label();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.btnBuyStreet = new System.Windows.Forms.Button();
            this.btnSellStreet = new System.Windows.Forms.Button();
            this.sfdSaveGame = new System.Windows.Forms.SaveFileDialog();
            this.btnBankrupt = new System.Windows.Forms.Button();
            this.btnBail = new System.Windows.Forms.Button();
            this.pnlMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMainPanel.BackgroundImage = global::MonopolyBoard.Properties.Resources.Plan;
            this.pnlMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainPanel.Controls.Add(this.lblply2NoTurnsInJail);
            this.pnlMainPanel.Controls.Add(this.lblply1NoTurnsInJail);
            this.pnlMainPanel.Controls.Add(this.lblply3NoTurnsInJail);
            this.pnlMainPanel.Controls.Add(this.lblply4NoTurnsInJail);
            this.pnlMainPanel.Controls.Add(this.lblply2InJail);
            this.pnlMainPanel.Controls.Add(this.lblply1InJail);
            this.pnlMainPanel.Controls.Add(this.lblply4InJail);
            this.pnlMainPanel.Controls.Add(this.lblply3InJail);
            this.pnlMainPanel.Controls.Add(this.lblply4Info);
            this.pnlMainPanel.Controls.Add(this.lblply3Info);
            this.pnlMainPanel.Controls.Add(this.lblply2Inf);
            this.pnlMainPanel.Controls.Add(this.lblply1Info);
            this.pnlMainPanel.Controls.Add(this.lblPlayerInfo);
            this.pnlMainPanel.Controls.Add(this.lblFreePark);
            this.pnlMainPanel.Controls.Add(this.picPlayer3);
            this.pnlMainPanel.Controls.Add(this.picPlayer2);
            this.pnlMainPanel.Controls.Add(this.picPlayer1);
            this.pnlMainPanel.Controls.Add(this.picPlayer0);
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(648, 648);
            this.pnlMainPanel.TabIndex = 0;
            this.pnlMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainPanel_Paint);
            // 
            // lblply2NoTurnsInJail
            // 
            this.lblply2NoTurnsInJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply2NoTurnsInJail.ForeColor = System.Drawing.Color.Red;
            this.lblply2NoTurnsInJail.Location = new System.Drawing.Point(460, 168);
            this.lblply2NoTurnsInJail.Name = "lblply2NoTurnsInJail";
            this.lblply2NoTurnsInJail.Size = new System.Drawing.Size(100, 23);
            this.lblply2NoTurnsInJail.TabIndex = 26;
            this.lblply2NoTurnsInJail.Text = "Antal omgångar:";
            this.lblply2NoTurnsInJail.Visible = false;
            // 
            // lblply1NoTurnsInJail
            // 
            this.lblply1NoTurnsInJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply1NoTurnsInJail.ForeColor = System.Drawing.Color.Red;
            this.lblply1NoTurnsInJail.Location = new System.Drawing.Point(92, 168);
            this.lblply1NoTurnsInJail.Name = "lblply1NoTurnsInJail";
            this.lblply1NoTurnsInJail.Size = new System.Drawing.Size(100, 23);
            this.lblply1NoTurnsInJail.TabIndex = 25;
            this.lblply1NoTurnsInJail.Text = "Antal omgångar:";
            this.lblply1NoTurnsInJail.Visible = false;
            // 
            // lblply3NoTurnsInJail
            // 
            this.lblply3NoTurnsInJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply3NoTurnsInJail.ForeColor = System.Drawing.Color.Red;
            this.lblply3NoTurnsInJail.Location = new System.Drawing.Point(92, 521);
            this.lblply3NoTurnsInJail.Name = "lblply3NoTurnsInJail";
            this.lblply3NoTurnsInJail.Size = new System.Drawing.Size(100, 23);
            this.lblply3NoTurnsInJail.TabIndex = 24;
            this.lblply3NoTurnsInJail.Text = "Antal omgångar:";
            this.lblply3NoTurnsInJail.Visible = false;
            // 
            // lblply4NoTurnsInJail
            // 
            this.lblply4NoTurnsInJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply4NoTurnsInJail.ForeColor = System.Drawing.Color.Red;
            this.lblply4NoTurnsInJail.Location = new System.Drawing.Point(460, 521);
            this.lblply4NoTurnsInJail.Name = "lblply4NoTurnsInJail";
            this.lblply4NoTurnsInJail.Size = new System.Drawing.Size(100, 23);
            this.lblply4NoTurnsInJail.TabIndex = 23;
            this.lblply4NoTurnsInJail.Text = "Antal omgångar:";
            this.lblply4NoTurnsInJail.Visible = false;
            // 
            // lblply2InJail
            // 
            this.lblply2InJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply2InJail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblply2InJail.ForeColor = System.Drawing.Color.Red;
            this.lblply2InJail.Location = new System.Drawing.Point(460, 145);
            this.lblply2InJail.Name = "lblply2InJail";
            this.lblply2InJail.Size = new System.Drawing.Size(100, 23);
            this.lblply2InJail.TabIndex = 22;
            this.lblply2InJail.Text = "I FÄNGELSE";
            this.lblply2InJail.Visible = false;
            // 
            // lblply1InJail
            // 
            this.lblply1InJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply1InJail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblply1InJail.ForeColor = System.Drawing.Color.Red;
            this.lblply1InJail.Location = new System.Drawing.Point(92, 145);
            this.lblply1InJail.Name = "lblply1InJail";
            this.lblply1InJail.Size = new System.Drawing.Size(100, 23);
            this.lblply1InJail.TabIndex = 21;
            this.lblply1InJail.Text = "I FÄNGELSE";
            this.lblply1InJail.Visible = false;
            // 
            // lblply4InJail
            // 
            this.lblply4InJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply4InJail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblply4InJail.ForeColor = System.Drawing.Color.Red;
            this.lblply4InJail.Location = new System.Drawing.Point(460, 498);
            this.lblply4InJail.Name = "lblply4InJail";
            this.lblply4InJail.Size = new System.Drawing.Size(100, 23);
            this.lblply4InJail.TabIndex = 20;
            this.lblply4InJail.Text = "I FÄNGELSE";
            this.lblply4InJail.Visible = false;
            // 
            // lblply3InJail
            // 
            this.lblply3InJail.BackColor = System.Drawing.Color.Transparent;
            this.lblply3InJail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblply3InJail.ForeColor = System.Drawing.Color.Red;
            this.lblply3InJail.Location = new System.Drawing.Point(92, 498);
            this.lblply3InJail.Name = "lblply3InJail";
            this.lblply3InJail.Size = new System.Drawing.Size(100, 23);
            this.lblply3InJail.TabIndex = 19;
            this.lblply3InJail.Text = "I FÄNGELSE";
            this.lblply3InJail.Visible = false;
            // 
            // lblply4Info
            // 
            this.lblply4Info.BackColor = System.Drawing.Color.Transparent;
            this.lblply4Info.Location = new System.Drawing.Point(460, 457);
            this.lblply4Info.Name = "lblply4Info";
            this.lblply4Info.Size = new System.Drawing.Size(100, 64);
            this.lblply4Info.TabIndex = 18;
            this.lblply4Info.Text = "ply4Info";
            // 
            // lblply3Info
            // 
            this.lblply3Info.BackColor = System.Drawing.Color.Transparent;
            this.lblply3Info.Location = new System.Drawing.Point(92, 457);
            this.lblply3Info.Name = "lblply3Info";
            this.lblply3Info.Size = new System.Drawing.Size(100, 64);
            this.lblply3Info.TabIndex = 17;
            this.lblply3Info.Text = "ply3Info";
            // 
            // lblply2Inf
            // 
            this.lblply2Inf.BackColor = System.Drawing.Color.Transparent;
            this.lblply2Inf.Location = new System.Drawing.Point(460, 112);
            this.lblply2Inf.Name = "lblply2Inf";
            this.lblply2Inf.Size = new System.Drawing.Size(107, 56);
            this.lblply2Inf.TabIndex = 16;
            this.lblply2Inf.Text = "ply2Info";
            // 
            // lblply1Info
            // 
            this.lblply1Info.BackColor = System.Drawing.Color.Transparent;
            this.lblply1Info.Location = new System.Drawing.Point(92, 112);
            this.lblply1Info.Name = "lblply1Info";
            this.lblply1Info.Size = new System.Drawing.Size(100, 56);
            this.lblply1Info.TabIndex = 15;
            this.lblply1Info.Text = "ply1Info";
            // 
            // lblPlayerInfo
            // 
            this.lblPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayerInfo.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInfo.Location = new System.Drawing.Point(254, 235);
            this.lblPlayerInfo.Name = "lblPlayerInfo";
            this.lblPlayerInfo.Size = new System.Drawing.Size(162, 116);
            this.lblPlayerInfo.TabIndex = 14;
            this.lblPlayerInfo.Text = "Player Info";
            // 
            // lblFreePark
            // 
            this.lblFreePark.AutoSize = true;
            this.lblFreePark.BackColor = System.Drawing.Color.Transparent;
            this.lblFreePark.Location = new System.Drawing.Point(4, 4);
            this.lblFreePark.Name = "lblFreePark";
            this.lblFreePark.Size = new System.Drawing.Size(13, 13);
            this.lblFreePark.TabIndex = 4;
            this.lblFreePark.Text = "0";
            // 
            // picPlayer3
            // 
            this.picPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayer3.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer3.Image")));
            this.picPlayer3.InitialImage = null;
            this.picPlayer3.Location = new System.Drawing.Point(596, 596);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(20, 20);
            this.picPlayer3.TabIndex = 3;
            this.picPlayer3.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer2.Image")));
            this.picPlayer2.InitialImage = null;
            this.picPlayer2.Location = new System.Drawing.Point(596, 570);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(20, 20);
            this.picPlayer2.TabIndex = 2;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer1.Image")));
            this.picPlayer1.InitialImage = null;
            this.picPlayer1.Location = new System.Drawing.Point(570, 596);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(20, 20);
            this.picPlayer1.TabIndex = 1;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer0
            // 
            this.picPlayer0.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayer0.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer0.Image")));
            this.picPlayer0.InitialImage = null;
            this.picPlayer0.Location = new System.Drawing.Point(570, 570);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(20, 20);
            this.picPlayer0.TabIndex = 0;
            this.picPlayer0.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(654, 53);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(40, 32);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(654, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(40, 35);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tmrMovePlayer
            // 
            this.tmrMovePlayer.Interval = 40;
            this.tmrMovePlayer.Tick += new System.EventHandler(this.tmrMovePlayer_Tick);
            // 
            // btnRollDices
            // 
            this.btnRollDices.Location = new System.Drawing.Point(700, 41);
            this.btnRollDices.Name = "btnRollDices";
            this.btnRollDices.Size = new System.Drawing.Size(75, 23);
            this.btnRollDices.TabIndex = 4;
            this.btnRollDices.Text = "Slå tärningar";
            this.btnRollDices.UseVisualStyleBackColor = true;
            this.btnRollDices.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // lblDice1
            // 
            this.lblDice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(654, 360);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(30, 30);
            this.lblDice1.TabIndex = 5;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice2
            // 
            this.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(684, 360);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(30, 30);
            this.lblDice2.TabIndex = 6;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(654, 390);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 30);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(700, 12);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 8;
            this.btnTrade.Text = "Byt";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // lblSquareInfo
            // 
            this.lblSquareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSquareInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquareInfo.Location = new System.Drawing.Point(654, 420);
            this.lblSquareInfo.Name = "lblSquareInfo";
            this.lblSquareInfo.Size = new System.Drawing.Size(132, 219);
            this.lblSquareInfo.TabIndex = 9;
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Enabled = false;
            this.btnNextPlayer.Location = new System.Drawing.Point(700, 70);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnNextPlayer.TabIndex = 10;
            this.btnNextPlayer.Text = "Nästa";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // btnBuyStreet
            // 
            this.btnBuyStreet.Location = new System.Drawing.Point(700, 99);
            this.btnBuyStreet.Name = "btnBuyStreet";
            this.btnBuyStreet.Size = new System.Drawing.Size(75, 23);
            this.btnBuyStreet.TabIndex = 12;
            this.btnBuyStreet.Text = "Köp gata";
            this.btnBuyStreet.UseVisualStyleBackColor = true;
            this.btnBuyStreet.Visible = false;
            this.btnBuyStreet.Click += new System.EventHandler(this.btnBuyStreet_Click);
            // 
            // btnSellStreet
            // 
            this.btnSellStreet.Location = new System.Drawing.Point(700, 128);
            this.btnSellStreet.Name = "btnSellStreet";
            this.btnSellStreet.Size = new System.Drawing.Size(95, 23);
            this.btnSellStreet.TabIndex = 12;
            this.btnSellStreet.Text = "Hantera gator";
            this.btnSellStreet.UseVisualStyleBackColor = true;
            this.btnSellStreet.Visible = false;
            this.btnSellStreet.Click += new System.EventHandler(this.btnManageStreet_Click);
            // 
            // sfdSaveGame
            // 
            this.sfdSaveGame.DefaultExt = "mon";
            this.sfdSaveGame.Filter = "Monopol sparfil(*.mon)|*.mon";
            this.sfdSaveGame.Title = "Spara ditt monopolspel";
            // 
            // btnBankrupt
            // 
            this.btnBankrupt.Location = new System.Drawing.Point(720, 303);
            this.btnBankrupt.Name = "btnBankrupt";
            this.btnBankrupt.Size = new System.Drawing.Size(75, 23);
            this.btnBankrupt.TabIndex = 14;
            this.btnBankrupt.Text = "Gå i konkurs";
            this.btnBankrupt.UseVisualStyleBackColor = true;
            this.btnBankrupt.Visible = false;
            this.btnBankrupt.Click += new System.EventHandler(this.btnBankrupt_Click);
            // 
            // btnBail
            // 
            this.btnBail.Location = new System.Drawing.Point(704, 274);
            this.btnBail.Name = "btnBail";
            this.btnBail.Size = new System.Drawing.Size(91, 23);
            this.btnBail.TabIndex = 15;
            this.btnBail.Text = "Betala borgen";
            this.btnBail.UseVisualStyleBackColor = true;
            this.btnBail.Visible = false;
            this.btnBail.Click += new System.EventHandler(this.btnBail_Click);
            // 
            // frmMonopoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(798, 648);
            this.Controls.Add(this.btnBail);
            this.Controls.Add(this.btnBankrupt);
            this.Controls.Add(this.btnSellStreet);
            this.Controls.Add(this.btnBuyStreet);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.lblSquareInfo);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.btnRollDices);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonopoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monopol";
            this.Load += new System.EventHandler(this.Monopoly_Load);
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer tmrMovePlayer;
        public System.Windows.Forms.PictureBox picPlayer0;
        public System.Windows.Forms.PictureBox picPlayer1;
        public System.Windows.Forms.PictureBox picPlayer3;
        public System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Label lblSquareInfo;
        private System.Windows.Forms.Button btnSellStreet;
        private System.Windows.Forms.Button btnBuyStreet;
        private System.Windows.Forms.SaveFileDialog sfdSaveGame;
        private System.Windows.Forms.Label lblFreePark;
        private System.Windows.Forms.Label lblPlayerInfo;
        private Label lblply2Inf;
        private Label lblply1Info;
        private Label lblply4Info;
        private Label lblply3Info;
        private Label lblply2InJail;
        private Label lblply1InJail;
        private Label lblply4InJail;
        private Label lblply3InJail;
        private Label lblply2NoTurnsInJail;
        private Label lblply1NoTurnsInJail;
        private Label lblply3NoTurnsInJail;
        private Label lblply4NoTurnsInJail;
        public Button btnBankrupt;
        public Button btnRollDices;
        public Button btnNextPlayer;
        public Button btnBail;
    }
}

