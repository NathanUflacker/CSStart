using System;
using System.Text;

namespace Funcoes
{
    class Program
    {

        static void Main(string[] args)
        {
            // for (int i = 0; i < 10; i++) //Inicilização, Condição, Incremento.
            //{
            //    Console.WriteLine("Oi alguma coisa");
            //}
            Console.OutputEncoding = Encoding.UTF8;
            //'/u25A2' é o código Unicode para o caractere quadrado branco.
            // descubra outros códigos em https://unicode-table.com/pt/
            char quadrado = '\u25A2';
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //write nao pula linha
                    Console.Write(quadrado + " ");
                }
                Console.WriteLine();
            }
        }
    }
}