using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int tambah(int a, int b)
            {
                return a + b;
            }
            int hasil = tambah(5, 5);

            Console.WriteLine(hasil);



            //bool apakahLulus(int nilai)
            //{
            //    if (nilai < 78)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //Console.Write("Masukan Nilai : ");
            //int nilaiFinal = Convert.ToInt32(Console.ReadLine());

            //if (apakahLulus(nilaiFinal))
            //{
            //    Console.WriteLine("anda lulus !");
            //}
            //else
            //{
            //    Console.WriteLine("anda tidak lulus");
            //}

            string nilaiFnal = (hasil < 78) ? "Anda lulus !" : "Anda tidak lulus";
            Console.WriteLine(nilaiFnal);

        }
    }
}
