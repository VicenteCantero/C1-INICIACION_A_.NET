// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;



namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HOLA MUNDO!!!");

            int num1 = 5;
            int nuero2 = 6;
            double numero3 = 2.57;
            double suma;

            suma = num1 + numero3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El número introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}

