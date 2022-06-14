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
            //int nilai1 = 10;
            //int nilai2 = 20;
            //int nilai3 = 30;
            //int nilaI4 = 40;

            //int[] nilai = {nilai1, nilai2, nilai3, nilaI4};
            //Console.WriteLine(nilai[0]);

            // ==================================================

            //int[] nilai = new int[2];
            //nilai[0] = 10;
            //nilai[1] = 20;
            //nilai[2] = 30;

            //Console.WriteLine(nilai[0]);

            // ==================================================

            String[] peliharaan = new String[3];
            peliharaan[0] = "Ayam";
            peliharaan[1] = "Kucing";
            peliharaan[2] = "ikan";

            Console.WriteLine(peliharaan[0]);

            Console.WriteLine("=============================================");
            // ==================================================
            // Array Multidimensi 


            int[,] b = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            //Console.WriteLine(b[1, 3]);

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i,j] + " ");
                }
                Console.WriteLine();
            }

            // kalau ada 3 

            int[,,] c = { 
                { 
                    { 1, 2 }, 
                    { 3, 4 } 
                }, 
                { 
                    { 5, 6 }, 
                    { 7, 8 } 
                } };

            Console.WriteLine(c[1,0,1]); // 6
        }
    }
}
