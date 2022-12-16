// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class Casting
     {
        static void Main77(string[] args)
        {
         //Sabendo que DOUBLE são valores quebrados e INT inteiros:
         //Para transformar uma variável basta colocar entre parenteses()
           double a;
           int b;
           a = 5.1234;
           b = (int)a;
           // Ou simplesmente deixar um dos valores com vírgula indicará que vc quer resultados quebrados
           double c = 10.0 / 6;

           System.Console.WriteLine(c.ToString("F2"));

           System.Console.WriteLine(b);

           
           // Como ambos são INT o RESULT daria número inteiro, mas pode ser quebrado se:
           int numb = 5;
           int numb2 = 2;
            
            double result = (double)numb / numb2;
            System.Console.WriteLine(result);


            double n1 = 8, raiz = Math.Sqrt(n1);

            System.Console.WriteLine(raiz.ToString("F3"));





        }
    }
}