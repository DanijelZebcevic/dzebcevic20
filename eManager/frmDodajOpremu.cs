using System;
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
    public partial class frmDodajOpremu : Form
    {
        public frmDodajOpremu()
        {
            InitializeComponent();
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            string imeDobavljaca = txtDobavljac.Text;
            string vrijeme = txtDatum.Text;
            string izvorFinanciranja = txtIzvorFinancija.Text;
            string nazivProjekta = txtNazivProjekta.Text;
            string vrstaOpreme = txtVrstaOpreme.Text;
            string nazivOpreme = txtNazivOpreme.Text;
            string opisOpreme = txtOpisOpreme.Text;
            string zaprimac = txtZaprimac.Text;

            if (imeDobavljaca != "" && vrijeme != "" && izvorFinanciranja != "" && nazivProjekta != "" && vrstaOpreme != "" && nazivOpreme != "" && opisOpreme != "" && zaprimac != "")
            {
                Repository.DodajOpremu(imeDobavljaca, vrijeme, izvorFinanciranja, nazivProjekta, vrstaOpreme, nazivOpreme, opisOpreme, zaprimac);

            }
            else
            {
                MessageBox.Show("Niste unesli sve podatke");
            }

            frmDodajOpremu trenutna = new frmDodajOpremu();
            frmPrikazOpreme prikaz = new frmPrikazOpreme();
            trenutna = this;
            trenutna.Hide();
            prikaz.Show();
        }
    }
}
