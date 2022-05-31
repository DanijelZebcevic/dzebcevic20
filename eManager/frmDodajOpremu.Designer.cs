namespace eManager
{
    partial class frmDodajOpremu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIzvorFinancija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrstaOpreme = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpisOpreme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtZaprimac = new System.Windows.Forms.TextBox();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma za unos opreme";
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(42, 145);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(288, 22);
            this.txtDobavljac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dobavljač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrijeme zaprimanja";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(42, 226);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(288, 22);
            this.txtDatum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Izvor financiranja";
            // 
            // txtIzvorFinancija
            // 
            this.txtIzvorFinancija.FormattingEnabled = true;
            this.txtIzvorFinancija.Items.AddRange(new object[] {
            "STEM games",
            "tjedan karijera",
            "CPSRK suradnja",
            "CECIIS"});
            this.txtIzvorFinancija.Location = new System.Drawing.Point(42, 315);
            this.txtIzvorFinancija.Name = "txtIzvorFinancija";
            this.txtIzvorFinancija.Size = new System.Drawing.Size(288, 24);
            this.txtIzvorFinancija.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Naziv projekta";
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(42, 406);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(288, 22);
            this.txtNazivProjekta.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(922, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vrsta opreme";
            // 
            // txtVrstaOpreme
            // 
            this.txtVrstaOpreme.FormattingEnabled = true;
            this.txtVrstaOpreme.Items.AddRange(new object[] {
            "Racunalna oprema",
            "Komunikacijska oprema",
            "Multimedijska oprema",
            "Licenca",
            "Pretplata"});
            this.txtVrstaOpreme.Location = new System.Drawing.Point(927, 145);
            this.txtVrstaOpreme.Name = "txtVrstaOpreme";
            this.txtVrstaOpreme.Size = new System.Drawing.Size(288, 24);
            this.txtVrstaOpreme.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(922, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Naziv opreme";
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Location = new System.Drawing.Point(927, 226);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(288, 22);
            this.txtNazivOpreme.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(922, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Opis opreme";
            // 
            // txtOpisOpreme
            // 
            this.txtOpisOpreme.Location = new System.Drawing.Point(927, 327);
            this.txtOpisOpreme.Multiline = true;
            this.txtOpisOpreme.Name = "txtOpisOpreme";
            this.txtOpisOpreme.Size = new System.Drawing.Size(450, 130);
            this.txtOpisOpreme.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(922, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Zaprimač";
            // 
            // txtZaprimac
            // 
            this.txtZaprimac.Location = new System.Drawing.Point(927, 521);
            this.txtZaprimac.Name = "txtZaprimac";
            this.txtZaprimac.Size = new System.Drawing.Size(288, 22);
            this.txtZaprimac.TabIndex = 16;
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(637, 600);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(198, 67);
            this.btnDodavanje.TabIndex = 17;
            this.btnDodavanje.Text = "Dodaj";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            // 
            // frmDodajOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 734);
            this.Controls.Add(this.btnDodavanje);
            this.Controls.Add(this.txtZaprimac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpisOpreme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVrstaOpreme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazivProjekta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIzvorFinancija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajOpremu";
            this.Text = "frmDodajOpremu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtIzvorFinancija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtVrstaOpreme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtZaprimac;
        private System.Windows.Forms.Button btnDodavanje;
    }
}