namespace MonopolyBoard
{
    partial class SellStreet
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
            this.clbStreets = new System.Windows.Forms.CheckedListBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbStreets
            // 
            this.clbStreets.CheckOnClick = true;
            this.clbStreets.FormattingEnabled = true;
            this.clbStreets.Location = new System.Drawing.Point(12, 12);
            this.clbStreets.Name = "clbStreets";
            this.clbStreets.Size = new System.Drawing.Size(195, 154);
            this.clbStreets.TabIndex = 0;
            this.clbStreets.SelectedIndexChanged += new System.EventHandler(this.clbStreets_SelectedIndexChanged);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(216, 37);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sälj gata";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(234, 103);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(35, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "label1";
            // 
            // SellStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 176);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.clbStreets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SellStreet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellStreet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SellStreet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbStreets;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lbPrice;
    }
}