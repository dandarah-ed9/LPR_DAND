//Fazer um programa para ler quatro valores inteiros A, B, C e D. 
//A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D.

#include <iostream>
using namespace std;

int main()
{
    int A, B, C, D;

    cout << "Digite o valor de A: " << endl;
    cin >> A;   

    cout << "Digite o valor de B: " << endl;
    cin >> B; 

    cout << "Digite o valor de C: " << endl;
    cin >> C; 

    cout << "Digite o valor de D: " << endl;
    cin >> D; 

    int DIFERENCA = (A * B - C * D);
    cout << "A Diferenca e: " << DIFERENCA << endl;

    return 0;
}