using System;
using System.Text;
using System.IO;
using System.Globalization;


namespace P3_LAB3
{



    class Program
    { 


        public static void obliczanieSumy()
        {
            Console.WriteLine("Podaj ilosc elementow w pierwszej kolumnie");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilosc elementow w drugiej kolumnie");
            int b = Convert.ToInt32(Console.ReadLine());

            int[][] tab = new int[2][];
            tab[0] = new int[a];
            tab[1] = new int[b];


            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element pierwszej kolumny");
                tab[0][i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int j = 0; j < b; j++)
            {
                Console.WriteLine("Podaj " + (j + 1) + " element drugiej kolumny");
                tab[1][j] = Convert.ToInt32(Console.ReadLine());
            }

            int suma_a = 0;
            int suma_b = 0;

            for (int i = 0; i < a; i++)
            {
                suma_a += tab[0][i];

            }

            for (int i = 0; i < b; i++)
            {
                suma_b += tab[1][i];

            }

            int suma = suma_a + suma_b;

            Console.Clear();
            Console.WriteLine("Suma elementów tablicy wynosi: " + suma+ Environment.NewLine);

        }


        public static void formatowanieZdania()
        {
            Console.WriteLine("Podaj zdanie które wymaga formatowania");

            var tekstDoKonwersji = (Console.ReadLine());
            var ostatniZnak = tekstDoKonwersji.Substring(tekstDoKonwersji.Length - 1);
            var pierwszyZnak = tekstDoKonwersji.Substring(0, 1);

            string duza = (char.ToUpper(tekstDoKonwersji[0]) + tekstDoKonwersji.Substring(1));

            StringBuilder SbTekst = new StringBuilder(duza);

            if (ostatniZnak != ".")
            {
                SbTekst.Append(".");

            }

            Console.WriteLine(SbTekst);

        }

        static void Main(string[] args)
        {

            obliczanieSumy();

            formatowanieZdania();
            




        }
    }
}
