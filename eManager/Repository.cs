using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll;
namespace eManager
{
    public static class Repository
    {

        public static Opreme trenutno = new Opreme();
        public static List<Korisnici> DohvatiKorisnike()
        {
            string varijabla1;

            Korisnici korisnik = null;
            List<Korisnici> korisnici = new List<Korisnici>();
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }
            reader.Close();
            DB.CloseConnection();
            return korisnici;
        }

        public static bool Autoriziraj(string ime, string lozinka)
        {
            List<Korisnici> listaKorisnika = new List<Korisnici>();
            listaKorisnika = DohvatiKorisnike();
            bool tocno = false;
            foreach (var item in listaKorisnika)
            {
                if (item.KorisnickoIme.ToString().Contains(ime) && item.Lozinka.ToString().Contains(lozinka))
                {
                    tocno = true;
                }
            }

            return tocno;

        }

        private static Korisnici CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_korisnika"].ToString());
            string korIme= reader["korisnickoIme"].ToString();
            string lozinka = reader["lozinka"].ToString();
            int isAdmin =int.Parse( reader["isAdmin"].ToString() );
            var korisnik = new Korisnici
            {
                ID_korisnika = id,
                KorisnickoIme = korIme,
                Lozinka = lozinka,
                IsAdmin = isAdmin
            };
            return korisnik;
        }

        public static List<Opreme> DohvatiOpremu()
        {
            Opreme oprema = null;
            List<Opreme> popisOpreme = new List<Opreme>();
            string sql = "SELECT * FROM Oprema";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                oprema = CreateObject2(reader);
                popisOpreme.Add(oprema);
            }
            reader.Close();
            DB.CloseConnection();
            return popisOpreme;
        }

        public static void DohvatiJednuOpremu(Opreme trenutni)
        {
            trenutno = trenutni;
        }

        public static Opreme UcitajJednuOpremu()
        {
            return trenutno;
        }


        private static Opreme CreateObject2(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_oprema"].ToString());
            string dobavljac = reader["dobavljac"].ToString();
            DateTime datum = (DateTime)reader["datum"];
            string financije = reader["izvorFinancija"].ToString();
            string nazivProjekta = reader["nazivProjekta"].ToString();
            string vrstaOpreme = reader["vrstaOpreme"].ToString();
            string nazivOpreme = reader["nazivOpreme"].ToString();
            string opisOpreme = reader["opisOpreme"].ToString();
            string zaprimac = reader["zaprimac"].ToString();

            var oprema = new Opreme
            {
                ID_oprema = id,
                Dobavljac = dobavljac,
                Datum = datum,
                IzvorFinancija = financije,
                NazivProjekta = nazivProjekta,
                VrstaOpreme = vrstaOpreme,
                NazivOpreme = nazivOpreme,
                OpisOpreme = opisOpreme,
                Zaprimac = zaprimac
            };
            return oprema;
        }

        public static void DodajOpremu(string dobavljac, string datum, string financije, string imeProjekta, string vrOpreme, string imeOpreme, string opOpreme, string zaprimatelj)
        {
            if (dobavljac!="" && datum != "" && financije != "" && imeProjekta != "" && vrOpreme != "" && imeOpreme != "" && opOpreme != "" && zaprimatelj != "")
            {
                string sql = $"INSERT INTO Oprema (dobavljac, datum, izvorFinancija, nazivProjekta, vrstaOpreme, nazivOpreme, opisOpreme, zaprimac) VALUES('{dobavljac}', '{datum}', '{financije}', '{imeProjekta}', '{vrOpreme}', '{imeOpreme}', '{opOpreme}', '{zaprimatelj}')";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }

        }

        public static void BrisiOpremu(int id)
        {
            string sql = $"DELETE FROM Oprema WHERE ID_oprema = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateOprema(int id, string dobavljac, string datum, string financije, string imeProjekta, string vrOpreme, string imeOpreme, string opOpreme, string zaprimatelj)
        {
            string sql = $"UPDATE Oprema SET dobavljac='{dobavljac}', datum=GETDATE(), izvorFinancija='{financije}', nazivProjekta='{imeProjekta}', vrstaOpreme='{vrOpreme}', nazivOpreme='{imeOpreme}', opisOpreme = '{opOpreme}', zaprimac='{zaprimatelj}' WHERE ID_oprema = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
