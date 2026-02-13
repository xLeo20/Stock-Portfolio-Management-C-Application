using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Actiune
    {
        public int id;
        public string simbol;
        public string denumire;
        public string sector;
        public string pretCurent;
        public string numarActiuni;
        public DateTime dataActualizare;
        public int portofoliuId; 

        public Actiune() { }

        public Actiune(string simbol, string denumire, string sector, string pretCurent, string numarActiuni, DateTime dataActualizare)
        {
            this.simbol = simbol;
            this.denumire = denumire;
            this.sector = sector;
            this.pretCurent = pretCurent;
            this.numarActiuni = numarActiuni;
            this.dataActualizare = dataActualizare;
        }

        public Actiune(int id, string simbol, string denumire, string sector, string pretCurent, string numarActiuni, DateTime dataActualizare, int portofoliuId = 0)
        {
            this.id = id;
            this.simbol = simbol;
            this.denumire = denumire;
            this.sector = sector;
            this.pretCurent = pretCurent;
            this.numarActiuni = numarActiuni;
            this.dataActualizare = dataActualizare;
            this.portofoliuId = portofoliuId;
        }

        public override string ToString()
        {
            return this.simbol + " " + this.denumire + " " + this.sector + " " + this.pretCurent + " " + this.numarActiuni + " " + this.dataActualizare.ToString();
        }
    }
}
