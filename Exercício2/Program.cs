using System;

namespace Exercício2
{
    /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
       Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
       essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int X = 0;
            int Y = 0;

            Console.WriteLine("Qual a quantidade de valores Inteiros a ser digitados? ");
            N = int.Parse(Console.ReadLine());


            for(int i = 1; i<=N; i++)
            {
                Console.WriteLine("Valor #{0}", i);
                int Valor = int.Parse(Console.ReadLine());

                if(Valor >= 10 && Valor <= 20)
                {
                    X = X + 1;
                }
                else
                {
                    Y = Y + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(X + " In");
            Console.WriteLine(Y + " Out");
        }
    }
}
