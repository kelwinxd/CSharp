// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class teste9 {
        static void Main4(string[] args)
        {
           /* //Raiz Quadrada
           double x = double.Parse(Console.ReadLine());
           System.Console.WriteLine(Math.Sqrt(x));*/

           //Número Maior

           System.Console.WriteLine("Digite 2 números");
           String Numbs = Console.ReadLine();
           String[] Maior = Numbs.Split(' ');
           int n1 = int.Parse(Maior[0]);
           int n2 = int.Parse(Maior[1]);

           double result = Bigger(n1,n2);
           System.Console.WriteLine($"{result} é o maior");
       

             static int Bigger(int a,int b){
            int m;
            if(a > b){
              m = a;
           } else {
              m = b;
           }
           return m;
             }
          



        }
    }
}