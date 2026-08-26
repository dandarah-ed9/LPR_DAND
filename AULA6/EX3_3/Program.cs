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

namespace  EX3_3
{
    class Program
    {
        void superHerois()
        {
          string  superHerois1 , superHerois2 ,superHerois3 ,superHerois4 ,superHerois5;
          string  poder1 , poder2 ,poder3 ,poder4 ,poder5;
          int  pontuacao1 , pontuacao2 ,pontuacao3 ,pontuacao4 , pontuacao5;

            for(int i = 0; i<=5; i++)
            {
            Console.WriteLine("digite o nome do superheroi A: {i}");
            
            Console.WriteLine("digite o poder do superheroi A: {i+1}");

            Console.WriteLine("digite a pontuacao  do superheroi A: {i+2}");
                
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
            Console.WriteLine("digite superheroi A que deseja: ");
            selecionado = int.Parse(Console.ReadLine()!);

                if(i == 1)
                {   
                    A = selecionado;
                }
                else if(i == 2)
                {   
                    B = selecionado;
                }
                else if ( i==3 )
                {   
                    C = selecionado;
                }
                else
                {
                  Console.WriteLine("opcao invalida!");
                }
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
