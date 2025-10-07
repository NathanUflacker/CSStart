using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Caminhao : Carro
    {
        float cargamax;
        public Caminhao(string placa, string modelo, string cor, string motor, float cargamax) : base(placa, modelo, cor, motor) // base do construtor, do modelo pai.
        {
            capacidadePessoas = 2;
            this.cargamax = cargamax;
            capacidadePessoas = 2;
            this.placa = placa;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000");
            // só escrevemos o que for específico do Caminhao
        }
        public override string Acelerar()
        {
            return "Existem " + this.pessoas + " no " + " Minhão " + " e ele está acelerando ligeiro demais pae";
        }
    }
}