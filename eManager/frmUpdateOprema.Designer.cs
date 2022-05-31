namespace eManager
{
    partial class frmUpdateOprema
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
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.azuriranZaprimac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.azuriranOpisOpreme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.azuriranNazivOpreme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.azuriranaVrstaOpreme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.azuriranNazivProjekta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.azuriranFinancije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.azuriranDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.azuriranDobavljac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma za ažuriranje opreme";
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(597, 639);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(198, 67);
            this.btnDodavanje.TabIndex = 35;
            this.btnDodavanje.Text = "Ažuriraj";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            // 
            // azuriranZaprimac
            // 
            this.azuriranZaprimac.Location = new System.Drawing.Point(981, 560);
            this.azuriranZaprimac.Name = "azuriranZaprimac";
            this.azuriranZaprimac.Size = new System.Drawing.Size(288, 22);
            this.azuriranZaprimac.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(976, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Zaprimač";
            // 
            // azuriranOpisOpreme
            // 
            this.azuriranOpisOpreme.Location = new System.Drawing.Point(981, 366);
            this.azuriranOpisOpreme.Multiline = true;
            this.azuriranOpisOpreme.Name = "azuriranOpisOpreme";
            this.azuriranOpisOpreme.Size = new System.Drawing.Size(450, 130);
            this.azuriranOpisOpreme.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(976, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Opis opreme";
            // 
            // azuriranNazivOpreme
            // 
            this.azuriranNazivOpreme.Location = new System.Drawing.Point(981, 265);
            this.azuriranNazivOpreme.Name = "azuriranNazivOpreme";
            this.azuriranNazivOpreme.Size = new System.Drawing.Size(288, 22);
            this.azuriranNazivOpreme.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(976, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Naziv opreme";
            // 
            // azuriranaVrstaOpreme
            // 
            this.azuriranaVrstaOpreme.FormattingEnabled = true;
            this.azuriranaVrstaOpreme.Items.AddRange(new object[] {
            "Racunalna oprema",
            "Komunikacijska oprema",
            "Multimedijska oprema",
            "Licenca",
            "Pretplata"});
            this.azuriranaVrstaOpreme.Location = new System.Drawing.Point(981, 184);
            this.azuriranaVrstaOpreme.Name = "azuriranaVrstaOpreme";
            this.azuriranaVrstaOpreme.Size = new System.Drawing.Size(288, 24);
            this.azuriranaVrstaOpreme.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(976, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vrsta opreme";
            // 
            // azuriranNazivProjekta
            // 
            this.azuriranNazivProjekta.Location = new System.Drawing.Point(96, 445);
            this.azuriranNazivProjekta.Name = "azuriranNazivProjekta";
            this.azuriranNazivProjekta.Size = new System.Drawing.Size(288, 22);
            this.azuriranNazivProjekta.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Naziv projekta";
            // 
            // azuriranFinancije
            // 
            this.azuriranFinancije.FormattingEnabled = true;
            this.azuriranFinancije.Items.AddRange(new object[] {
            "STEM games",
            "tjedan karijera",
            "CPSRK suradnja",
            "CECIIS"});
            this.azuriranFinancije.Location = new System.Drawing.Point(96, 354);
            this.azuriranFinancije.Name = "azuriranFinancije";
            this.azuriranFinancije.Size = new System.Drawing.Size(288, 24);
            this.azuriranFinancije.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Izvor financiranja";
            // 
            // azuriranDatum
            // 
            this.azuriranDatum.Location = new System.Drawing.Point(96, 265);
            this.azuriranDatum.Name = "azuriranDatum";
            this.azuriranDatum.Size = new System.Drawing.Size(288, 22);
            this.azuriranDatum.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vrijeme zaprimanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dobavljač";
            // 
            // azuriranDobavljac
            // 
            this.azuriranDobavljac.Location = new System.Drawing.Point(96, 184);
            this.azuriranDobavljac.Name = "azuriranDobavljac";
            this.azuriranDobavljac.Size = new System.Drawing.Size(288, 22);
            this.azuriranDobavljac.TabIndex = 19;
            // 
            // frmUpdateOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 762);
            this.Controls.Add(this.btnDodavanje);
            this.Controls.Add(this.azuriranZaprimac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.azuriranOpisOpreme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.azuriranNazivOpreme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.azuriranaVrstaOpreme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.azuriranNazivProjekta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.azuriranFinancije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.azuriranDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.azuriranDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateOprema";
            this.Text = "frmUpdateOprema";
            this.Load += new System.EventHandler(this.frmUpdateOprema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.TextBox azuriranZaprimac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox azuriranOpisOpreme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox azuriranNazivOpreme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox azuriranaVrstaOpreme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox azuriranNazivProjekta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox azuriranFinancije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox azuriranDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox azuriranDobavljac;
    }
}