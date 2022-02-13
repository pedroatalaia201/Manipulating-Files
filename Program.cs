using System;
using Models;
using Interfaces;
using Helper;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            ICalculadora calc = new Calculadora();
            Console.WriteLine(calc.Somar(1, 1));

            Calculadora calc2 = new Calculadora();
            Console.WriteLine(calc2.Somar(2, 2));
            */
            string path  = @"/mnt/c/Pedro/Dio_DotNet/Poo/Arquivos";

            FileHelper helper = new FileHelper();
            helper.ListDirectories(path);
        }
    }
}
