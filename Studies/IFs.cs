// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class teste8 {
        static void Main1(string[] args)
        {
            //Par ou Ímpar
           System.Console.WriteLine("Qual seu nome?");
            string Nome = Console.ReadLine();

            System.Console.WriteLine($"{Nome} entre com um número Inteiro:");
            int EvenorOdd = int.Parse(Console.ReadLine());

           if(EvenorOdd % 2 == 0){
                 System.Console.WriteLine("Par");
           }else{
            System.Console.WriteLine("Ímpar");
           }

           //Horas do dia
           System.Console.WriteLine("Qual a hora atual?");
           int time = int.Parse(Console.ReadLine());

           if(time < 12){
            System.Console.WriteLine("Bom dia");
           } else if (time >= 12 && time <= 18){
            System.Console.WriteLine("Boa Tarde");
           } else if(time >18){
            System.Console.WriteLine("Boa noite");
           } 
           
        }
    }
}