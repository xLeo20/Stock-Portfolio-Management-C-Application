using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Portofoliu
    {
        public int id;
        public string denumire;
        public string descriere;
        public DateTime dataCreare;
        public List<Actiune> actiuni;

        public Portofoliu()
        {
            actiuni = new List<Actiune>();
            dataCreare = DateTime.Now;
        }

        public Portofoliu(string denumire, string descriere)
        {
            this.denumire = denumire;
            this.descriere = descriere;
            this.dataCreare = DateTime.Now;
            this.actiuni = new List<Actiune>();
        }

        public Portofoliu(int id, string denumire, string descriere, DateTime dataCreare)
        {
            this.id = id;
            this.denumire = denumire;
            this.descriere = descriere;
            this.dataCreare = dataCreare;
            this.actiuni = new List<Actiune>();
        }

        public decimal ValoareTotala
        {
            get
            {
                decimal total = 0;
                foreach (var actiune in actiuni)
                {
                    if (decimal.TryParse(actiune.pretCurent, out decimal pret) &&
                        int.TryParse(actiune.numarActiuni, out int numar))
                    {
                        total += pret * numar;
                    }
                }
                return total;
            }
        }

        public override string ToString()
        {
            return this.denumire + " - " + this.descriere + " (" + this.actiuni.Count + " acțiuni)";
        }
    }
}
