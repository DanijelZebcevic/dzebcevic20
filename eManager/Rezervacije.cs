using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager
{
    public class Rezervacije
    {
        public int ID_rezervacije { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int ID_oprema { get; set; }
        public int ID_korisnika { get; set; }
    }
}
