// See https://aka.ms/new-console-template for more information
using System;

namespace Coursekel
{
   
   
   
   class Pessoa {

    public string Nome;
    public int Idade;


   }
   
   
    class testeClass {
        static void Main1(string[] args)
        {
           
          Pessoa a, b;
          a = new Pessoa();
          b = new Pessoa();

          System.Console.WriteLine("Dados da 1 pessoa");
          a.Nome = Console.ReadLine();
          a.Idade = int.Parse(Console.ReadLine());

          System.Console.WriteLine("Dados da 2 pessoa");
          b.Nome = Console.ReadLine();
          b.Idade = int.Parse(Console.ReadLine());

          if(b.Idade > a.Idade){
            System.Console.WriteLine($"{b.Nome} é mais velho");
          } else {
            System.Console.WriteLine($"{a.Nome} é mais velho");
          }




           

        }
    }
}