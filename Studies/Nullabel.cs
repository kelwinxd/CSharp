using System;

namespace Nullable
{
    class Null {
static void Main676(string[] args){

    int? paciencia = null;
    double? money = 100.0;

// Getvalue or default pega o valor da variavel, e se caso não houver, é zero.
    System.Console.WriteLine(paciencia.GetValueOrDefault());
// Has Value é booleano, se houver valor é true, caso não é falso
    System.Console.WriteLine(money.HasValue);
//Value apenas mostra o valor da variável, obrigando-a a ter um valor       

    if(paciencia.HasValue){
        System.Console.WriteLine(paciencia.Value);
    } else {
        System.Console.WriteLine("nao tem valor");
    }

    if(money.HasValue){
        System.Console.WriteLine(money.Value.ToString("F2"));
    }else{
        System.Console.WriteLine("nao tem valor");
    }

 //Operador de coalescencia nula
 // "A" recebe paciencia, mas se caso ele for nulo, será 100.0
    double a = paciencia ?? 100.0;
    double b = money ?? 50;


}



    }
}