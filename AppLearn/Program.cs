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
            // struktur percabangan => if, else, else if

            Console.Write("Masukan Nama anda : ");
            String nama = Console.ReadLine();

            if (nama == "Dicky")
            {
                Console.WriteLine("Selamat datang Dicky");
            } 
            else if (nama == "Agus")
            {
                Console.WriteLine("Selamat datang Agus");
            }
            else
            {
                Console.WriteLine("Siapa anda ??");
            }
        }
    }
}
