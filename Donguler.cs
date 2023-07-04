using System;
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YAZILIM GELISTIRICI GELISTIRME KAMPI";
            string kurs2 = "PROGRAMLAMAYA BAŞLANGIC ICIN TEMEL KURS";
            string kurs3 = "JAVA";
            string kurs4 = "PYTHON";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            string[] kurslar = new string[] { "YAZILIM GELISTIRICI GELISTIRME KAMPI", "PROGRAMLAMAYA BAŞLANGIC ICIN TEMEL KURS", "JAVA", "PYTHON" };
            

            //string[] kurslar = new string[] { };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");

            foreach(string kurs in kurslar)  //dizileri tek tek dolaşma
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}