using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //array de int
            int[] listaNumeros = { 1, 2, 3, 4 }; //array daquele tipo de variável. O Colchete nos diz isso. 
            int[] numeros = new int[4];
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
                    listaNumeros[i] = numero; //se conseguir, atribui o valor ao array
                }
                else
                {
                    Console.WriteLine($"'{entrada[i]}' não é um número válido.");
                    return; //encerra o programa se a conversão falhar
                }
            }

            if (numeros.SequenceEqual(listaNumeros)) //compara os dois arrays
            {
                Console.WriteLine("Senha Correta!!!");
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
            }
        }
    }
}