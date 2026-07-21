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
