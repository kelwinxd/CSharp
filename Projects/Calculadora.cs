using System;
using System.Globalization;


namespace Course
{
     class Calculadora{
           
           public double Pi = 3.14;
            public double Circunferencia(double r){
             return 2.0 * r * Pi;
        }

        public double Volume( double r){
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
     }
}