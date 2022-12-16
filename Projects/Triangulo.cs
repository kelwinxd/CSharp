// See https://aka.ms/new-console-template for more information
using System;

namespace Program2
{
    class Triangulo {
       
        public double A;
        public double B;
        public double C;

}

   class Program2 {
        static void Main3(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

           System.Console.WriteLine("Escreva 3 valores para os lados do triangulo x");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());


           System.Console.WriteLine("Escreva 3 valores para os lados do triangulo y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            

           



          

        }



   }
}