namespace MonopolyBoard
{
    partial class Trade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtMoneyA = new System.Windows.Forms.MaskedTextBox();
            this.txtMoneyA = new System.Windows.Forms.TextBox();
            this.cbMoneyA = new System.Windows.Forms.CheckBox();
            this.clbPlayerA = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtMoneyB = new System.Windows.Forms.MaskedTextBox();
            this.txtMoneyB = new System.Windows.Forms.TextBox();
            this.cbMoneyB = new System.Windows.Forms.CheckBox();
            this.clbPlayerB = new System.Windows.Forms.CheckedListBox();
            this.AtoB = new System.Windows.Forms.Button();
            this.BtoA = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtMoneyA);
            this.groupBox1.Controls.Add(this.txtMoneyA);
            this.groupBox1.Controls.Add(this.cbMoneyA);
            this.groupBox1.Controls.Add(this.clbPlayerA);
            this.groupBox1.Location = new System.Drawing.Point(26, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player A";
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
            // 
            // cbMoneyA
            // 
            this.cbMoneyA.AutoSize = true;
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
            this.clbPlayerA.FormattingEnabled = true;
            this.clbPlayerA.Location = new System.Drawing.Point(6, 19);
            this.clbPlayerA.Name = "clbPlayerA";
            this.clbPlayerA.Size = new System.Drawing.Size(188, 199);
            this.clbPlayerA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtMoneyB);
            this.groupBox2.Controls.Add(this.txtMoneyB);
            this.groupBox2.Controls.Add(this.cbMoneyB);
            this.groupBox2.Controls.Add(this.clbPlayerB);
            this.groupBox2.Location = new System.Drawing.Point(345, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player B";
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
            this.clbPlayerB.FormattingEnabled = true;
            this.clbPlayerB.Location = new System.Drawing.Point(6, 19);
            this.clbPlayerB.Name = "clbPlayerB";
            this.clbPlayerB.Size = new System.Drawing.Size(188, 199);
            this.clbPlayerB.TabIndex = 0;
            // 
            // AtoB
            // 
            this.AtoB.Location = new System.Drawing.Point(246, 127);
            this.AtoB.Name = "AtoB";
            this.AtoB.Size = new System.Drawing.Size(75, 23);
            this.AtoB.TabIndex = 2;
            this.AtoB.Text = "-->";
            this.AtoB.UseVisualStyleBackColor = true;
            this.AtoB.Click += new System.EventHandler(this.AtoB_Click);
            // 
            // BtoA
            // 
            this.BtoA.Location = new System.Drawing.Point(246, 156);
            this.BtoA.Name = "BtoA";
            this.BtoA.Size = new System.Drawing.Size(75, 23);
            this.BtoA.TabIndex = 3;
            this.BtoA.Text = "<--";
            this.BtoA.UseVisualStyleBackColor = true;
            this.BtoA.Click += new System.EventHandler(this.BtoA_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(246, 185);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 4;
            this.btnTrade.Text = "<-->";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.trade_Click);
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.BtoA);
            this.Controls.Add(this.AtoB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trade";
            this.Text = "Trade";
            this.Load += new System.EventHandler(this.Trade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMoneyA;
        private System.Windows.Forms.CheckBox cbMoneyA;
        private System.Windows.Forms.CheckedListBox clbPlayerA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMoneyB;
        private System.Windows.Forms.CheckBox cbMoneyB;
        private System.Windows.Forms.CheckedListBox clbPlayerB;
        private System.Windows.Forms.Button AtoB;
        private System.Windows.Forms.Button BtoA;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.MaskedTextBox mtxtMoneyA;
        private System.Windows.Forms.MaskedTextBox mtxtMoneyB;
    }
}

