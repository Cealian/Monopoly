namespace MonopolyBoard
{
    partial class Monopoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monopoly));
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.tmrMovePlayer = new System.Windows.Forms.Timer(this.components);
            this.txtNumberOfSteps = new System.Windows.Forms.TextBox();
            this.btnTurn = new System.Windows.Forms.Button();
            this.lbldice1 = new System.Windows.Forms.Label();
            this.lbldice2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnTrade = new System.Windows.Forms.Button();
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
            this.picPlayer3.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPlayer3.InitialImage")));
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
            this.picPlayer2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPlayer2.InitialImage")));
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
            this.picPlayer1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPlayer1.InitialImage")));
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
            this.picPlayer0.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPlayer0.InitialImage")));
            this.picPlayer0.Location = new System.Drawing.Point(570, 570);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(20, 20);
            this.picPlayer0.TabIndex = 0;
            this.picPlayer0.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(654, 38);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(40, 32);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(691, 12);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 20);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tmrMovePlayer
            // 
            this.tmrMovePlayer.Interval = 40;
            this.tmrMovePlayer.Tick += new System.EventHandler(this.tmrMovePlayer_Tick);
            // 
            // txtNumberOfSteps
            // 
            this.txtNumberOfSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfSteps.Location = new System.Drawing.Point(654, 12);
            this.txtNumberOfSteps.Name = "txtNumberOfSteps";
            this.txtNumberOfSteps.Size = new System.Drawing.Size(31, 20);
            this.txtNumberOfSteps.TabIndex = 3;
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(654, 86);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(75, 23);
            this.btnTurn.TabIndex = 4;
            this.btnTurn.Text = "Slå tärningar";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // lbldice1
            // 
            this.lbldice1.AutoSize = true;
            this.lbldice1.Location = new System.Drawing.Point(665, 132);
            this.lbldice1.Name = "lbldice1";
            this.lbldice1.Size = new System.Drawing.Size(35, 13);
            this.lbldice1.TabIndex = 5;
            this.lbldice1.Text = "label1";
            // 
            // lbldice2
            // 
            this.lbldice2.AutoSize = true;
            this.lbldice2.Location = new System.Drawing.Point(717, 132);
            this.lbldice2.Name = "lbldice2";
            this.lbldice2.Size = new System.Drawing.Size(35, 13);
            this.lbldice2.TabIndex = 6;
            this.lbldice2.Text = "label2";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(688, 165);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "label3";
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(668, 300);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 8;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // Monopoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(798, 648);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbldice2);
            this.Controls.Add(this.lbldice1);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.txtNumberOfSteps);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monopoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monopol";
            this.Load += new System.EventHandler(this.Monopoly_Load);
            this.pnlMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Timer tmrMovePlayer;
        public System.Windows.Forms.PictureBox picPlayer0;
        private System.Windows.Forms.TextBox txtNumberOfSteps;
        public System.Windows.Forms.PictureBox picPlayer1;
        public System.Windows.Forms.PictureBox picPlayer3;
        public System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Label lbldice1;
        private System.Windows.Forms.Label lbldice2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnTrade;
    }
}

