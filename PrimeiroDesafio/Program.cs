/*
                        Primeiro desafio do bootcamp Decola Tech 2a edição da DIO.

                                            1/6 Xenlongão

            Kogu está buscando as esferas do dragão para invocar Xenlongão e pedir para ele reviver seu amigo
            Kuriri, que infelizmente morreu de novo na última batalha dos guerreiros Zê.

            Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlongão que é seu 
            conhecido há muito tempo, decidiu abrir uma exceção e aceitou ser invocado caso Kogu encontre 
            todas as esferas cujo o número de divisores da quantidade de estrelas da esfera sejam par.

            Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro 
            estrelas, pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas 
            para invocar Xenlongão.
            Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de 
            esferas existentes, mostre a quantidade mínima de esferas que ele precisa procurar.

            Entrada:
            A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste. 
            As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 109) que representa a quantidade de esferas 
            necessárias para invocar Xenlongão.

            Saída:
            Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.
            */
using System;

namespace PrimeiroDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            int N;
            int divisores;
            int divisoresImpares = 0;
            int qtdaMinimaEsferas;
            //Número de casos
            C = int.Parse(Console.ReadLine());
            for(int casos = 0; casos < C; casos++){
                //Número de esferas
                N = int.Parse(Console.ReadLine());
                if(N >= 2 && N <= 109){
                    //Passa por cada esfera para analisar a quantidade de divisores que ela possui.
                    for(int esfera = 0 ; esfera <= N; esfera++){
                        divisores = 0;
                        for(int aux = 1; aux <=esfera; aux++){
                            int resultado = esfera % aux;
                            if(resultado == 0){
                                //Armazena a quantidade de divisores de cada esfera.
                                divisores ++;
                            }
                        }
                        if((divisores % 3) == 0){
                            //Armazena a quantidade de esferas que possuem divisores ímpares em cada caso.
                                divisoresImpares ++;
                        }
                    }  
                }
                qtdaMinimaEsferas = N - divisoresImpares;
                Console.WriteLine(qtdaMinimaEsferas);
                divisoresImpares = 0;
            }
        }
    }
}