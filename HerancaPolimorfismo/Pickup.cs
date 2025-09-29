using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Pickup : Carro
    {
        float cargamax;
        public Pickup(string placa, string modelo, string cor, string motor, float cargamax) : base(placa, modelo, cor, motor) // base do construtor, do modelo pai.
        {
            capacidadePessoas = 2;
            this.cargamax = cargamax;
            capacidadePessoas = 2;
            this.placa = placa;
            Random random = new Random();
            chassi = random.Next().ToString("0000000000");
            // só escrevemos o que for específico da pickup
        }
    }
}
