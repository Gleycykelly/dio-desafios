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
