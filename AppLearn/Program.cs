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
            // convert class => Mengubah tipe data ke tipe data yang lain
            int a;
            int b;
            Console.Write("Masukan Angka a = ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Masukan Angka b = ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Angka adalah = " + (a+b));
        }
    }
}
