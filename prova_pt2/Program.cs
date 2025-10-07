using System;

namespace Programamtmassa
{
    public class Livro
    {

        public string Titulo;
        public string Autor;
        public int AnoPublicacao;

        public Livro(string titulo, string autor, int AnoPublicacao)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPublicacao = AnoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Titulo} – {Autor} ({AnoPublicacao})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Reuri Pote -", "J.K Rowling", 1954);

            livro1.ExibirInformacoes();

            // O que esperamos de saída: Reuri Pote - J.K Rowling (1954)
        }
    }
}
