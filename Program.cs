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

                
            }
        }
    }
}