//Ler o código de uma peça 1, o número de peças 1 , o valor unitário de cada peça 1,
//o código de uma peça 2 , o numero de peças 2.
//Calcule e mostre o valor a ser pago.

using System;

namespace EX4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1 , quantidade1;
            double valor1;

            int codigo2 , quantidade2;
            double valor2;
            
          //peças 1 
          Console.Write("Digite o código da peca 1: ");
          codigo1 = int.Parse(Console.ReadLine());

          Console.Write("Digite a quantidade de pecas 1: ");
          quantidade1 = int.Parse(Console.ReadLine());

          Console.Write("Digite o valor unitario da peca 1: ");
          valor1 = double.Parse(Console.ReadLine());

            //peças 2
          Console.Write("Digite o código da peca 2: ");
          codigo2 = int.Parse(Console.ReadLine());

          Console.Write("Digite a quantidade de pecas 2: ");
          quantidade2 = int.Parse(Console.ReadLine());

          Console.Write("Digite o valor unitario da peca 2: ");
          valor2 = double.Parse(Console.ReadLine());

          double ValorTotal = (quantidade1 * valor1 ) + (quantidade2 * valor2);

          Console.WriteLine ("O valor total a pagar sera de : " +
        }
    }
}
