using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPMK.Klase
{
    class Kategorije
    {
        public int ID { get; set; }
        public string naziv { get; set; }

        public Kategorije(int id, string naziv)
        {
            ID = id;
            this.naziv = naziv;
        }

        public override string ToString()
        {
            return naziv;
        }

    }
}
