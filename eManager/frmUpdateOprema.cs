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
    public partial class frmUpdateOprema : Form
    {
        public frmUpdateOprema()
        {
            InitializeComponent();
        }

        private void frmUpdateOprema_Load(object sender, EventArgs e)
        {
            Opreme azurirani = Repository.UcitajJednuOpremu();
            azuriranFinancije.Text = azurirani.IzvorFinancija;
            azuriranaVrstaOpreme.Text = azurirani.VrstaOpreme;
            azuriranNazivOpreme.Text=azurirani.NazivOpreme;
            azuriranDatum.Text = Convert.ToString(azurirani.Datum);
            azuriranDobavljac.Text = azurirani.Dobavljac;
            azuriranNazivProjekta.Text = azurirani.NazivProjekta;
            azuriranZaprimac.Text = azurirani.Zaprimac;
            azuriranOpisOpreme.Text = azurirani.OpisOpreme;
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Opreme trenutni = Repository.UcitajJednuOpremu();
            int identifikator = trenutni.ID_oprema;
            string imeDobavljaca = azuriranDobavljac.Text;
            string vrijeme = azuriranDatum.Text;
            string izvorFinanciranja = azuriranFinancije.Text;
            string nazivProjekta = azuriranNazivProjekta.Text;
            string vrstaOpreme = azuriranaVrstaOpreme.Text;
            string nazivOpreme = azuriranNazivOpreme.Text;
            string opisOpreme = azuriranOpisOpreme.Text;
            string zaprimac = azuriranZaprimac.Text;

            if (imeDobavljaca != "" && vrijeme != "" && izvorFinanciranja != "" && nazivProjekta != "" && vrstaOpreme != "" && nazivOpreme != "" && opisOpreme != "" && zaprimac != "" )
            {
                Repository.UpdateOprema(identifikator, imeDobavljaca, vrijeme, izvorFinanciranja, nazivProjekta, vrstaOpreme, nazivOpreme, opisOpreme, zaprimac);
            }

            else
            {
                MessageBox.Show("Niste unesli sve podatke.");
            }

            frmUpdateOprema trenutnaForma = new frmUpdateOprema();
            trenutnaForma = this;
            frmPrikazOpreme formaZaPrikaz = new frmPrikazOpreme();
            trenutnaForma.Hide();
            formaZaPrikaz.Show();
        }
    }
}
