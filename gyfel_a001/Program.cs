using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A.1.feladat: bekér két egész számot(𝑎,𝑏), majd kiszámolja a két szám összegét, különbségét.

namespace gyfel_a001
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("a = ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + SzamokOsszege(num1, num2));
            Console.WriteLine($"{num1} - {num2} = {SzamokKulonbsege(num1, num2)}");
            Console.ReadKey();
        }

        static int SzamokOsszege(int a, int b)
        {
            return (a + b);
        }

        static int SzamokKulonbsege(int a, int b)
        {
            return (a - b);
        }
    }
}
