namespace Encap
{
     class DBZ
    {
       private string  _sayajin;
       private int _poder;

       private int _life;

      
  public DBZ(string nome, int poder, int life){
         _life = life;
         _poder = poder;
         _sayajin = nome;
  }


       public int Attack( ){
           return _life - _poder;


       }

       public int GetLife(){
        return  _life;
       }

       public void SetPoder(int power){

        if(power != 0){
  _poder = power;
        }
      
       }





      public override string ToString(){
        return _sayajin + " Ataca o Inimigo com vida de " + _life + ", e este fica com " + Attack();
      }
       



    }


    class main {

      static void Main454(string[] args){

          
          DBZ luta = new DBZ("Goku", 50, 100);

           luta.SetPoder(0);
          
           System.Console.WriteLine(luta);






      }



    }
}