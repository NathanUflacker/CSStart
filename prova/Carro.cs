using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Carro : Veiculos
    {
        string modelo;
        public Carro(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoas = 4;
            this.placa = placa;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000");
        }
        public override string Acelerar()
        {
            return "Existem " + this.pessoas + " no " + " Carro " + " e ele está acelerando unheeeeun";
        }
    }
}