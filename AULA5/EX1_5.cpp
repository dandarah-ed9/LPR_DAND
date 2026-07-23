#include <iostream>

   using namespace std ;
    
int main()
{
   int quantidade;
   int i = 0; // sempre inicia no 0
   int numero;
   int numerosPares;
   double media;
   double coletor = 0;

   cout << "Digite a quantidade de numeros que sera fornecido: " << endl;
   cin>> quantidade;

   
   // sem aspas, se tiver ele le como se fosse 
   //uma string não uma condição
   while( i < quantidade )
   {
      cout << "Digite os numeros : " << endl;
      cin >> numero;      // le os numeros

      if(numero %2 ==0 )
      {
        coletor += numero; // += serve para somar
        numerosPares++ ;   //pega somente os numeros pares
      }

        i++ ;   // contador
    } 
    
    media = coletor/numerosPares;
    cout<< "A media dos numeros digitados e: "<< media << endl;

    return 0 ;
}   
    