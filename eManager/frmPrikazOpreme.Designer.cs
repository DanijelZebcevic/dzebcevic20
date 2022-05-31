namespace eManager
{
    partial class frmPrikazOpreme
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
            this.dataGridOprema = new System.Windows.Forms.DataGridView();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnAzuriranje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz opreme";
            // 
            // dataGridOprema
            // 
            this.dataGridOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOprema.Location = new System.Drawing.Point(62, 92);
            this.dataGridOprema.Name = "dataGridOprema";
            this.dataGridOprema.RowHeadersWidth = 51;
            this.dataGridOprema.RowTemplate.Height = 24;
            this.dataGridOprema.Size = new System.Drawing.Size(1333, 372);
            this.dataGridOprema.TabIndex = 2;
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Location = new System.Drawing.Point(62, 589);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(184, 57);
            this.btnDodajOpremu.TabIndex = 3;
            this.btnDodajOpremu.Text = "Dodaj";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(330, 588);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(170, 57);
            this.btnBrisanje.TabIndex = 4;
            this.btnBrisanje.Text = "Obriši";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnAzuriranje
            // 
            this.btnAzuriranje.Location = new System.Drawing.Point(632, 588);
            this.btnAzuriranje.Name = "btnAzuriranje";
            this.btnAzuriranje.Size = new System.Drawing.Size(143, 57);
            this.btnAzuriranje.TabIndex = 5;
            this.btnAzuriranje.Text = "Ažuriraj";
            this.btnAzuriranje.UseVisualStyleBackColor = true;
            this.btnAzuriranje.Click += new System.EventHandler(this.btnAzuriranje_Click);
            // 
            // frmPrikazOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 724);
            this.Controls.Add(this.btnAzuriranje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.dataGridOprema);
            this.Controls.Add(this.label1);
            this.Name = "frmPrikazOpreme";
            this.Text = "frmPrikazOpreme";
            this.Load += new System.EventHandler(this.frmPrikazOpreme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOprema;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnAzuriranje;
    }
}