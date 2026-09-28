using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WebaruhazApp
{
    public class AkciosTermek : Termek
    {
        private int kedvezmenySzazalek; 
        public int KedvezmenySzazalek
        { 
            get { return kedvezmenySzazalek; } 
            set
            {
                if(value >= 1 && value<=90)
                {
                    kedvezmenySzazalek = value;
                }
                else
                {
                    KedvezmenySzazalek = 10;
                }
            } 
        }

        public AkciosTermek(string nev, int nettoar, int kedvezmeny) : base(nev,nettoar)
        {
            kedvezmenySzazalek = kedvezmeny;

        }

        public override int BruttoArKiszamitas()
        {
            return base.BruttoArKiszamitas()*kedvezmenySzazalek/100;
        }

        public override string ToString()
        {
            return base.ToString()+$"|| Kedvezmény: {kedvezmenySzazalek}%";
        }
    }
}
