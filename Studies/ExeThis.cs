// See https://aka.ms/new-console-template for more information
using System;

namespace Coursekel3
{
   
   
   
   class Produto {

   public string Nome;
   public int Quantidade;
  public double Preço;

 
  public Produto(){
   Quantidade = 2;
  }
  // This se refere a construção anterior e adiciona a esta
  public Produto(string nome, double preco) : this() {
    Nome = nome;
    Preço = preco;
    
  }


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
        static void Main22(string[] args)
        {
           
         System.Console.WriteLine("Nome:");
         string nome = Console.ReadLine();
         System.Console.WriteLine("Preço");
         double preco = double.Parse(Console.ReadLine());
     
         Produto p = new Produto(nome, preco);

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