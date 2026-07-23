using System;

namespace EX1_3
{
     class Program
    {
        static void Main(string[] args)
        {
            int numerosInt ;

            Console.Write("Digite um numero intero: ");
            numerosInt = int.Parse(Console.ReadLine());

            if (numerosInt %2 == 0)
            {
              Console.WriteLine("O numero digitado e par ! ");
            }
            else
            {
              Console.WriteLine(" O numero digitado e impar");
            }
            
        }
    }            
}


