namespace Vetor2
{

class Product {
  public string Name { get; set; }
  public double Price { get; set; }

}


class Interface {


    static void Main(string[] args){
    System.Console.WriteLine("How much places to travel do you to make and divide with your partner?");
    int n = int.Parse(Console.ReadLine());
    System.Console.WriteLine("How much mouth do you wanna save money?");
    int save = int.Parse(Console.ReadLine());
    
    Product[] vect = new Product[n];

    double sum = 0.0;
        
    for (int i = 0; i < n; i++)
    {
        System.Console.Write("Lugar da Viagem: ");
        string name = Console.ReadLine();
         System.Console.Write("Preço: ");
        double price = double.Parse(Console.ReadLine());
        vect[i] = new Product {Name = name, Price = price};
        sum += vect[i].Price;
    }

    double divide = sum / save ;
    System.Console.WriteLine("");
    System.Console.WriteLine("------------------");
    System.Console.WriteLine($"O Preço Total das viagens:{sum}" );
    System.Console.WriteLine($"Voce deve guardar por {save} meses: {divide.ToString("F2")}");

    string Stop = Console.ReadLine();
    System.Console.WriteLine("");
    int ss = int.Parse(Console.ReadLine());
    












    }
}













}