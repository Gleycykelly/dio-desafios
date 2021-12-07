            /*
                    Segundo desafio do bootcamp Decola Tech 2a edição da DIO.
                                    2/6 Quadrado de Pares
            Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, 
            inclusive N, se for o caso.

            Entrada
            A entrada contém um valor inteiro N (5 < N < 2000).

            Saída
            Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

            Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 
            1000000 o que ocasionará resposta errada. Neste caso, configure a precisão adequadamente para 
            que isso não ocorra.
            */
using System;

namespace SegundoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //Validação da quantidade de números
            if( N > 5 && N < 2000){
                for(int aux = 1; aux <= N; aux++){
                    //Verifica se o número é par
                    if(aux % 2 == 0){
                        Console.WriteLine($"{aux}^2 = {Math.Pow(aux, 2)}");
                    }
                }
            }
        }
    }
}
