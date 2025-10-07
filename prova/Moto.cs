using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Moto : Veiculos
    {
        string modelo;
        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoas = 2;
            this.placa = placa;
            this.modelo = modelo;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000");
        }
        public override string Acelerar()
        {
            return "Existem " + this.pessoas + " na " + " moto " + " e ela está acelerando rápido";
        }
    }
}