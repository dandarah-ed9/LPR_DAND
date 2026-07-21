// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

#include <iostream>

int main() 
{
    double raio;
    double pi = 3.1415;
    double Area = pi * raio * raio;  
    
   std:: cout << "Digite o valor do raio: " << std::endl;
   std:: cin >> raio;
   std:: cout << " O valor da Area total e: " << Area << std::endl;

    return 0;
}