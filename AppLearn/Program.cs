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
            String username;
            String password;

            Console.Write("Masukan username = ");
            username = Console.ReadLine();

            if(username == "admin")
            {
                Console.Write("Masukan passworld = ");
                password = Console.ReadLine();

                if (password == "admin")
                {
                    Console.WriteLine("Selamat datang admin");
                } 
                else
                {
                    Console.WriteLine("Password salah");
                }
            } 
            else
            {
                Console.WriteLine("Username tidak ditemukan");
            }
        }
    }
}
