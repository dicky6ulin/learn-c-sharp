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
            int[] nilai = new int[3];
            nilai[0] = 10;
            nilai[1] = 20;
            nilai[2] = 30;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(nilai[i]);
            }
        }
    }
}
