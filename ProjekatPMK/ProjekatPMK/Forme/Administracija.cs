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
    public partial class Administracija : Form
    {
        //Metode ====================================================================================

        public Administracija()
        {
            InitializeComponent();
            listaKtg.Format += (sender, e) =>
            {
                if (e.ListItem is Kategorije kategorija)
                {
                    int redniBroj = listaKtg.Items.IndexOf(kategorija) + 1;
                    e.Value = $"{redniBroj}|{kategorija.naziv}";
                }
            }; //Formatiranje prvog lb
            UcitajKategorije(); //Ucitavanje kategorija na pocetku
        }
        //Kategorije
        private void UcitajKategorije()
        {
            //Brise staru listu i ucitava iz baze
            listaKtg.Items.Clear();
            var reader = DatabaseConnection.select("SELECT id, naziv_kategorije FROM kategorije", new Dictionary<string, string>());
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string naziv = reader["naziv_kategorije"].ToString();
                var kategorija = new Kategorije(id, naziv);
                listaKtg.Items.Add(kategorija);
                //Console.WriteLine(kategorija);
            }
            reader.Close();
        } //Ucitava kategorije iz db i dodaje u lb
        private void DodajKategoriju()
        {
            try
            {
                string naziv = textKategorije.Text;
                // Provera unosa
                if (string.IsNullOrWhiteSpace(naziv))
                {
                    MessageBox.Show("Naziv kategorije ne može biti prazan!");
                    return;
                }

                // Dodaj u bazu
                var parametri = new Dictionary<string, string> { { "naziv_kategorije", naziv } };
                DatabaseConnection.insert("INSERT INTO kategorije (naziv_kategorije) VALUES (@naziv_kategorije)", parametri);

                // Dohvati ID novododate kategorije
                var reader = DatabaseConnection.select("SELECT LAST_INSERT_ID() as id", new Dictionary<string, string>());
                int noviId = 0;
                if (reader.Read())
                {
                    noviId = Convert.ToInt32(reader["id"]);
                }
                reader.Close();

                var novaKategorija = new Kategorije(noviId, naziv);
                listaKtg.Items.Add(novaKategorija);
                //Console.WriteLine(novaKategorija);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja kategorije: {ex.Message}");
            }
        } //Dodaje kategoriju
        private void ObrisiKategoriju()
        {
            try
            {
                // Dohvati selektovanu kategoriju
                var kategorija = (Kategorije)listaKtg.SelectedItem;
                // Obriši iz baze
                var parametri = new Dictionary<string, string> { { "id", kategorija.ID.ToString() } };
                DatabaseConnection.delete("DELETE FROM kategorije WHERE id = @id", parametri);
                listaKtg.Items.Remove(kategorija);
                MessageBox.Show("Kategorija je uspešno obrisana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja kategorije: {ex.Message}");
            }
        } //Brisanje kategorije
        private void IzmeniKategoriju()
        {
          try { 
            var kategorija = (Kategorije)listaKtg.SelectedItem;

            if (kategorija == null)
                {
                    MessageBox.Show("Izaberite kategoriju!");
                    return;
                }
            
            string noviNaziv = textKategorije.Text;
            if (string.IsNullOrWhiteSpace(noviNaziv))
            {
                MessageBox.Show("Unesite novi naziv kategorije!");
                return;
            }
            var parametri = new Dictionary<string, string>{ { "id", kategorija.ID.ToString() },
                                                            { "naziv_kategorije", noviNaziv }};
            DatabaseConnection.update("UPDATE kategorije SET naziv_kategorije = @naziv_kategorije WHERE id = @id", parametri);
            UcitajKategorije();
            MessageBox.Show("Naziv kategorije je uspešno izmenjen!");
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene kategorije: {ex.Message}");
            } 
        } //Menjanje kategorije
        //Artikli
        private void PopuniKategorijeUComboBox()
        {
            try
            {
                comboBoxKategorija.Items.Clear();
                var reader = DatabaseConnection.select("SELECT id, naziv_kategorije FROM kategorije", new Dictionary<string, string>());
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naziv = reader["naziv_kategorije"].ToString();
                    var kategorija = new Kategorije(id, naziv);
                    comboBoxKategorija.Items.Add(kategorija);
                }
                reader.Close();
                comboBoxKategorija.DisplayMember = "Naziv";
                comboBoxKategorija.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom popunjavanja kategorija: {ex.Message}");
            }
        } //Popunjavanje cboxa kategorijama
        private void DodajArtikal()
        {
            try
            {
                if (comboBoxKategorija.SelectedItem == null)
                {
                    MessageBox.Show("Izaberite kategoriju!");
                    return;
                }
                
                string nazivArtikla = textBoxNazivArtikla.Text;
                string cenaArtikla = textBoxCenaArtikla.Text;
                string jedinicaMere = textBoxJedinicaMere.Text;
                var kategorijaId = (Kategorije)comboBoxKategorija.SelectedItem;
                
                if (string.IsNullOrWhiteSpace(nazivArtikla) || string.IsNullOrWhiteSpace(cenaArtikla) || string.IsNullOrWhiteSpace(jedinicaMere))
                {
                    MessageBox.Show("Popunite sva polja za artikal!");
                    return;
                }
                
                if (!decimal.TryParse(cenaArtikla, out decimal cena))
                {
                    MessageBox.Show("Cena mora biti validan broj!");
                    return;
                }

                var parametri = new Dictionary<string, string> {
                                                                { "naziv_artikla", nazivArtikla },
                                                                { "cena", cena.ToString() },
                                                                { "jedinica_mere", jedinicaMere },
                                                                { "kategorija_id", kategorijaId.ID.ToString() }};
                DatabaseConnection.insert("INSERT INTO artikli (naziv_artikla, cena, jedinica_mere, kategorija_id) VALUES (@naziv_artikla, @cena, @jedinica_mere, @kategorija_id)", parametri);

                MessageBox.Show("Artikal je uspešno dodat!");
                textBoxNazivArtikla.Clear();
                textBoxCenaArtikla.Clear();
                textBoxJedinicaMere.Clear();
                UcitajArtikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja artikla: {ex.Message}");
            }
        } //Pravi artikal i dodaje u db/lb
        private void UcitajArtikle()
        {
            try
            {
                listBoxArtikli.Items.Clear();
                var kategorijaId = (Kategorije)comboBoxKategorija.SelectedItem;
                string query = "SELECT id, naziv_artikla, cena, jedinica_mere, kategorija_id FROM artikli";
                var parametri = new Dictionary<string, string>();
                 query += " WHERE kategorija_id = @kategorija_id";
                 parametri.Add("kategorija_id", kategorijaId.ID.ToString());
                var reader = DatabaseConnection.select(query, parametri);
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string naziv = reader["naziv_artikla"].ToString();
                    decimal cena = Convert.ToDecimal(reader["cena"]);
                    string jedinicaMere = reader["jedinica_mere"].ToString();
                    int katId = Convert.ToInt32(reader["kategorija_id"]);

                    var artikal = new Artikal(id, naziv, cena, jedinicaMere, katId);
                    listBoxArtikli.Items.Add(artikal);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja artikala: {ex.Message}");
            }
        } //Ucitava artikle iz db u lb
        private void ObrisiArtikal()
        {
            try
            {
                var artikal = (Artikal)listBoxArtikli.SelectedItem;
                var parametri = new Dictionary<string, string> { { "id", artikal.Id.ToString() } };
                DatabaseConnection.delete("DELETE FROM artikli WHERE id = @id", parametri);
                listBoxArtikli.Items.Remove(artikal);
                MessageBox.Show("Artikal je uspešno obrisan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja artikala: {ex.Message}");
            }
        } //Brise artikle iz db i lb
        private void IzmeniArtikal()
        {
            try
            {
                var artikal = (Artikal)listBoxArtikli.SelectedItem;

                if (artikal == null)
                {
                    MessageBox.Show("Selektuj zeljeni proizvod za izmenu!");
                    return;
                }

                string noviNaziv = textBoxNazivArtikla.Text;
                string novaCena = textBoxCenaArtikla.Text;
                string novaJM = textBoxJedinicaMere.Text;
                if (string.IsNullOrWhiteSpace(noviNaziv) || string.IsNullOrWhiteSpace(novaCena) || string.IsNullOrWhiteSpace(novaJM))
                {
                    MessageBox.Show("Podaci ne smeju biti prazni!");
                    return;
                } 
                //Azuriranje databaze
                var parametri = new Dictionary<string, string>{ { "id", artikal.Id.ToString() },
                                                            { "naziv_artikla", noviNaziv },
                                                            { "cena", novaCena },
                                                            { "jedinica_mere", novaJM }};
                DatabaseConnection.update("UPDATE artikli SET naziv_artikla = @naziv_artikla, cena = @cena, jedinica_mere = @jedinica_mere WHERE id = @id", parametri);
                
                UcitajArtikle();
                MessageBox.Show("Naziv artikla je uspešno izmenjen!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom izmene artikla: {ex.Message}");
            }
         }
        private void CitajStatistiku(DateTime datum)
        {
            panelStatistika.Controls.Clear();
            string query = @"
                     SELECT a.naziv_artikla, p.kolicina 
                     FROM prodaja p 
                     INNER JOIN artikli a ON p.artikal_id = a.id 
                     WHERE p.datum = @datum 
                     ORDER BY p.kolicina DESC";
            var parametri = new Dictionary<string, string>();
            parametri.Add("@datum", datum.ToString("yyyy-MM-dd"));
            try
            {
                var reader = DatabaseConnection.select(query, parametri);
                int yPosition = 10;
                while (reader.Read())
                {
                    string nazivArtikla = reader["naziv_artikla"].ToString();
                    int kolicina = Convert.ToInt32(reader["kolicina"]);

                    Label lblArtikal = new Label()
                    {
                        Text = nazivArtikla,
                        Location = new Point(10, yPosition),
                        Size = new Size(150, 25)
                    };

                    ProgressBar progressBar = new ProgressBar()
                    {
                        Location = new Point(400, yPosition),
                        Size = new Size(150, 20),
                        Value = kolicina
                    };
                    Label labelkol = new Label()
                    {
                        Location = new Point(550, yPosition),
                        Text = kolicina.ToString()
                    };

                    panelStatistika.Controls.Add(lblArtikal);
                    panelStatistika.Controls.Add(progressBar);
                    panelStatistika.Controls.Add(labelkol);

                    yPosition += 30;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        } //Menja artikal u db

        //Azuriranje kategorija =====================================================================

        private void Administracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Glavnimeni meni = new Glavnimeni();
            meni.Show();
        } //Gasenje administracije
        private void buttonDodajKtg_Click(object sender, EventArgs e)
        {
            DodajKategoriju();
            textKategorije.Clear();
        } //Dodavanje kategorije u listu
        private void listaKtg_Click(object sender, EventArgs e) //Selektovanjem se ukljucuje dugme
        {
            buttonIzmeniKtg.Enabled = true;
            buttonObrisiKtg.Enabled = true;
        }
        private void buttonIzmeniKtg_Click(object sender, EventArgs e) //Izmena selektovanog elementa
        {
            IzmeniKategoriju();
        }
        private void buttonObrisiKtg_Click(object sender, EventArgs e) //Brisanje selektovanog elementa
        {
            ObrisiKategoriju();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            PopuniKategorijeUComboBox();
        } //Ucitavanje kategorija u combobox

        //Azuriranje artikala ========================================================================

        private void buttonDodajArtikal_Click(object sender, EventArgs e)
        {
            DodajArtikal();
        } //Dodavanje artikala u db i lb
        private void comboBoxKategorija_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajArtikle();
        } //Ucitavanje artikla u lb
        private void buttonObrisiArtikal_Click(object sender, EventArgs e)
        {
            ObrisiArtikal();
        } //Brisanje artikala iz db i lb
        private void buttonIzmeniArtikal_Click(object sender, EventArgs e)
        {
            IzmeniArtikal();
        } //Dugme za menjanje artikla
        private void listBoxArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtikli.SelectedItem != null)
            {
                int i = listBoxArtikli.SelectedIndex;
                var atk = (Artikal)listBoxArtikli.Items[i];
                textBoxNazivArtikla.Text = atk.Naziv;
                textBoxCenaArtikla.Text = atk.Cena.ToString();
                textBoxJedinicaMere.Text = atk.JedinicaMere;
            }
        }  //Ucitavanje artikla u tb 

        private void statistikaDatum_ValueChanged(object sender, EventArgs e)
        {
            CitajStatistiku(statistikaDatum.Value);
        }
    }
}
