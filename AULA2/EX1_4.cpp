// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

#include <iostream>

int main() 
{
    int raio;
    double Area = 3.1415* raio *raio;  
    
   std:: cout << "Digite o valor do raio: " << raio << " O valor da Area é: " << Area << std::endl;
   std:: cin >> raio;
    return 0;
}