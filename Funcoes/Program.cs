using System;

namespace Funcoes
{
    class Program
    {

        static void  Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        static double CalcularArea(double raio) {
        double r = 0;
            r = Math.Pow(raio, 2) * Math.PI;

            return r;
        }

        static double CalcularRetangulo(double b, double h) { 
            double area = b * h;
            return area;
        }

        static double CalcularCirculo(double r)
        {
            double area = Math.Pow(r, 2) * Math.PI;
            return area;
        }

        static void CalcularTriangulo(double b, double h) {
            double area = (b * h) / 2;
            Print("A area do triangulo é: " + area);
        }


        static void Main(string[] args)
        {
            //Print("insira o raio: ");
            //raio = double.Parse(Console.ReadLine());
            //double resp = CalcularArea(raio);
            //Print("A area do circulo é:" + resp);

            Print("Olá! Seja bem vindo ao programa de calculos de areas!");
            Print("--------------------------------");
            Print("Insira a opção que deseja calcular:");
            Print("--------------------------------");
            Print("1 - Area do circulo \n"+
                "2 - Area do retangulo \n" +
                "3 - Area do triangulo");
            string resposta_usuario = Console.ReadLine();

            if (resposta_usuario == "1")
            {
                Print("Insira o valor do raio: ");
                double raio_circulo = double.Parse(Console.ReadLine());
                Print("A Area do circulo é: " + CalcularArea(raio_circulo)); // Pode colocar embaixo pra mostrar que o print funciona
            }
            else if (resposta_usuario == "2")
            {
                Print("Insira o valor da base: ");
                double base_retangulo = double.Parse(Console.ReadLine());
                Print("Insira o valor da altura: ");
                double altura_retangulo = double.Parse(Console.ReadLine());
                CalcularRetangulo(base_retangulo, altura_retangulo);
            }
            else if (resposta_usuario == "3")
            {
                Print("Insira o valor da base: ");
                double base_triangulo = double.Parse(Console.ReadLine());
                Print("Insira o valor da altura: ");
                double altura_triangulo = double.Parse(Console.ReadLine());
                CalcularTriangulo(base_triangulo, altura_triangulo);
            }
            else {
                Print("Por favor, insira uma opção válida!" );
            }
        }
    }
}