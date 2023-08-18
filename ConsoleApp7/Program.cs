using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int n = 0, r = 0, y;
            List<int> sequencia = new List<int>();

            for (y = 0; y < 3; y++)
            {
                r++;
                Console.Write("Informe o " + (r) + "° número: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Número invalido: ");
                }
                sequencia.Add(n);
            }
            Console.WriteLine("Número maximo: " + sequencia.Max());           
        }
    }
}
