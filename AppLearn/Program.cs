using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. penjumlahan = +
             2. pengurangan = -
             3. perkalian = *
             4. pembagian = /
             5. modulus / sisa bagi %
             */

            int a;
            int b;

            Console.Write("Masukan Angka A = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka B = ");
            b = Convert.ToInt32(Console.ReadLine());

            double aDouble = Convert.ToDouble(a);
            double bDouble = Convert.ToDouble(b);

            Console.WriteLine("Hasil Penjumlahan = " + (a + b));
            Console.WriteLine("Hasil Pengurangan = " + (a - b));
            Console.WriteLine("Hasil Perkalian = " + (a * b));
            Console.WriteLine("Hasil Pembagian = " + (aDouble / bDouble));
            Console.WriteLine("Hasil Modulus = " + (a % b));
        }
    }
}
