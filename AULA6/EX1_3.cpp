#include<iostream>

using namespace std;


int funcao1(int numero)
{
    int inverter = 0;

    while (numero != 0)
    {
        int digito= numero % 10;       //pega o último dígito          
        inverter= inverter*10 +digito; //empurra o invertido pra esqu.|encaixa o novo dígito na direita
        numero= numero / 10;           //remove o último dígito
    }
    return inverter;
}
int main()
{
    int numeroDigitado;
    int resultado;

    cout<< "Digite o numero que deseja que seja invertido: "<< endl;
    cin >> numeroDigitado;

    resultado = funcao1(numeroDigitado);

    cout<<"O numero digitado acima e assim invertido: "<<resultado << endl;
    return 0;
}