using System;
using System.Globalization;

namespace Course
{
    class Static2{
        static void Main888(string[] args){
           Calculadora calc = new Calculadora();
           
             System.Console.Write("Digite o valor da raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);
            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}