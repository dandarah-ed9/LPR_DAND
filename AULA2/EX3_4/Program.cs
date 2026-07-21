//leia o número de um funcionário, seu número de horas trabalhadas, 
// o valor que recebe por hora e calcule o salário desse funcionário. 
//mostrar o número e o salário do funcionário, com duas casas decimais.

using System;
namespace EX3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario;
            double horas_trabalhadas ;
            double valor_hora;
            double calc_salario;

           Console.Write("Digite o numero do funcionario: ");
           numeroFuncionario = int.Parse(Console.ReadLine());
        
           Console.Write("Digite o numero de horas trabalhadas: ");
           horas_trabalhadas = double.Parse(Console.ReadLine());

           Console.Write("Digite o valor de uma hora trabalhadas: ");
           valor_hora = double.Parse(Console.ReadLine());

            calc_salario = horas_trabalhadas * valor_hora;

            Console.WriteLine(" Numero do funcionario: "+numeroFuncionario);
            Console.WriteLine(" Salario do funcionario: " +calc_salario);


           
        


        }
    }
}