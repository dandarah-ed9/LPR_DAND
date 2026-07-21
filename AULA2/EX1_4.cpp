//ler o valor do raio de um círculo, e mostrar o valor da área deste círculo
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

#include <iostream>
using namespace std;

int main() 
{
    double raio , Area;
    double pi = 3.14159;
    
    cout << "Digite o valor do raio:    " << endl;
    cin >> raio;

    Area = pi * raio * raio;  

    cout << " O valor da Area do circulo e: " << Area << endl;
}