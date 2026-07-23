//Leia 2 valores inteiros (A e B).Mostrar uma mensagem  
//"Sao Multiplos" ou "Nao sao Multiplos", indicando
//se os valores lidos são múltiplos  entre si. Atenção: 
// os números podem ser digitados em ordem crescente ou 
//decrescente.

#include <iostream>

using namespace std;

int main()
{
    int A , B;

   cout<< "Digite um numero para  A: "  << endl;
   cin>> A;
   
   cout<< "Digite um numero para  B: "  << endl;
   cin>> B;

//deixar sem aspas dentro dos parenteses.
//pois se tiver o programa entende que tudo 
//que estiver dentro do parenteses é uma string e não uma condição.

   if ( A %  B == 0  ||  B %  A == 0 )
   {
    cout<< " Os numeros sao multiplos "  << endl;
   }

   else 
   {
    cout<< " Os numeros nao sao multiplos "  << endl;
   }
}