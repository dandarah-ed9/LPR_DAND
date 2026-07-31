//Elabore um algoritmo que calcule a soma de todos 
//os números ímpares múltiplos de 3 que se encontrem 
//no conjunto dos números de 50 a 500.

#include <iostream>

   using namespace std ;
    
int main()
{
    int numero;
    int i= 0;
    int contador = 0;

    // em vez de numero aqui é i ,por isso que tava dando 0.
    for(int i = 50 ; i <= 500; i++)
    {
        if( i %2 != 0 && i %3 == 0)
        {
            contador += i;
        }
    }
    cout <<"A soma de todos os numeros impares sao: "<< contador << endl;
}