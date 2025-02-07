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


        }
    }
}
