//ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO: Crie um 
//programa que simula o treinamento de um Jedi. O 
//usuário deve inserir o número de horas de treinamento 
//por dia. O programa deve calcular o total de horas de 
//treinamento em uma semana, desconsiderando sábados e 
//domingos, e informar quantos dias, semanas e meses 
//seriam necessários para alcançar o total de 1000 horas
//de treinamento. Considere 1 mês = 4,5 semanas.

using System;

namespace  EX4_5
{
    class Program
    {
        static void Main(String [] args)
        {
            double quantHdias;
            int totalSemana;
            int i = 0;

            string [] dias = { "segunda","terca", "quarta", "quinta" , "sexta" };

            for (i = 0; i< dias.Length ; i++)
            {
            //Agora o C# entende que {nome} deve ser substituído pelo valor da 
            //variável, c# n entende sozinho por isso tem q colocar
            Console.WriteLine($"Digite o numero da quantidade de horas treinadas na {dias [i]}-feira: ");
            quantHdias = double.Parse(Console.ReadLine()! .Replace("," , "."));
            
            totalSemana += quantHdias;
            }


            




        }            
    }
}