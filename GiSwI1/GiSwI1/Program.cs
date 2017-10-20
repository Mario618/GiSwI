using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GiSwI1
{
    class Program
    {
        public static int Seed { get; private set; }

        static void Main(string[] args)
        {
            //generowanie liczb
            Random rnd = new Random();
            

            //tworzenie tablicy dwu wymiarowej f1
            int[,] f1 = new int[10, 10] {
                {00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00 }
        };
            //tworzenie tablicy dwu wymiarowej f2
            int[,] f2 = new int[10, 10] {
                {00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99),rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00,rnd.Next(1,99) },
                {rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),rnd.Next(1,99),00 }
        };
            
            //wypisanie w Console
            Console.WriteLine("Tablica f1: ");
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                    Console.Write("{0,4} ", f1[x, y].ToString().PadLeft(2, '0'));

                Console.WriteLine();
            }
            Console.WriteLine("tablica f2: ");
            for (int r = 0; r < 10; r++)
            {
                for (int z = 0; z < 10; z++)
                    Console.Write("{0,4} ", f2[r, z].ToString().PadLeft(2, '0'));
                Console.WriteLine();

            }
            //zapis do pliku .txt z dodaniem zero przy liczbach pojedyńczych
            using (var writer = new StreamWriter(@"C:\ITSD\grafy.txt"))
            {
                writer.Write("Tablica 1: ");
                writer.Write(Environment.NewLine);
                for (int l1 = 0; l1 < 10; l1++)
                {
                    for (int l2 = 0; l2 < 10; l2++)
                        writer.Write("{0,1} ", f1[l1, l2].ToString().PadLeft(2, '0'));
                    writer.Write(Environment.NewLine);
                }
                writer.Write("Tablica 2: ");
                writer.Write(Environment.NewLine);
                for (int t1 = 0; t1 < 10; t1++)
                {
                    for (int t2 = 0; t2 < 10; t2++)
                        writer.Write("{0,1} ", f2[t1, t2].ToString().PadLeft(2, '0'));
                    writer.Write(Environment.NewLine);
                }
            }

            
            
            Console.ReadKey();

        }
    }
}
