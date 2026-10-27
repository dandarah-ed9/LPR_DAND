//Desenvolva um programa em C# que simule um sistema 
//de seleção de heróis da Marvel para uma equipe. 
//O programa deve ter as seguintes funcionalidades:
//a) Cadastro de Heróis:   
//b) Seleção de Equipe (maximo 3 herois):    
//c) Pontuação Total da Equipe:     
//d) Exibição da Equipe:          
//e) Menu:           
//COM Requisitos Adicionais:

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace  EX3_3
{
    class Program
    {
        int quantidade =5;
        string [] superherois = new string[5]; 
        string [] poder = new string [5];
        int []  pontuacao = new int [5];
        string [] selecionado  = new string [3];

    void superHerois()
    {
            Console.WriteLine($"digite a  quantidade de superherois que deseja cadastrar : ");  
            while (true)
                {
                    if(int.TryParse(Console.ReadLine(), out  quantidade)) break;
                    Console.WriteLine("Inválido");
                    Console.Write(": ");
                }
        
        for(int i = 0; i<quantidade; i++)
        {
            string nome ;

            Console.WriteLine($"digite o nome do superheroi : {i+1}");
            while (true)
                {
                    nome = Console.ReadLine()!;
                    if( string.IsNullOrEmpty(nome))
                    {
                        Console.WriteLine("Inválido");
                        Console.Write(": ");
                    }
                    else
                    { 
                        break;
                    }
                }
            superherois [i] = nome;
            string poder2;
            Console.WriteLine($"digite o poder do superheroi : {i+1}");
            while (true)
                {
                    poder2 = Console.ReadLine()!;
                    if(string.IsNullOrEmpty (poder2))
                    {
                        Console.WriteLine("Inválido");
                        Console.Write(": ");
                    }
                    else
                    {
                        break;
                    }
                }
            poder [i] = poder2;
            //alunos[0] = "Ana"
             int pontos ;
            Console.WriteLine($"digite a  pontuacao do superheroi : {i+1}");  
            while (true)
                {
                    if(int.TryParse(Console.ReadLine(), out  pontos)) break;
                    Console.WriteLine("Inválido");
                    Console.Write(": ");
                }   
                pontuacao [i] = pontos;          
        }
    }
    void sel_equipe()
    {
        for(int i = 0 ; i<quantidade; i++)
        {
           Console.WriteLine($"superherois: {superherois [i]} | Poder: {poder[i]} | Pontuacao: {pontuacao[i]}");
        }
        for(int i =0; i<3; i++)
        {
           string selecionar = "";

           Console.WriteLine($"Selecione no maximo 3 herois :  "); 
            selecionar = Console.ReadLine()!.ToString();  
            selecionado[i] = selecionar;   
        }
    }
    void pont_total()
    {
        int total = 0;

        for (int i = 0; i < quantidade; i++)
        {
          total += pontuacao[i];
        }
          Console.WriteLine($"A pontuacao total da equipe e: {total}");
    }
    void exib_equipe()
    {
        Console.WriteLine("\n--- Equipe Selecionada ---");

        for (int i = 0; i < 3; i++)
        {
            for (int i2 = 0; i2 < quantidade; i2++)
            {
                if (selecionado[i] == superherois[i2])
                {
                    Console.WriteLine($"Nome: {superherois[i]} | Poder: {poder[i]} | Pontuacao: {pontuacao[i]}");
                }
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

              case 0:
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