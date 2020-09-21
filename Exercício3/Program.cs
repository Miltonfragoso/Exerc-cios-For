using System;
using System.Globalization;

namespace Exercício3
{
    /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
       de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
       conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
       peso 5.*/
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double N1, N2, N3, med;

            Console.WriteLine("Qual é a quantidade de Número de testes? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i< N; i++)
            {
                Console.WriteLine("Teste#");
                N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Teste#");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Teste#");
                N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                med = ((N1 / 10) * 2) + ((N2 / 10) * 3) + ((N3 / 10) * 5);
                Console.WriteLine(med.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }

         

        }
    }
}
