using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class KemKuldetes
    {
        private string kodnev;
        private string orszag;
        private int VeszelySzint;
        private int sikerEsely;

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint1 { get => VeszelySzint; set => VeszelySzint = value; }
        public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

        public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsely)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            VeszelySzint = veszelySzint;
            this.sikerEsely = sikerEsely;
        }

        public KemKuldetes(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            VeszelySzint = 5;
            sikerEsely = 50;
        }

        public void KuldetesInditasa()
        {
            if (sikerEsely > 50)
            {
                Console.WriteLine("A küldetés sikeres volt!");
            }
            else
            {
                Console.WriteLine("A küldetés sikertelen volt!");
            }
        }

        public void VeszelySzintNovel(int mennyiseg)
        {
            VeszelySzint += mennyiseg;
            Console.WriteLine($"A veszélyszint növelve lett {mennyiseg}-vel. Jelenlegi veszélyszint: {VeszelySzint}");
        }

        public void SikerEselyNovel(int szazalek)
        {
            sikerEsely += szazalek;
            Console.WriteLine($"A siker esélye növelve lett {szazalek}-vel. Jelenlegi siker esély: {sikerEsely}");
        }

        public override string ToString()
        {
            return $"{kodnev} - {orszag} - {VeszelySzint} - {sikerEsely}";
        }
    }


}