using System;
using System.Threading;

namespace DezSegundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando a contagem de 0 a 10...");
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("Contagem finalizada!");
        }
    }
}