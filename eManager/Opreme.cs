using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager
{
    public class Opreme
    {
        public int ID_oprema { get; set; }
        public string Dobavljac { get; set; }
        public DateTime Datum { get; set; }
        public string IzvorFinancija { get; set; }
        public string NazivProjekta { get; set; }
        public string VrstaOpreme { get; set; }
        public string NazivOpreme { get; set; }
        public string OpisOpreme { get; set; }
        public string Zaprimac { get; set; }
    }
}
