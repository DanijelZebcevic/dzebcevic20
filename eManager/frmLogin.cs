﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtIme = txtKorisnickoIme.Text;
            string password = txtLozinka.Text;
            bool tocanUnos = Repository.Autoriziraj(txtIme, password);
            if (tocanUnos)
            {
                frmPrikazOpreme prikazForma = new frmPrikazOpreme();
                prikazForma.Show();
                frmLogin form = new frmLogin();
                form = this;
                form.Hide();
            }            
        }
    }
}
