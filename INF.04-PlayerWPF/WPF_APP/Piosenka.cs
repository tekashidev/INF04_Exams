using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP
{
    public class Piosenka
    {
        public string Tytul { get; set; }
        public string Album { get; set; }
        public string LiczbaUtworow { get; set; }
        public string RokWydania { get; set; }

        public string LiczbaPobran { get; set; }

        public Piosenka() { }

        public Piosenka(string Tytul, string Album, string liczbaUtworow, string RokWydania, string LiczbaPobran)
        {
            this.Tytul = Tytul;
            this.Album = Album;
            this.LiczbaUtworow = liczbaUtworow;
            this.RokWydania = RokWydania;
            this.LiczbaPobran = LiczbaPobran;
        }



    }
}
