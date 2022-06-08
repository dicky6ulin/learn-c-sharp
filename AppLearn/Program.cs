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
            int jurusan;
            Console.WriteLine("Pilih Jurusan : ");
            Console.WriteLine("1. RPL");
            Console.WriteLine("2. TKJ");
            Console.WriteLine("3. Multimedia");

            jurusan = Convert.ToInt32(Console.ReadLine());

            switch (jurusan)
            {
                case 1:
                    Console.WriteLine("Pelajaran adalah RPL");
                    break;
                case 2:
                    Console.WriteLine("Pelajaran adalah TKJ");
                    break ;
                case 3:
                    Console.WriteLine("Pelajaran adalah Multimedia");
                    break;
                default:
                    Console.WriteLine("Inputan tidak ada");
                    break;

            }
        }
    }
}
