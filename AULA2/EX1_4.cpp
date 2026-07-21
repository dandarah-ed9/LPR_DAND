// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

#include <iostream>
using namespace std;

int main() 
{
    double raio;
    double pi = 3.1415;
    double Area = pi * raio * raio;  
    
  cout << "Digite o valor do raio:    " << endl;
    cin >> raio;
  cout << " O valor da Area e:    " << Area << endl;
}