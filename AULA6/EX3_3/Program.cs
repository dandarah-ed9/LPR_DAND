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
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace  EX3_3
{
    class Program
    {
        string [] superherois = new string[5]; 
        string [] poder = new string [5];
        int []  pontuacao = new int [5];
        bool [] selecionado  = new bool [5];

    void superHerois()
    {
        for(int i = 0; i<5; i++)
        {
            Console.WriteLine($"digite o nome do superheroi : {i+1}");
            superherois [i] = Console.ReadLine()!;
            
            Console.WriteLine($"digite o poder do superheroi : {i+1}");
            poder [i] = Console.ReadLine()!;
            
            Console.WriteLine($"digite a  pontuacao do superheroi : {i+1}");               
            pontuacao [i] = int.Parse( Console.ReadLine()!);
        }
    }
    void sel_equipe()
    {
        for(int i = 0 ; i<3; i++)
        {
           Console.WriteLine($"superherois: {superherois [i]} | Poder: {poder[i]} | Pontuacao: {pontuacao[i]}");
        }
    }
    void pont_total()
    {
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
          total += pontuacao[i];
        }
          Console.WriteLine($"A pontuacao total da equipe e: {total}");
    }
    void exib_equipe()
    {
        Console.WriteLine("\n--- Equipe Selecionada ---");

        for (int i = 0; i < 5; i++)
        {
            if (selecionado[i] == true)
            {
                Console.WriteLine($"Nome: {superherois[i]} | Poder: {poder[i]} | Pontuacao: {pontuacao[i]}");
            }
        }
    }
    void menuPrincipal()
    {
        int opcao;
        do
        {
           Console.WriteLine("\n===== MENU =====") ;
           Console.WriteLine("1 - Cadastrar Herois ") ;
           Console.WriteLine("2 - Selecionar Equipes") ;
           Console.WriteLine("3 - Ver Pontuacao Total") ;
           Console.WriteLine("4 - Exibir equipe") ;
           Console.WriteLine("0 - Sair") ;
           Console.Write("Escolha Uma Opcao :") ;

           opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
              case 1:
              superHerois();
              break;

              case 2:
              sel_equipe();
              break;

              case 3:
              pont_total();
              break;

              case 4:
              exib_equipe();
              break;

              default:
              Console.WriteLine("Opcao Invalida");
              break;             
            }
        } while(opcao != 0);
    }
        static void Main(String [] args)
        {
            Program programa = new Program();
            programa.menuPrincipal();            
        }
    }
}