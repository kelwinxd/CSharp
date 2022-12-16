// See https://aka.ms/new-console-template for more information
using System;

namespace Coursekel
{
   
   
   
   class Produto {

   public string Nome;
   public int Quantidade;
  public double Preço;


  public void Addq(int quant) {
    Quantidade += quant;
  }

  public void Remq(int quant) {
    Quantidade -= quant;
  }

  public double Vtotal(){
    return Quantidade * Preço;
  }

  public override string ToString() {
    return Nome + ", $" + Preço + ", " + Quantidade + " unidades, Valor Total: " + Vtotal();
  }



   }
   
   
    class testeClass2 {
        static void Main8(string[] args)
        {
           Produto p = new Produto();
         System.Console.WriteLine("Nome:");
         p.Nome = Console.ReadLine();
         System.Console.WriteLine("Preço");
         p.Preço = double.Parse(Console.ReadLine());
         System.Console.WriteLine("Quantidade");
         p.Quantidade = int.Parse(Console.ReadLine());

         System.Console.WriteLine("Dados do produto: " + p);

         System.Console.WriteLine("Adicione mais produtos");
         int qtd = int.Parse(Console.ReadLine());
         p.Addq(qtd);
         System.Console.WriteLine(" Dados Atualizados: " + p);
         System.Console.WriteLine("Remova quantos produtos ");
          qtd = int.Parse(Console.ReadLine());
         p.Remq(qtd);

         System.Console.WriteLine("Dados Atualizados denovo: " + p);




           

        }
    }
}