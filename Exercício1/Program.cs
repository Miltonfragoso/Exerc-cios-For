using System;

namespace Exercício1
{
    /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, 
     * inclusive o X, se for o caso.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre (1 a 1000): ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
