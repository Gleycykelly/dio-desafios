            /*
                            Quinto desafio do bootcamp Decola Tech 2a edição da DIO.
                                            5/6 Vai Ter Copa?
            Kluper é o país sede da copa do mundo. Porém, há muitas pessoas protestando contra o governo. 
            Em redes sociais é possível ver pessoas afirmando que não vai ter copa devido aos protestos e 
            insatisfação política

            Mas esses rumores de que não haverá copa são totalmente falsos, e o governo já avisou: vai ter 
            copa sim! 

            Entrada:
            A entrada contém vários casos de teste. Cada caso de teste consiste de uma linha contendo o número 
            N de reclamações sobre a copa encaminhadas para o governo (0 ≤ N ≤ 100).

            Saída:
            Para cada teste, a saída consiste de uma linha dizendo "vai ter copa!" caso não haja reclamações 
            para o governo. Caso haja reclamações, a saída deverá dizer "vai ter duas!".
            */
using System;

namespace QuintoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while((entrada = Console.ReadLine())!= null)
            {
                int N = int.Parse(entrada);
                if(N >=0 && N <=100){
                    if (N == 0){
                        Console.WriteLine("vai ter copa!"); 
                    }
                    else{
                        Console.WriteLine("vai ter duas!");
                    }
                }
            }
        }
    }
}
