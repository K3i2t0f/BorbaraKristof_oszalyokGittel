using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class Urhajo
    {
        private string nev;
        private int sebesseg;
        private int utasokSzama;
        private int uzemanyagszint;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int UtasokSzama { get => utasokSzama; set => utasokSzama = value; }
        public int Uzemanyagszint { get => uzemanyagszint; set => uzemanyagszint = value; }

        public Urhajo(string nev, int sebesseg, int utasokSzama, int uzemanyagszint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utasokSzama = utasokSzama;
            this.uzemanyagszint = uzemanyagszint;
        }

        public Urhajo(string nev, int utasokSzama)
        {
            this.nev = nev;
            this.utasokSzama = utasokSzama;
            sebesseg = 0;
            uzemanyagszint = 100;
        }

        public void Indulas()
        {
            if (uzemanyagszint > 0)
            {
                sebesseg += 30; 
                uzemanyagszint -= 2;
                Console.WriteLine($"A(z) {nev} űrhajó elindult!");
                Console.WriteLine($"Sebesség: {sebesseg}, Üzemanyagszint: {uzemanyagszint}");
            }
            else
            {
                Console.WriteLine("Nincs elég üzemanyag az induláshoz!");
            }
        }

        public void Tankolas(int mennyiseg)
        {
            uzemanyagszint += mennyiseg;
            Console.WriteLine($"Az űrhajó tankolva lett! Új üzemanyagszint: {uzemanyagszint}");
        }

        public void Landolas()
        {
            sebesseg = 0;
            Console.WriteLine("Az űrhajó leszállt!");
        }

        public override string ToString()
        {
            return $"{nev} - {sebesseg} - {utasokSzama} - {uzemanyagszint}";
        }
    }
}
