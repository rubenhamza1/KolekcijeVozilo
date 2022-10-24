using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijeVozilo
{
    internal class Vozilo
    {
        string model, kategorija;
        int godinaProizvodnje, brojKotaca;

        public Vozilo(string model, int godinaProizvodnje, int brojKotaca)
        {
            this.model = model;
            this.godinaProizvodnje = godinaProizvodnje;
            this.brojKotaca = brojKotaca;
        }

        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

        public override string ToString()
        {
            return "Model: " + this.model + "\tGodina proizvodnje: "
                + this.godinaProizvodnje + "\tBroj kotača: " + this.brojKotaca
                + "\tKategorija: " + this.kategorija + "\r\n";
        }
    }
}
