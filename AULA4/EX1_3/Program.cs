//Fazer um programa para ler um número inteiro, e depois dizer
//se este número é par ou não.

using System;
namespace EX1_3
{
     class Program
    {
        static void Main(string[] args)
        {
            int numerosI ;

            Console.Write("Digite um numero intero: ");
            numerosI = int.Parse(Console.ReadLine());

            if (numerosI %2 == 0)
            {
              Console.WriteLine("O numero digitado e par ");
            }
            else
            {
              Console.WriteLine(" O numero digitado e impar");
            }
            
        }
    }            
}


