/*
                            Sexto desafio do bootcamp Decola Tech 2a edição da DIO.
                                            6/6 Sucessor Par
            Dado um número X, retorne o menor número par maior do que X.

            Entrada:
            Uma linha contendo um número  0 < X < 107.

            Saída:
            Uma linha contendo a resposta do problema.

 
            Exemplo de Entrada: 1	
            Exemplo de Saída: 2
            */
using System;

namespace SextoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num>0 && num < 107){
                if((num % 2) == 0){
                    Console.WriteLine(num+2);
                }else{
                    Console.WriteLine(num+1);
                }
            }
        }
    
    }
}
