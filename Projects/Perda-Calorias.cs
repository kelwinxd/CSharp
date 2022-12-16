using System;


namespace Teste {
   



    class proAP {
      static void Main78(string[] args){
  System.Console.WriteLine("Programa de Perda de Calorias");   
  System.Console.WriteLine("------------------------------------ ");
  System.Console.WriteLine(" ");
System.Console.WriteLine("Digite quantos dias irá correr por Semana: ");
     int num = int.Parse(Console.ReadLine());
     int dias = 0;

     for (int i = 1; i <= num; i++)
     {
       System.Console.Write($"Quantos minutos irá correr no {i}º dia?: ");
       int valor = int.Parse(Console.ReadLine());
       dias += valor;
     }

     int result = Caloria(dias);
     int mouth = result * 4;
     System.Console.WriteLine(" ");
     System.Console.WriteLine($"Calorias perdidas na Semana: {result}");
     System.Console.WriteLine($"Calorias perdidas no Mês: {mouth} ");

     int aa = int.Parse(Console.ReadLine());

     static int Caloria(int a){
          return a * 14;
     }






      }




    }
}