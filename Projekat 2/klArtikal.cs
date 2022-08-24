using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class klArtikal
    {
        private string naziv;
        private int id, kolicina;
        private double procenat;

        public klArtikal(string naziv, int id, int kolicina, double procenat)
        {
            this.naziv = naziv;
            this.id = id;
            this.kolicina = kolicina;
            this.procenat = procenat;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public double Procenat { get => procenat; set => procenat = value; }

        public override string ToString()
        {
            return "Proizvod " +"\""+ Naziv +"\""+ " je prodat " + Kolicina + " put što je " + Procenat + "% od ukupne prodaje.";
        }
    }
}
