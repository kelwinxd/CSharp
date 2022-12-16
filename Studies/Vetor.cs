using System;

namespace Vetor
{
    class Vet {
static void Main565(string[] bla){


System.Console.WriteLine("Digite a quantidade de alturas a ser calculado");
int n = int.Parse(Console.ReadLine());
double sum = 0.0;
// Como criar Vetores:
// Primeiro, o tipo de dado, colchetes, o nome = instancia new, tipo de dado, colchetes e os parametros
double[] vect = new double[n];

for (int i = 0; i < n; i++)
{     
    System.Console.Write($"Altura {i+1}º: ");
    vect[i] = double.Parse(Console.ReadLine());
    sum += vect[i];
}

double avg = sum / n;
System.Console.WriteLine($"A média das alturas é: {avg}", "F2");


}


    }
}