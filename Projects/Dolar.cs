using System;
using System.Globalization;



namespace Exerc {
    class Dolar {
        static void Main45(string[] args){
           
           
            System.Console.WriteLine("Digite a cotação do dolar: ");
            double cotação = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o quanto quer comprar: ");
            double qt = double.Parse(Console.ReadLine());

            double total = Conversor.Convert(cotação, qt);
            double comiof = Conversor.IOF(total);

            System.Console.WriteLine("Valor a ser pago em reais com a Taxa IOF: R$:" + comiof.ToString("F2"));
            double fim = double.Parse(Console.ReadLine());

        }
    }

    class Conversor {
        public static double Convert(double cota, double value){
             return cota * value;
        }

        public static double IOF(double total){
            return ((total * 6) / 100) + total; 
        }
    }

   




}