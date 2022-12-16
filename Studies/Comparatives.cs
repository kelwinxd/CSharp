// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class teste {
        static void Main1(string[] args)
        {
            // Exclamação nega o Argumento, && significa E
            bool comp = !(10>60) && 20 >= 20;
            // != significa Diferente, e || significa OU
            bool comp2 = 5 != 5 || 20 < 45;
            
            System.Console.WriteLine(comp);
            System.Console.WriteLine(comp2);

            

        }
    }
}