// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace Entrada
{
    class Enter {
        static void Main1(string[] args)
        {
          //Criar Entradas de dados String
           string frase1 = Console.ReadLine();
           string cor = Console.ReadLine();
           string bandas = Console.ReadLine();
           
           // Entrada em que se digita mais elementos e eles são guardados em variáveis separadas
           // String[] vet é o vetor da String, Split corta tudo que estiver entre espaços em branco
           string[] vet = bandas.Split(' ');
           string a = vet[0];
           string b = vet[1];
           string c = vet[2];

           // Entrada de dados Int
           // int.Parse Converte o Valor lido em Int
           int n1 = int.Parse(Console.ReadLine());
           
           // Entrada de dados Char
           // char.Parse Converte para Char
           char Genre = char.Parse(Console.ReadLine());

           double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


           //Usando String[] vet Para tipos diferentes juntos
           string cadastro = Console.ReadLine();
           String[] vet1 = cadastro.Split(' ');

           string nome = vet[0];
           int ano = int.Parse(vet[1]);
           double peso = double.Parse(vet[2], CultureInfo.InvariantCulture);

           System.Console.WriteLine($"Seu nome é {nome}, Ano: {ano} e Peso: {peso}.");



           /*
           System.Console.WriteLine($"Voce tem {n1} de idade, é do Sexo {Genre}e tem {Altura.ToString("F2",CultureInfo.InvariantCulture)}cm de Altura");*/

           string dados = Console.ReadLine();
           String[] date = dados.Split(' ');
           string Pnome = date[0];
           string Unome = date[1];
           int room = int.Parse(date[2]);
           double product = double.Parse(date[3]);

           System.Console.WriteLine($"{Unome} de sobrenome, tem {room} quartos e comprou uma cama de {product.ToString("F2",CultureInfo.InvariantCulture)} Reais");









           
        /*
           System.Console.WriteLine($"Seu nome é: {frase1}");
           System.Console.WriteLine($"Sua cor favorita é: {cor}");
           System.Console.WriteLine($"Suas bandas favoritas são: {a}, {b} e {c}");*/
           
           

        }
    }
}