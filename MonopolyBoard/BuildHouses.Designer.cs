namespace MonopolyBoard
{
    partial class BuildHouses
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
            this.btnMortgage = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnBuyHouse = new System.Windows.Forms.Button();
            this.btnSellHouse = new System.Windows.Forms.Button();
            this.lbStreets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMortgage
            // 
            this.btnMortgage.Location = new System.Drawing.Point(158, 26);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(83, 23);
            this.btnMortgage.TabIndex = 1;
            this.btnMortgage.Text = "Inteckna gata";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(311, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(149, 173);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "label1";
            // 
            // btnBuyHouse
            // 
            this.btnBuyHouse.Enabled = false;
            this.btnBuyHouse.Location = new System.Drawing.Point(158, 55);
            this.btnBuyHouse.Name = "btnBuyHouse";
            this.btnBuyHouse.Size = new System.Drawing.Size(83, 23);
            this.btnBuyHouse.TabIndex = 3;
            this.btnBuyHouse.Text = "Köp hus";
            this.btnBuyHouse.UseVisualStyleBackColor = true;
            this.btnBuyHouse.Click += new System.EventHandler(this.btnBuyHouse_Click);
            // 
            // btnSellHouse
            // 
            this.btnSellHouse.Enabled = false;
            this.btnSellHouse.Location = new System.Drawing.Point(158, 84);
            this.btnSellHouse.Name = "btnSellHouse";
            this.btnSellHouse.Size = new System.Drawing.Size(83, 23);
            this.btnSellHouse.TabIndex = 4;
            this.btnSellHouse.Text = "Sälj hus";
            this.btnSellHouse.UseVisualStyleBackColor = true;
            this.btnSellHouse.Click += new System.EventHandler(this.btnSellHouse_Click);
            // 
            // lbStreets
            // 
            this.lbStreets.FormattingEnabled = true;
            this.lbStreets.Location = new System.Drawing.Point(12, 12);
            this.lbStreets.Name = "lbStreets";
            this.lbStreets.Size = new System.Drawing.Size(140, 173);
            this.lbStreets.TabIndex = 5;
            this.lbStreets.SelectedIndexChanged += new System.EventHandler(this.lbStreets_SelectedIndexChanged);
            // 
            // SellStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 194);
            this.Controls.Add(this.lbStreets);
            this.Controls.Add(this.btnSellHouse);
            this.Controls.Add(this.btnBuyHouse);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnMortgage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SellStreet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellStreet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SellStreet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnBuyHouse;
        private System.Windows.Forms.Button btnSellHouse;
        private System.Windows.Forms.ListBox lbStreets;
    }
}