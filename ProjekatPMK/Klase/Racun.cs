using classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatPMK.Klase
{
    class Racun
    {
        public DateTime datum { get; set; }
        public List<Stavka> listaStavki { get; set; }
        public decimal ukupnaCena { get; set; }

        public Racun()
        {
            datum = DateTime.Now;
            listaStavki = new List<Stavka>();
            ukupnaCena = 0;
        }

        public void DodajStavku(Stavka stv)
        {
            listaStavki.Add(stv);
            Console.WriteLine("Nova stavka dodata: " + stv);
            ukupanRacun(stv.cena);
        }

        public void PonistiRacun()
        {
            Console.WriteLine("Racun je obrisan.");
            listaStavki.Clear();
            ukupnaCena = 0;
            datum = DateTime.Now;
        }

        public void ukupanRacun(decimal cena)
        {
            ukupnaCena += cena;
        }
        
        public void obrisiStavku(Stavka stv)
        {
            try
            {
                listaStavki.Remove(stv);
                ukupnaCena = ukupnaCena - stv.cena;
                Console.WriteLine("Stavka obrisana");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja artikala: {ex.Message}");
            }
        }

        public void sacuvajStavku()
        {
            try
            {
                foreach (Stavka stv in listaStavki)
                {
                    var parametri = new Dictionary<string, string>{
                                     { "artikal_id", stv.artikal.Id.ToString()},
                                     { "kolicina", stv.kolicina.ToString() },
                                     { "datum", datum.ToString("yyyy-MM-dd") } 
                 };

                    DatabaseConnection.insert(
                                 "INSERT INTO prodaja (artikal_id, datum, kolicina) " +
                                 "VALUES (@artikal_id, @datum, @kolicina) " +
                                 "ON DUPLICATE KEY UPDATE kolicina = kolicina + VALUES(kolicina);", parametri);
                }
                Console.WriteLine("Uspesno dodata stavka u db");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        public void sacuvajRacun()
        {
            DateTime vremeIzdavanjeRacuna = DateTime.Now;
            string rcnVreme = vremeIzdavanjeRacuna.ToString("dd.MM.yyyy HHmmss");
            string folderPath = Path.Combine(Application.StartupPath, "..", "..", "Podaci");
            string filePath = Path.Combine(folderPath, rcnVreme  + ".txt");
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                File.WriteAllText(filePath, this.ToString());

                sacuvajStavku(); //Cuva podatke u db
                MessageBox.Show("Racun je uspešno kreiran. " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        } 

        public bool NijePrazan()
        {
            return listaStavki.Count > 0;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (Stavka stv in listaStavki)
            {
                s.AppendLine(string.Format("{0, -15} {1:F0}", stv.artikal.Naziv, stv.cena));
            }
            s.AppendLine("------------------------");
            s.AppendLine("Ukupno");
            s.AppendLine(ukupnaCena.ToString());
            return s.ToString();
        }
    }
}
