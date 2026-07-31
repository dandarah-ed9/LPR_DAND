//O seu trabalho é elaborar um 
//algoritmo em que o usuário possa 
//digitar números no console até acertar
//o número inteiro aleatório valorInteiro, 
//de 1 a 100. A cada chute, o programa 
//deve responder com “chutou alto”, 
//“chutou baixo” ou “acertou”. Após 
//acertar, deve ser mostrado quantas 
//tentativas foram usadas para descobrir 
//o número.

using System;

namespace  EX2_5
{
    class Program
    {
        static void Main(String [] args)
        {
         int valorInteiro;
         int contador = 0;
         int i = 0; 

            Random NumAleatorio = new Random ();
            valorInteiro = NumAleatorio.Next(1,100);
        //do { ... } while(...), com o while depois do bloco.
         do 
            {
              Console.WriteLine("Digite o numero aleatorio que foi sorteado: ") ;
              i = int.Parse(Console.ReadLine()!);
              contador++;

                //Sempre testar a condição de igualdade antes das de maior/menor.
                 if(i == valorInteiro)
                {
                  Console.WriteLine("PARABENS!! VOCE ACERTOU. ") ;  
                }
                 else if( i <= valorInteiro)
                {
                  Console.WriteLine("Voce chutou baixo ") ;  
                }
                else if (i >= valorInteiro)
                {
                  Console.WriteLine("Voce chutou alto ") ;  
                }

            // roda mais de uma vez com i !=
            } while(i != valorInteiro);
              Console.WriteLine(" Numero de tentativas: " + contador);    
        }
    }
} 