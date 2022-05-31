using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager
{
    public class Korisnici
    {
        public int ID_korisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int IsAdmin { get; set; }
    }
}
