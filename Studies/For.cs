using System;

namespace For
{
    class For
    {
        static void Main23(string[] args){

          System.Console.WriteLine("Digite a quantidade de meses que irá poupar: ");
          int N = int.Parse(Console.ReadLine());
          int Poup = 0;
          for(int i = 1; i <= N;i++){
              System.Console.Write($"Mês {i}#: ");
              int Value = int.Parse(Console.ReadLine());
              Poup += Value;

          }
          System.Console.WriteLine($"Sua poupança foi de: {Poup}");


        }
    }
}