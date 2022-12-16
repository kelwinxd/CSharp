using System;
using System.Globalization;

namespace Course
{
    class Static {

        static double Pi = 3.14;
       
        static void Main444(string[] args){

            System.Console.Write("Digite o valor da raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = Circunferencia(raio);
            double vol = Volume(raio);
            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double r){
             return 2.0 * r * Pi;
        }

        static double Volume( double r){
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}