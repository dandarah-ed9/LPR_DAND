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
            double semanasMes = 4.5;
            double horasTotais = 1000;
            
            double horasPorDia;
            double diasNecessarios;
            double semanasNecessarias;
            double mesesNecessarios;

            double quantHoras;
            double totalSemana = 0;
            int i = 0;


            string [] dias = { "segunda","terca", "quarta", "quinta" , "sexta" };

            for (i = 0; i< dias.Length ; i++)
            {
            //$ o C# entende que {nome} deve ser substituído pelo valor da 
            //variável, c# n entende sozinho por isso tem q colocar
            Console.WriteLine($"Digite o numero da quantidade de horas treinadas na {dias [i]}-feira: ");
            quantHoras = double.Parse(Console.ReadLine()! .Replace("," , "."));
            
            totalSemana += quantHoras;
            }

            horasPorDia = totalSemana/5;
            diasNecessarios = horasTotais / horasPorDia ;
            semanasNecessarias = horasTotais / totalSemana;
            mesesNecessarios = semanasNecessarias/ semanasMes;

            //$ o C# entende que {nome} deve ser substituído pelo valor da 
            //variável, c# n entende sozinho por isso tem q colocar
            Console.WriteLine($"O seu tempo total de treinamento em horas é de: {totalSemana}");
            Console.WriteLine($"Os dias necessarios para completar as 1000 horas é: {diasNecessarios}");
            Console.WriteLine($"As semanas necessarios para completar as 1000 horas é: {semanasNecessarias}");
            Console.WriteLine($"Os meses necessarios para completar as 1000 horas é: {mesesNecessarios}");
        }            
    }
}