//Desenvolva um programa em C# que simule um sistema 
//de seleção de heróis da Marvel para uma equipe. 
//O programa deve ter as seguintes funcionalidades:
//a) Cadastro de Heróis:   
//b) Seleção de Equipe:    
//c) Pontuação Total da Equipe:     
//d) Exibição da Equipe:          
//e) Menu:           
//COM Requisitos Adicionais:

using System;
using System.Security.Cryptography.X509Certificates;

namespace  EX3_3
{
    class Program
    {
        void superHerois()
        {
           Public string [] superherois = new string[5]; 
          Public string [] poder = new string [5];
          Public int []  pontuacao = new int [5];

            for(int i = 0; i<5; i++)
            {
            Console.WriteLine("digite o nome do superheroi A: {i}");
            superherois [i] = Console.ReadLine()!;
            Console.WriteLine("digite o poder do superheroi A: {i+1}");
            poder [i] = Console.ReadLine()!;
            Console.WriteLine("digite a  pontuacao [5]  do superheroi A: {i+2}");               
            pontuacao [i] = int.Parse( Console.ReadLine()!);
            }
        }
        void sel_equipe()
        {
            int A = 0;
            int B = 0;
            int C = 0;

            int selecionado;

            for(int i = 1 ; i<=3; i++)
            {

   
        Console.WriteLine($"superherois: {superHerois[i]} | Poder: {poder[i]} | Pontuacao: {pontuacao[i]}");
    
}
               
        }
        void pont_total()
        {
            int A = 0;
            int B = 0;
            int C = 0;

          for(int i = 0 ; i<=3; i++)
            {
                if(i == 0)
                {   
                    A = int.Parse(Console.ReadLine()!);
                }
                else if(i == 1)
                {   
                    B= int.Parse(Console.ReadLine()!);
                }
                else if ( i==2 )
                {   
                    C =int.Parse(Console.ReadLine()!);
                }
                else
                {
                  Console.WriteLine("opcao invalida!");
                }                   
            } 
        }
        void exib_equipe()
        {
            
        }
        void menuPrincipal()
        {
            
        }

        static void Main(String [] args)
        {

            




          
            
        }
    }
}
