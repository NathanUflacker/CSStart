using HerancaPolimorfismo;
using System;

class ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculos[] veiculos = new Veiculos[4]; // array de 3 posições

            veiculos[0] = new Carro("hjk123", "fusca", "azul", "AP2.0");
            veiculos[1] = new Moto("ONU943", "cb600", "vermelha", "500cc");
            veiculos[2] = new Moto("sgf999", "Hayabusa", "cinza", "1200cc");
            veiculos[3] = new Caminhao("cbg911", "saveiro", "pretona", "AP1.0", 300);

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].ligarMotor();
                veiculos[i].AdicionarPessoas(2);
                Console.WriteLine(veiculos[i].Acelerar());
            }
        }
    }
}