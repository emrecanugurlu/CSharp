using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Adi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.Adi = "Java";
            kurs2.Egitmeni = "Emre";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Adi = "Python";
            kurs3.Egitmeni = "Üsame";
            kurs3.IzlenmeOrani = 64;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3,
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Adi);
                Console.WriteLine(kurs.Egitmeni);
                Console.WriteLine(kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string Adi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
