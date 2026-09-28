using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebaruhazApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termek termek1 = new Termek("Monitor", 80000);
            AkciosTermek akcios1 = new AkciosTermek("Billenyűzet", 20000, 20);
            Console.WriteLine(termek1);
            Console.WriteLine(akcios1);

            termek1.NettoAr = -5000;
            Console.WriteLine(termek1);
            akcios1.KedvezmenySzazalek = 150;
            Console.WriteLine(akcios1);
            Console.WriteLine(Termek.OsszesTermekSzama);
        }
    }
}
