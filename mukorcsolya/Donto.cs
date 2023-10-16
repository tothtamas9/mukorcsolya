using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukorcsolya
{
    public class Donto
    {
        string d_nev;
        string d_orszag;
        double d_technikai_pontszam;
        double d_komponens_pontszam;
        int d_hibapont;

        public Donto(string d_nev, string d_orszag, double d_technikai_pontszam, double d_komponens_pontszam, int d_hibapont)
        {
            this.d_nev = d_nev;
            this.d_orszag = d_orszag;
            this.d_technikai_pontszam = d_technikai_pontszam;
            this.d_komponens_pontszam = d_komponens_pontszam;
            this.d_hibapont = d_hibapont;
        }

        public string D_nev { get => d_nev; }
        public string D_orszag { get => d_orszag; }
        public double D_technikai_pontszam { get => d_technikai_pontszam; }
        public double D_komponens_pontszam { get => d_komponens_pontszam; }
        public int D_hibapont { get => d_hibapont; }
    }
}
