using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn
{
    internal class Program
    {
        // void ==> method atau fungction


        //static void main(string[] args)
        //{
        //    tampilkan();

        //    void tampilkan()
        //    {
        //        for( int i = 0; i < 5; i++)
        //        {
        //            console.writeline("hallo semuanya");
        //        }
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    Tampilkan();
        //}

        //static void Tampilkan()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Hallo Semuanya");
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    Tambah(20,10);
        //}

        //static void Tambah(int a, int b)
        //{
        //    Console.WriteLine("Total : " + (a + b));
        //}


        static void Main(string[] args)
        {
            Login();
        }

        static void Login()
        {
            string username = "";
            string password = "";

            while (username != "admin" && password != "admin")
            {
                Console.Write("Username : ");
                username = Console.ReadLine();
                Console.Write("Password : ");
                password = Console.ReadLine();

                if (username == "admin" && password == "admin")
                {
                    Console.WriteLine("Selamat datang admin !");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Username or password salah");
                }
            }
        }

    }
}
