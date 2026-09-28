using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebaruhazApp
{
    public class Termek
    {
        private int nettoAr;
        protected double afaKulcs = 0.27;
        private static int osszesTermekSzama = 0;

        public string Nev { get; set; }
        public int NettoAr
        { 
            get{ return nettoAr; }
            set
            { 
                if(value > 0)
                {
                    nettoAr += value;
                }
            }
        }

        public static int OsszesTermekSzama { get{ return osszesTermekSzama; } }


        public Termek(string nev, int nettoar)
        {
            Nev = nev;
            NettoAr = nettoar;
            osszesTermekSzama++;
        }
        
        public virtual int BruttoArKiszamitas()
        {
            return Convert.ToInt32(NettoAr * (1 + afaKulcs));
        }

        public override string ToString()
        {
            return $"Termék: {Nev} | Nettó: {NettoAr} Ft | Bruttó: {BruttoArKiszamitas()} Ft ";
        }
    }
}
