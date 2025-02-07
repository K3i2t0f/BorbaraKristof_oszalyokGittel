using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class Film
    {
        private string cim;
        private string rendezo;
        private int hosszPercekben;
        private string mufaj;
        private bool megjelenjes;

        public string Cim { get => cim; set => cim = value; }
        public string Rendezo { get => rendezo; set => rendezo = value; }
        public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }
        public bool Megjelenjes { get => megjelenjes; set => megjelenjes = value; }

        public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelenjes)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.hosszPercekben = hosszPercekben;
            this.mufaj = mufaj;
            this.megjelenjes = megjelenjes;
        }

        public Film(string cim, string rendezo)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            hosszPercekben = 120;
            mufaj = "ismeretlen";
            megjelenjes = false;
        }

        public void Jatszas()
        {
            Console.WriteLine("A film elkezdődött!");
        }

        public string MufajModositas(string ujMufaj)
        {
            mufaj = ujMufaj;
            return mufaj;
        }

        public void HosszNovelese(int percek)
        {
            if (percek > 0)
            {
                hosszPercekben += percek;
            }
            else
            {
                Console.WriteLine("Ezt a számot nem lehet hozzáadni!");
            }
        }

        public override string ToString()
        {
            return $"{cim} - {rendezo} / {hosszPercekben} / {mufaj} - {megjelenjes}";
        }
    }
}
