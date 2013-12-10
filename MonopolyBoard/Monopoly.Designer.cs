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
            this.pnlMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainPanel.BackgroundImage")));
            this.pnlMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // picPlayer3
            // 
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
            this.btnTest.Click += new System.EventHandler(this.btnMove_Click);
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
            this.lblDice1.Location = new System.Drawing.Point(664, 253);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(30, 30);
            this.lblDice1.TabIndex = 5;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice2
            // 
            this.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(694, 253);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(30, 30);
            this.lblDice2.TabIndex = 6;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(664, 283);
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
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // lblSquareInfo
            // 
            this.lblSquareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSquareInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquareInfo.Location = new System.Drawing.Point(654, 396);
            this.lblSquareInfo.Name = "lblSquareInfo";
            this.lblSquareInfo.Size = new System.Drawing.Size(132, 243);
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
            // frmMonopoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(798, 648);
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
        private System.Windows.Forms.Button btnRollDices;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Label lblSquareInfo;
        private System.Windows.Forms.Button btnNextPlayer;
    }
}

