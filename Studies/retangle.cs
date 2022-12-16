namespace Exercicios
{
    public class retangle
    {
        public double a;
        public double b;

        public double area(double a, double b){
            return a * b;
        }

        public double peri(){
            return a*2 + b*2;
        }

        public double diag(){
            return Math.Sqrt((a*a)+(b*b));
        }
    }

class pro {
  static void Main5(string[] args) {
     
     retangle T;
     T = new retangle();

     
     
     System.Console.WriteLine("Escreva dois valores para areas do retangulo: h e w");
     System.Console.Write("h: ");
     T.a = double.Parse(Console.ReadLine());
      System.Console.Write("w: ");
    T.b = double.Parse(Console.ReadLine());
    double Area = T.area(T.a, T.b);
    double Perimetro = T.peri();
    double Diagonal = T.diag();
     System.Console.WriteLine("Area: " + Area);
    System.Console.WriteLine("Perimetro: " + Perimetro);
    System.Console.WriteLine("Diagonal: " + Diagonal);
     

  }

}


}