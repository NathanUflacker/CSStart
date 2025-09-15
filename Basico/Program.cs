using System;
using System.Linq; //Este import é necessário para poder usar SequenceEqual no final do código.

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //array de int
            int[] listaNumeros = { 1, 2, 3, 4 }; //array daquele tipo de variável. O Colchete nos diz isso. 
            int[] numeros = new int[4]; //criando uma lista de números inteiros e dizendo que existem 4 itens.
            Console.WriteLine("Digite os 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' '); //lê a linha e separa por espaço

            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Por favor, insira exatamente 4 números.");
                return; //encerra o programa se não tiver 4 números
            }

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                //converter string para int
                if (int.TryParse(entrada[i], out int numero)) //tenta converter a string para int
                {
                    numeros[i] = numero; //Nessa linha estamos iterando os números de "numero" e adicionando dentro da lista "numeros"
                }
                else
                {
                    Console.WriteLine($"'{entrada[i]}' não é um número válido.");
                    return; //encerra o programa se a conversão falhar
                }
            }
            
                if (numeros.SequenceEqual(listaNumeros)){ //Comparação se os elementos das duas listas são iguais.
                    Console.WriteLine("Senha Correta. Bem Vindo(a)!!!");
                } else {
                    Console.WriteLine("Senha Incorreta");
                }
            
        }
    }
}
