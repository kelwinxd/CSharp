namespace ExercicioSa
{
    public class SalaryP
    {
        
         public string Nome;
         public double Salario;
          public double Imposto;

          

       public double Salaliq(){
          return Salario - Imposto;
       }

       public double Porc(double p){
          return (Salaliq() * (p/100)) + Salaliq();
       } 


    }



    class program {
 static void Main88(string[] args){

      SalaryP dados;
      dados = new SalaryP();

     System.Console.Write("Nome: ");
     dados.Nome = Console.ReadLine();
     System.Console.Write("Salario: ");
     dados.Salario = double.Parse(Console.ReadLine());
     System.Console.Write("Imposto: ");
     dados.Imposto = double.Parse(Console.ReadLine());

     double Liq = dados.Salaliq();
     System.Console.WriteLine($"Nome: {dados.Nome}, Salario: {Liq}");
     System.Console.WriteLine("Digite a porcentagem que deseja aumentar seu salário: ");
     double N = double.Parse(Console.ReadLine());
      dados.Porc(N);
      double Porcentagem = dados.Porc(N);


     System.Console.WriteLine($"Nome: {dados.Nome}, Salario: {Porcentagem}");








    }

    }
   
}