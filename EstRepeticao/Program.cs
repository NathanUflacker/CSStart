using System;
using System.Text;

namespace Funcoes
{
    class Program
    {

        static void Main(string[] args)
        {

            // Atividade 02/09/2025

            // Setando variáveis de altura e linha
            int altura = 10; // Definirá a altura da nossa figura
            int linha = 0; // Definirá a quantidade de caractéres especiais por linha

            while (linha <= altura) // Precisamos iniciar o loop com a condição de linha menor ou igual a altura.
            {
                // Calculando a quantidade de espaços em branco
                int nespacos = altura - linha;
                Console.Write(new string(' ', nespacos)); // Imprimindo os espaços em branco

                // Imprimindo os asteríscos
                Console.WriteLine(new string('*', linha));

                // Incrementando a variável linha
                linha++;

            }
        }
    }
}