using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPMK.Klase
{
    class Stavka
    {
        public Artikal artikal { get; set; }
        public decimal kolicina { get; set;}
        public decimal cena { get; set; }

        public Stavka(Artikal atk, decimal kolicina)
        {
            artikal = atk;
            this.kolicina = kolicina;
            cenaStavke();
            Console.WriteLine($"Nova stavka kreirana: {artikal} kolicina: {kolicina}");
        }

        public void cenaStavke()
        {
            cena = artikal.Cena * kolicina;
        }

        public override string ToString()
        {
            return $"{artikal.Naziv} ({kolicina}/{artikal.JedinicaMere}) - {cena} RSD";
        }
    }
}
