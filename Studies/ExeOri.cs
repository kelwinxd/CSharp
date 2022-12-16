using System;



namespace Exeori {
class Dados {
public int Cod {get; private set;}
public string Nome {get; set;}

public double Saldo {get; private set;}



public Dados(int numero, string nome){
        Cod = numero;
        Nome = nome;
}

public Dados(int numero, string nome, double saldo) : this(numero, nome ){
        Saldo = saldo;
}

public void Deposito(double qt){
        Saldo += qt;
}

public void Saque(double qt){
        Saldo -= qt + 5.0;
}


public override string ToString(){
        return "Conta: " + Cod + ", Nome: " + Nome + ", Saldo: " + Saldo.ToString("F2");
}

}
class Tela {

static void Main46(string[] args){

 Dados conta;
System.Console.Write("Entre o número da conta: ");

int numero = int.Parse(Console.ReadLine());
System.Console.Write("Entre com o Nome: ");
string nome = Console.ReadLine();
System.Console.Write("Fará Depósito? (s/n)? ");
char Resp = char.Parse(Console.ReadLine());

if(Resp == 's' || Resp == 'S'){
        System.Console.WriteLine("Entre com seu Depósito: ");
        double Deposito1 = double.Parse(Console.ReadLine());
        conta = new Dados(numero, nome, Deposito1);

} else {
        conta = new Dados(numero, nome);
}
System.Console.WriteLine("------------------");
System.Console.WriteLine("Dados da conta: ");
System.Console.WriteLine(conta);

System.Console.WriteLine("-----------------");
System.Console.WriteLine("Entre Valor para Deposito: ");

double money = double.Parse(Console.ReadLine());
conta.Deposito(money);
System.Console.WriteLine("Dados Atualizados: ");
System.Console.WriteLine(conta);

System.Console.WriteLine("Quanto sacará?: ");
double debit = double.Parse(Console.ReadLine());
conta.Saque(debit);
System.Console.WriteLine("Dados Atualizados: ");
System.Console.WriteLine(conta);




}



}

}