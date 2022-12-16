using System;

namespace WhileExe
{
    class teste11 {
       static void Main1(string[] args){

         int SaoPaulo = 0;
         int Palmeiras = 0;
         int Corinthians = 0;
          System.Console.WriteLine("Vote no seu time: 1.SP  2.CR  3.PA");
         int Kindof = int.Parse(Console.ReadLine());

         while(Kindof != 4){
            if(Kindof == 1){
                SaoPaulo += 1;
            } else if(Kindof == 2){
                Palmeiras += 1;
            }else if(Kindof == 3){
                Corinthians +=1;
            }
            System.Console.WriteLine("Vote Novamente:");
             Kindof = int.Parse(Console.ReadLine());
         }

         if(SaoPaulo > Corinthians && SaoPaulo > Palmeiras){
            System.Console.WriteLine("São Paulo Venceu");
         }else if(Corinthians > SaoPaulo && Corinthians > Palmeiras){
            System.Console.WriteLine("Corinthians Venceu");
         }else if(Palmeiras > SaoPaulo && Palmeiras > Corinthians){
            System.Console.WriteLine("Palmeiras venceu");
         }
         System.Console.WriteLine("Obrigado, Segue as Pontuações: ");
         System.Console.WriteLine($"Sao paulo: {SaoPaulo}  Corinthians: {Corinthians}  Palmeiras: {Palmeiras}");

       }


    }


}