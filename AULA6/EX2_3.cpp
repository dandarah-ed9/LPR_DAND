//Construa um algoritmo em C++ que agrupe 
//em funções os exercícios 1, 3 e 4 da tarefa 
//de estruturas de repetições. Cada exercício 
//deve estar contido em uma função separada. 
//Defina os parâmetros de modo eficiente e 
//generalista. Construa um menu na função main. 
//Reuse os códigos das suas respostas da tarefa 
//no GitHub ou a resposta do professor postada no AVA.

#include <iostream>
using namespace std;

void exercicio1 ()
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
}
void exercicio3 ()
//Já que o número vai ser digitado dentro da própria função 
//(não vem de fora), a função não precisa de parâmetro nenhum.
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
void exercicio4 ()
//Já que o número vai ser digitado dentro da própria função 
//(não vem de fora), a função não precisa de parâmetro nenhum.
{
    cout << "Digite um numero: " << endl;

    int numero ;
    cin >> numero;

    int quadrado = numero * numero;
    int digito;
    int somatorio =0 ;

    while(quadrado > 0)
    {
        // '%' calcula o resto(sobra) de uma divisão, exemplo ' %10 '. 
        //Regra: numero % 10 sempre devolve o último dígito de qualquer número.

        //Regra: numero / 10 sempre remove o último dígito, "empurrando" o número pra frente.
        // '/'(quando os dois números são int) calcula o resultado da divisão,
        // eliminando qualquer casa decimal, exemplo ' /10 '.

        digito = quadrado % 10;
        somatorio += digito;
        quadrado = quadrado /10; 
    }
        cout << "A soma dos quadrado sao: " +somatorio <<endl;
}
int main()
{
    int opcao;

    do{ 
        cout << "==== MENU =====" << endl;
        cout << "1 - exercicio 1 (media pares)" << endl;
        cout << "2 - exercicio 3 (soma multiplos impares)" << endl;
        cout << "3 - exercicio 4 (soma digitos do quadrado)" << endl;
        cout << "0 - sair " << endl;
        cout << "ESCOLHA : " << endl;
        cin >> opcao;

        switch (opcao)
        {
            case 1:
            exercicio1();
            break;

            case 2:
            exercicio3();
            break;

            case 3:
            exercicio4();
            break;

            case 0:
            cout <<"finalizando o questionario..." << endl;
            break;

            default:
        cout << " opcao invalida "<< endl;
            break;
        }
    } while (opcao!= 0);
    
return 0;

}