using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Kalkulator : \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\npilih salah satu :");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai a =");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai b =");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("\nHasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nHasil Pengurangan " + a + "-" + b + "=" + Pengurangan(a, b));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nHasil Perkalian " + a + "x" + b + "=" + Perkalian(a, b));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nHasil Pembagian " + a + "+" + b + "=" + Pembagian(a, b));
                        break;
                    }
                default:
                    Console.WriteLine("Salah brooo");
                    break;
            }
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        //Penambahan  
        public static int Penambahan(int a, int b)
        {
            int result = a + b;
            return result;
        }
        //Pengurangan  
        public static int Pengurangan(int a, int b)
        {
            int result = a - b;
            return result;
        }
        //Perkalian  
        public static int Perkalian(int a, int b)
        {
            int result = a * b;
            return result;
        }
        //Pembagian  
        public static int Pembagian(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}