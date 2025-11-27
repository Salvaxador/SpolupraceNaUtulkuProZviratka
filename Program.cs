using System;
using System.Text;

namespace SpolupraceNaUtulkuProZviratka

{
    internal class Program
    {
        static Logika service = new Logika();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ÚTULEK PRO ZVÍŘATA =====");
                Console.WriteLine("1) Přidat zvíře");
                Console.WriteLine("2) Vypsat všechna zvířata");
                Console.WriteLine("3) Vyhledat/ filtrovat");
                Console.WriteLine("4) Označit adopci");
                Console.WriteLine("5) Statistiky");
                Console.WriteLine("0) Konec");
                Console.Write("Volba: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1": VypisClass.PridatZvire(service); break;
                    case "2": VypisClass.VypisVsechna(service); break;
                    case "3": VypisClass.Vyhledat(service); break;
                    case "4": VypisClass.Adopce(service); break;
                    case "5": VypisClass.Statistiky(service); break;
                    case "0": return;
                    default: Console.WriteLine("Neplatná volba."); break;
                }

                Console.WriteLine("Pokračuj stiskem klávesy...");
                Console.ReadKey();
            }
        }
    }
}