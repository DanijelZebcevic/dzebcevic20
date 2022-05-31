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
    public partial class frmPrikazOpreme : Form
    {
        public frmPrikazOpreme()
        {
            InitializeComponent();
        }

        private void frmPrikazOpreme_Load(object sender, EventArgs e)
        {
            dataGridOprema.DataSource = null;
            dataGridOprema.DataSource = Repository.DohvatiOpremu();
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            frmDodajOpremu formaDodavanje = new frmDodajOpremu();
            formaDodavanje.Show();
            frmPrikazOpreme formaPrikaz = new frmPrikazOpreme();
            formaPrikaz = this;
            formaPrikaz.Hide();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
           Opreme oprema = dataGridOprema.CurrentRow.DataBoundItem as Opreme;
           Repository.BrisiOpremu(oprema.ID_oprema);
           dataGridOprema.DataSource = null;
           dataGridOprema.DataSource = Repository.DohvatiOpremu();
        }

        private void btnAzuriranje_Click(object sender, EventArgs e)
        {
            Opreme oprema1 = dataGridOprema.CurrentRow.DataBoundItem as Opreme;
            frmPrikazOpreme prikaz = new frmPrikazOpreme();
            prikaz = this;
            frmUpdateOprema formaAzuriranja = new frmUpdateOprema();
            Repository.DohvatiJednuOpremu(oprema1);
            prikaz.Hide();
            formaAzuriranja.Show();
        }
    }
}
