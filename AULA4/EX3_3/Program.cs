//Suponha que você está desenvolvendo um jogo  de RPG. 
//Você é responsável por implementar a  mecânica de  
//habilidades especiais para diferentes classes de personagens.
//Cada classe tem suas próprias habilidades especiais.
//Crie um programa que permita ao jogador escolher uma classe 
//de personagem e, em seguida, exiba suas habilidades
//especiais correspondentes.

using System;
namespace EX1_3
{
     class Program
    {
        static void Main(string[] args)
        {
            int  classe;

            Console.Write("Escolha uma classe: \n 1-Guerreira\n 2-Mago\n 3-Arqueira \n");
            classe = int.Parse(Console.ReadLine()!);
            //o "!" depois do Console.ReadLine , quer dizer que não vai dar null e é pro 
            // compilador confiar nessa afirmação

            //deixar sem aspas dentro dos parenteses. pois se tiver o programa 
            // entende que tudo que estiver dentro do parenteses é uma string e 
            // não uma condição.

            switch (classe)
            {
                case 1 : 
                Console.WriteLine("Você escolheu a Guerreira: ");
                Console.WriteLine("Suas habilidades sao Ataque pesado e Defesa Total ");
                break;

                case 2 : 
                Console.WriteLine("Você escolheu o Mago: ");
                Console.WriteLine("Suas habilidades sao Bola de Fogo e Escudo de Gelo ");
                break;

                case 3 : 
                Console.WriteLine("Você escolheu a Arqueira: ");
                Console.WriteLine("Suas habilidades sao Flecha Precisa e Disparo Triplo ");
                break;

                default: 
                Console.WriteLine("Classe inexistente, escolha novamente! ");
                break;
            }

        }
    }    
}    