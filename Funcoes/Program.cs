using System;

namespace Funcoes
{
    class Program
    {
        //<summary>
        // Criando duas opções de Print para retornar tanto string quanto double
        //</summary>
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value)
        {
            Console.WriteLine(value);
        }


        //static double CalcularArea(double raio)
        //{
        //    double r = 0;
        //    r = Math.Pow(raio, 2) * Math.PI;

        //    return r;
        //}

        //<summary>
        // Criando funções de calcular area. Primeiro criamos a opção para calcular Retangulo, logo em seguida Circulo e finalmente o triângulo. 
        //</summary>

        static double CalcularRetangulo(double b, double h)
        {
            double area = b * h;
            return area;
        }

        static double CalcularCirculo(double r)
        {
            double area = Math.Pow(r, 2) * Math.PI;
            return area;
        }

        static double CalcularTriangulo(double b, double h)
        {
            double area = (b * h) / 2;
            return area;
        }


        static void Main(string[] args)
        {
            //Print("insira o raio: ");
            //raio = double.Parse(Console.ReadLine());
            //double resp = CalcularArea(raio);
            //Print("A area do circulo é:" + resp);

            //<summary>
            // Dentro da execução criamos um programa que cumprimenta nosso usuário, deixando claro a finalidade do sistema e apresentando opções de calculo através de números, para facilitar a leitura pelo programa.
            // Após isso, criamos uma estrutura condicional para cada opção, onde o usuário insere a opção de calculo desejada, logo em seguida o programa lê a resposta e entra na estrutura condicional correta.
            //</summary>

            Print("Olá! Seja bem vindo ao programa de calculos de areas!");
            Print("--------------------------------");
            Print("Insira a opção que deseja calcular:");
            Print("--------------------------------");
            Print("1 - Area do circulo \n" +
                "2 - Area do retangulo \n" +
                "3 - Area do triangulo");
            string resposta_usuario = Console.ReadLine();

            if (resposta_usuario == "1")
            {
                Print("Insira o valor do raio: ");
                double raio_circulo = double.Parse(Console.ReadLine());
                Print("A Area do circulo é: " + CalcularCirculo(raio_circulo)); // Pode colocar embaixo pra mostrar que o print funciona
            }
            else if (resposta_usuario == "2")
            {
                Print("Insira o valor da base: ");
                double base_retangulo = double.Parse(Console.ReadLine());
                Print("Insira o valor da altura: ");
                double altura_retangulo = double.Parse(Console.ReadLine());
                CalcularRetangulo(base_retangulo, altura_retangulo);
                Print("A area do retangulo é: " + CalcularRetangulo(base_retangulo, altura_retangulo));
            }
            else if (resposta_usuario == "3")
            {
                Print("Insira o valor da base: ");
                double base_triangulo = double.Parse(Console.ReadLine());
                Print("Insira o valor da altura: ");
                double altura_triangulo = double.Parse(Console.ReadLine());
                CalcularTriangulo(base_triangulo, altura_triangulo);
                Print("O valor da área é de: ");
                Print(CalcularTriangulo(base_triangulo, altura_triangulo)); // Mostrando que o Print funciona com double
            }
            else
            {
                Print("Por favor, insira uma opção válida!"); // Caso o usuário digite algo fora da programação esperada.
            }
        }
    }
}