//WHILE: Construa um algoritmo que calcule a média aritmética 
//de um conjunto de números pares fornecidos pelo usuário. 
//O usuário deve fornecer primeiro a quantidade de números que 
//serão digitados, e em seguida, os números considerados na média. 
//O usuário pode digitar números ímpares, que devem ser ignorados. 
//Por exemplo,o 5 informa que serão digitados 5 números (2 7 8 6 
//10), e para a média devem ser considerados apenas os números 
//pares (2, 8, 6 e 10) ignorando o número 7 digitado.

#include <iostream>

   using namespace std ;
    
int main()
{
   double media;
   int quantidade;
   int numero;

   // todo contador e até acumulador sempre 
   //vai iniciar em 0 , ou seja , é necessário colocar 
   //sempre = 0 depois de declarar a variável.
   //Se preferir pode se entender como loop.
   double coletor = 0;
   int numerosPares = 0;
   int i = 0; 
    

   cout << "Digite a quantidade de numeros que sera fornecido: " << endl;
   cin>> quantidade;

   
   // sem aspas, se tiver ele le como se fosse 
   //uma string não uma condição
   while( i < quantidade )
   {
      cout << "Digite os numeros : " << endl;
      cin >> numero;      

      if(numero %2 ==0 )
      {
        coletor += numero; // += serve para somar
        numerosPares++ ;   //é um contador somente dos numeros pares
      }

        i++ ;   // contador
    } 
    
    media = coletor/numerosPares;
    cout<< "A media dos numeros digitados e: "<< media << endl;

    return 0 ;
}    