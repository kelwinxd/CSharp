// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class teste10 {
        static void Main1(string[] args)
        {
           System.Console.WriteLine("Digite um numero");
             double SquareRoot = double.Parse(Console.ReadLine());

             /*Se der verdadeiro, executa em loop
             Se nao, pula.
             */
             while(SquareRoot >= 0.0){
 System.Console.WriteLine(Math.Sqrt(SquareRoot).ToString("F3")); 
 System.Console.WriteLine("Digite outro numero");
              SquareRoot = double.Parse(Console.ReadLine());


             }
             System.Console.WriteLine("Errado negativo ");
             
            




             

        }
    }
}