            /*

                    Terceiro desafio do bootcamp Decola Tech 2a edição da DIO.
                                    3/6 Sequência S
            Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
            S = 1 + 1/2 + 1/3 + … + 1/100

            Entrada:
            Não há nenhuma entrada neste problema.

            Saída:
            A saída contém um valor correspondente ao valor de S.
            O valor deve ser impresso com dois dígitos após o ponto decimal.
            */
using System;

namespace TerceiroDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0, divisao;
            for(int aux = 1; aux <=100; aux++){
                divisao = 1/(double)aux;
                S += divisao;
            }
            var resultado = Math.Round(S, 2);
            Console.WriteLine(resultado);
        }
    }
}
