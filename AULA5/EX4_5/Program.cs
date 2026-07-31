//ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO: Solicite 
//ao usuário para inserir um número e calcule a soma 
//dos dígitos do quadrado desse número. Por exemplo, 
//se o número fornecido for 123, calcule 123² = 15129 
//e então a soma dos seus dígitos: 1 + 5 + 1 + 2 + 9 = 18.

using System;

namespace  EX4_5
{
    class Program
    {
        static void Main(String [] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine()!);

            int quadrado = numero * numero;
            int digito;
            int somatorio =0 ;

            while(quadrado > 0)
            {
             digito = quadrado % 10;
             somatorio += digito;
             quadrado = quadrado /10; 
            }
            Console.WriteLine("A soma dos quadrado sao: " +somatorio);
        }
    }
}   