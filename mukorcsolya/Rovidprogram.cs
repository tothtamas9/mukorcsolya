using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukorcsolya
{
    public class Rovidprogram
    {
        string nev;
        string orszag;
        double technikai_pontszam;
        double komponens_pontszam;
        int hibapont;

        public Rovidprogram(string nev, string orszag, double technikai_pontszam, double komponens_pontszam, int hibapont)
        {
            this.nev = nev;
            this.orszag = orszag;
            this.technikai_pontszam = technikai_pontszam;
            this.komponens_pontszam = komponens_pontszam;
            this.hibapont = hibapont;
        }

        public string Nev { get => nev; }
        public string Orszag { get => orszag; }
        public double Technikai_pontszam { get => technikai_pontszam; }
        public double Komponens_pontszam { get => komponens_pontszam; }
        public int Hibapont { get => hibapont; }
    }
}