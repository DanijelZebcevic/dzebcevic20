//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervacija
    {
        public int ID_rezervacije { get; set; }
        public System.DateTime datumRezervacije { get; set; }
        public int ID_oprema { get; set; }
        public int ID_korisnika { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Oprema Oprema { get; set; }
    }
}