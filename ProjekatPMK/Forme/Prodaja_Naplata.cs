using classes;
using ProjekatPMK.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatPMK.Forme
{
    public partial class Prodaja_Naplata : Form
    {
        Racun racun = new Racun();
        Artikal izabraniArtikal;
        String kol = "1";
        //Metode ========================================================================
        private Button kreirajDugmeKategorija(Kategorije kat)
        {
            string Naziv = kat.naziv;
            int Id = kat.ID;
            Button btn = new Button
            {
                Text = Naziv,
                Tag = Id,
                Size = new Size(140, 80),
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(2)
            };
            btn.GotFocus += (s, e) =>
            {
                btn.BackColor = Color.DarkBlue;
                popuniArtikle(btn);
            };
            btn.LostFocus += (s, e) =>
            {
                btn.BackColor = Color.LightBlue;
            };
            return btn;
        }
        private Button kreirajDugmeArtikli(Artikal artikal)
        {
            string Naziv = artikal.Naziv;
            int Id = artikal.Id;
            Button btn = new Button
            {
                Text = Naziv,
                Tag = Id,
                Size = new Size(120, 120),
                BackColor = Color.Yellow,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                AutoSize = false,
                Font = new Font("Tahoma", 12)
            };
            btn.Click += (s, e) =>
            {
                btn.BackColor = Color.Red;
                izabraniArtikal = artikal;
                kolicinaArtikla.Text = izabraniArtikal.Naziv;
                Console.WriteLine("Izabran: " + artikal);
            };
            btn.LostFocus += (s, e) =>
            {
                btn.BackColor = Color.Yellow;
            };
            return btn;
        }
        private void popuniKategorije()
        {
            try
            {
                panelKategorije.Controls.Clear();
                var reader = DatabaseConnection.select("SELECT id, naziv_kategorije FROM kategorije", new Dictionary<string, string>());
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naziv = reader["naziv_kategorije"].ToString();
                    var kategorija = new Kategorije(id, naziv);
                    panelKategorije.Controls.Add(kreirajDugmeKategorija(kategorija));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom popunjavanja kategorija: {ex.Message}");
            }
        }
        private void popuniArtikle(Button btn)
        {
            try
            {
                panelArtikli.Controls.Clear();
                var kategorijaId = btn.Tag;

                string query = "SELECT id, naziv_artikla, cena, jedinica_mere, kategorija_id FROM artikli";
                var parametri = new Dictionary<string, string>();
                query += " WHERE kategorija_id = @kategorija_id";
                query += " ORDER BY naziv_artikla ASC";
                parametri.Add("kategorija_id", kategorijaId.ToString());
                var reader = DatabaseConnection.select(query, parametri);
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naziv = reader["naziv_artikla"].ToString();
                    decimal cena = Convert.ToDecimal(reader["cena"]);
                    string jedinicaMere = reader["jedinica_mere"].ToString();
                    int katId = Convert.ToInt32(reader["kategorija_id"]);

                    var artikal = new Artikal(id, naziv, cena, jedinicaMere, katId);
                    panelArtikli.Controls.Add(kreirajDugmeArtikli(artikal));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom popunjavanja artikala: {ex.Message}");
            }
        }
        private void PretraziButtonePoNazivu(string searchText) 
        {
            try
            {
                panelArtikli.Controls.Clear();

                string query = "SELECT id, naziv_artikla, cena, jedinica_mere, kategorija_id FROM artikli " +
                              "WHERE naziv_artikla LIKE @searchText";

                var parametri = new Dictionary<string, string>{{ "@searchText", "%" + searchText + "%" } 
                 };

                var reader = DatabaseConnection.select(query, parametri);
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naziv = reader["naziv_artikla"].ToString();
                    decimal cena = Convert.ToDecimal(reader["cena"]);
                    string jedinicaMere = reader["jedinica_mere"].ToString();
                    int katId = Convert.ToInt32(reader["kategorija_id"]);

                    var artikal = new Artikal(id, naziv, cena, jedinicaMere, katId);
                    panelArtikli.Controls.Add(kreirajDugmeArtikli(artikal));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom pretrazivanja artikala: {ex.Message}");
            }
        }
        private void DodajStavku(Artikal atk, string kolicina)
        {
            if (kolicina == "0" || kolicina == ",")
            {
                MessageBox.Show("Kolicina ne moze biti 0 ili ,!");
                return;
            }
            if (atk == null)
            {
                MessageBox.Show("Izaberite artikal!");
                return;
            }
            if (String.IsNullOrEmpty(kolicina))
            {
                kolicina = "1";
            }
            Stavka s = new Stavka(atk, Convert.ToDecimal(kolicina));
            racun.DodajStavku(s);
            listBoxStavki.Items.Add(s);
            ukupanIznos.Text = $"{racun.ukupnaCena.ToString()} rsd";
        }
        private void unesiKolicinu(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            string unos = btn.Text;
            
            if (!int.TryParse(unos, out _) && unos != ",")
            {
                MessageBox.Show("Dozvoljeni su samo brojevi!");
                return;
            }
            if (unos == "," && kol.Contains(",")) { return; }
            kol += unos;
            if (kol.Length > 3 && !kol.Contains(","))
            {
                kol = "";
            }
            if (kol.Length > 5 && kol.Contains(","))
            {
                kol = "";
            }
            kolicinaArtikla.Text = $"{izabraniArtikal.Naziv} x {kol}";
        }
        private void ponistiArtikal()
        {
            izabraniArtikal = null;
            kolicinaArtikla.Clear();
            kol = "";
        }
        private void obrisiRacun()
        {
            racun.PonistiRacun();
            listBoxStavki.Items.Clear();
            ukupanIznos.Text = "0,00 rsd";
        }
        private void dalje()
        {
            racunText.Clear();
            RacunTab.SelectedIndex += 1;
            racunText.Text += racun;
            //Console.WriteLine(racun);
        }
        
        //Ostalo ==================
        public Prodaja_Naplata()
        {
            InitializeComponent();
            popuniKategorije();
            foreach(Button btn in panelKalkulator.Controls.OfType<Button>())
            {
                btn.Click += unesiKolicinu;
            }
        }
        private void Prodaja_Naplata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Glavnimeni meni = new Glavnimeni();
            meni.Show();
        }
        private void searchArtikal_TextChanged(object sender, EventArgs e)
        {
            PretraziButtonePoNazivu(searchArtikal.Text);
        }
        private void b_Pomnozi_Click(object sender, EventArgs e)
        {
            if (!kolicinaArtikla.Text.Contains("x"))
            {
                kolicinaArtikla.Text += " x ";
                panelKalkulator.Enabled = true;
            }
        }
        private void b_Unesi_Click(object sender, EventArgs e)
        {
            DodajStavku(izabraniArtikal, kol);
            kol = "";
        }
        private void b_Ponisti_Click(object sender, EventArgs e)
        {
            ponistiArtikal();
        }
        private void obrisiButton_Click(object sender, EventArgs e)
        {
            if (listBoxStavki.SelectedItem != null)
            {
                racun.obrisiStavku((Stavka)listBoxStavki.SelectedItem);
                listBoxStavki.Items.Remove(listBoxStavki.SelectedItem);
                ukupanIznos.Text = racun.ukupnaCena.ToString() + " rsd";
            }
            else
            {
                MessageBox.Show("Izaberite stavku za brisanje.");
            }
     
        }
        private void daljeButton_Click(object sender, EventArgs e)
        {
            dalje();
        }

        private void sacuvajRacun_Click(object sender, EventArgs e)
        {
            if (racun.NijePrazan())
            {
                racun.sacuvajRacun();
            }
            else
            {
                MessageBox.Show("Racun je prazan.");
            }
        }

        private void butonTransakcija_Click(object sender, EventArgs e)
        {
            racun.PonistiRacun();
            racunText.Clear();
            listBoxStavki.Items.Clear();
            ukupanIznos.Text = "0,00 rsd";
        }
    }
}
