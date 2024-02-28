using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en valfri sträng:");
            string text = Console.ReadLine();
            Console.WriteLine("Antal tal i texten: " + AntalTalIText(text));
        }

        static int AntalTalIText(string text)
        {
            string[] delar = text.Split(' ');
            int antal = 0;

            for (int i = 0; i < delar.Length; i++)
            {
                double tal;
                if (double.TryParse(delar[i], out tal))
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}