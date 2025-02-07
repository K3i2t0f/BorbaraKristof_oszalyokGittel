namespace OOPGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new("a Kis Herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
            Konyv konyv2 = new("Ez még készül", "Én");

            Film film1 = new("Star Wars", "George Lucas", 120, "sci-fi", true);
            Film film2 = new("Ez még készül", "Én");

            Karakter Karakter1 = new("Karakter1", 10, 100, 20);
            Karakter Karakter2 = new("Karakter2", 15, 100, 25);

            Urhajo urhajo1 = new("Géza", 200, 5, 60);
            Urhajo urhajo2 = new("Juliska", 300, 10, 100);

            KemKuldetes kuldetes1 = new("Sanyi", "Magyarország", 10, 60);
            KemKuldetes kuldetes2 = new("Pista", "Németország", 20, 50);


            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));

            Console.WriteLine("-----------------------------------------------------------");

            film1.MufajModositas("sci-fi");
            film2.HosszNovelese(20);

            Console.WriteLine("\n" + film1.ToString() + "\n" + film2.ToString());

            Console.WriteLine("-----------------------------------------------------------");

            Karakter1.Tamadas(Karakter2);
            Karakter2.Gyogyulas();

            Console.WriteLine("\n" + Karakter1.ToString() + "\n" + Karakter2.ToString());

            Console.WriteLine("-----------------------------------------------------------");

            urhajo1.Indulas();
            urhajo2.Indulas();

            Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());

            Console.WriteLine("-----------------------------------------------------------");

            kuldetes1.KuldetesInditasa();
            kuldetes2.VeszelySzintNovel(10);

            Console.WriteLine("\n" + kuldetes1.ToString() + "\n" + kuldetes2.ToString());
        }
    }
}
