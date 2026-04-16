using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPMK.Klase
{
    public class Artikal
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public string JedinicaMere { get; set; }
        public int KategorijaId { get; set; }

        public Artikal(int id, string naziv, decimal cena, string jedinicaMere, int kategorijaId)
        {
            Id = id;
            Naziv = naziv;
            Cena = cena;
            JedinicaMere = jedinicaMere;
            KategorijaId = kategorijaId;
        }

        public override string ToString()
        {
            return $"{Naziv} - {Cena} RSD ({JedinicaMere})";
        }
        
    }
}
