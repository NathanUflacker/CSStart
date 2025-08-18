using System;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;

            Console.WriteLine("Bem-vindo, digite 2 números: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            if (r == 0)
            {
                Console.WriteLine("A soma do número " + n1 + " com " + n2 + " é igual que 0.");
            }                                                  
            if (r > 0)                                         
            {                                                  
                Console.WriteLine("A soma do número " + n1 + " com " + n2 + " é maior que 0.");
            }
            if (r < 0)
            {
                Console.WriteLine("A soma do número" + n1 + " com " + n2 + " é maior que 0.");
            }
        }
    }
}

//Add-MpPreference -AttackSurfaceReductionOnlyExclusions "C:\Users\labsfiap\Documents\GitHub"