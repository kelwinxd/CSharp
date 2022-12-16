using System;

namespace Props
{
    class Property {

      //Ordem de escrita correta: Privados, Autoimplementos, Construtores, Props Customizadas e Métodos
      private string _nome;
      
      //Tem como definir as privatizações direto na declaração
      public int Age {get; private set;}

    


      public Property(string nome, int idade){
        _nome = nome;
        Age = idade;
      }

     // Com properties, voce decide se a informação pode ser lida (get) ou mudada (set)
      public string Nome {
        get { return _nome;}
        set {if(value != null){

             _nome = value;
        }
      } }


   

        public override string ToString()
        {
            return _nome + " tem " + Age;
        }

    }



    class Program {
        static void Main45(string[] args){
            
         Property a = new Property ("Kelwin", 24);

         a.Nome = "Gabi";
        

         System.Console.WriteLine(a);                            
          









        }
        


    }
}