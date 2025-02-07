namespace OOPGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new("a Kis Herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
            Konyv konyv2 = new("Ez még készül", "Én");

            Film film1 = new Film("Star Wars", "George Lucas", 120, "sci-fi", true);
            Film film2 = new Film("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));


            film1.MufajModositas("sci-fi");
            film2.HosszNovelese(20);

            Console.WriteLine("\n" + film1.ToString() + "\n" + film2.ToString());
        }
    }
}
