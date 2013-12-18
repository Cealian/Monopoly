namespace MonopolyBoard
{
    partial class New_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_game));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer3 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(48, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skriv i spelarnas namn:";
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.BackColor = System.Drawing.Color.Red;
            this.txtBoxPlayer1.ForeColor = System.Drawing.Color.White;
            this.txtBoxPlayer1.Location = new System.Drawing.Point(20, 61);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPlayer1.TabIndex = 0;
            this.txtBoxPlayer1.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.BackColor = System.Drawing.Color.Gray;
            this.txtBoxPlayer2.Enabled = false;
            this.txtBoxPlayer2.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBoxPlayer2.Location = new System.Drawing.Point(20, 102);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPlayer2.TabIndex = 1;
            this.txtBoxPlayer2.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // txtBoxPlayer3
            // 
            this.txtBoxPlayer3.BackColor = System.Drawing.Color.Gray;
            this.txtBoxPlayer3.Enabled = false;
            this.txtBoxPlayer3.Location = new System.Drawing.Point(20, 146);
            this.txtBoxPlayer3.Name = "txtBoxPlayer3";
            this.txtBoxPlayer3.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPlayer3.TabIndex = 2;
            this.txtBoxPlayer3.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // txtBoxPlayer4
            // 
            this.txtBoxPlayer4.BackColor = System.Drawing.Color.Gray;
            this.txtBoxPlayer4.Enabled = false;
            this.txtBoxPlayer4.Location = new System.Drawing.Point(20, 191);
            this.txtBoxPlayer4.Name = "txtBoxPlayer4";
            this.txtBoxPlayer4.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPlayer4.TabIndex = 3;
            this.txtBoxPlayer4.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(177, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(177, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(177, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // New_game
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(298, 306);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxPlayer4);
            this.Controls.Add(this.txtBoxPlayer3);
            this.Controls.Add(this.txtBoxPlayer2);
            this.Controls.Add(this.txtBoxPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Name = "New_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlayer1;
        private System.Windows.Forms.TextBox txtBoxPlayer2;
        private System.Windows.Forms.TextBox txtBoxPlayer3;
        private System.Windows.Forms.TextBox txtBoxPlayer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}