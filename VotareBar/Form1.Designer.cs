namespace VotareBar
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.prg3 = new System.Windows.Forms.ProgressBar();
            this.prg2 = new System.Windows.Forms.ProgressBar();
            this.prg1 = new System.Windows.Forms.ProgressBar();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.AutoSize = true;
            this.grp1.Controls.Add(this.btn1);
            this.grp1.Controls.Add(this.rdb3);
            this.grp1.Controls.Add(this.rdb2);
            this.grp1.Controls.Add(this.rdb1);
            this.grp1.Location = new System.Drawing.Point(12, 62);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(372, 127);
            this.grp1.TabIndex = 1;
            this.grp1.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(84, 72);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(213, 36);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Vota";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.UseWaitCursor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(311, 19);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(55, 17);
            this.rdb3.TabIndex = 2;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Ottimo";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(167, 19);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(64, 17);
            this.rdb2.TabIndex = 1;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Discreto";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoCheck = false;
            this.rdb1.AutoSize = true;
            this.rdb1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb1.Location = new System.Drawing.Point(6, 19);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(58, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Scarso";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.lbl3);
            this.grp2.Controls.Add(this.lbl2);
            this.grp2.Controls.Add(this.lbl1);
            this.grp2.Controls.Add(this.prg3);
            this.grp2.Controls.Add(this.prg2);
            this.grp2.Controls.Add(this.prg1);
            this.grp2.Location = new System.Drawing.Point(12, 195);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(372, 185);
            this.grp2.TabIndex = 2;
            this.grp2.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 137);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Ottimo";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Discreto";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Scarso";
            // 
            // prg3
            // 
            this.prg3.Location = new System.Drawing.Point(52, 121);
            this.prg3.Name = "prg3";
            this.prg3.Size = new System.Drawing.Size(314, 47);
            this.prg3.TabIndex = 2;
            // 
            // prg2
            // 
            this.prg2.Location = new System.Drawing.Point(52, 68);
            this.prg2.Name = "prg2";
            this.prg2.Size = new System.Drawing.Size(313, 47);
            this.prg2.TabIndex = 1;
            // 
            // prg1
            // 
            this.prg1.Location = new System.Drawing.Point(52, 19);
            this.prg1.Name = "prg1";
            this.prg1.Size = new System.Drawing.Size(314, 43);
            this.prg1.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt1.Location = new System.Drawing.Point(12, 14);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(371, 38);
            this.txt1.TabIndex = 3;
            this.txt1.Text = "Vota la qualità del servizio BAR";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 392);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Name = "frmMain";
            this.Text = "Indagine Statistica";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        public System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ProgressBar prg3;
        private System.Windows.Forms.ProgressBar prg2;
        private System.Windows.Forms.ProgressBar prg1;
        private System.Windows.Forms.TextBox txt1;
    }
}

