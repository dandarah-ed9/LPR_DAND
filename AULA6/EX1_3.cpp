//Construa uma função em C++ que retorne o reverso de um número inteiro.

#include<iostream>

using namespace std;

int funcao1(int numero) //funçao declarada(parametro)
{
    int inverter = 0;

    while (numero != 0)//enquanto numero for diferente de 0,e quando todos ja foram o loop para.
    {
        int digito= numero % 10;       //pega o último dígito          
        inverter= inverter*10 +digito; //empurra o invertido pra esqu.|encaixa o novo dígito na direita
        numero= numero / 10;           //remove o último dígito
    }
    return inverter; //a funcao volta e a funcao passa a ser essa.
}
int main()
{
    int numeroDigitado;
    int resultado;

    cout<< "Digite o numero que deseja que seja invertido: "<< endl;
    cin >> numeroDigitado;

    resultado = funcao1(numeroDigitado); 
    //chama a função funcao1,entregando o valor de numeroDigitado para ela 
    //(novo parametro"numeroDigitado").executa tudo que está dentro da função 
    //e no return inverter;, esse valor final é guardado na var resultado.

    cout<<"O numero digitado acima e assim invertido: "<<resultado << endl;
    return 0;
}