using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    abstract class Veiculos
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;
        protected int pessoas;

        bool motorLigado;
        protected int capacidadePessoas;
        protected float estadoDoTanque;

        public void ligarMotor()
        {
            motorLigado = true;
        }

        public void desligarMotor()
        {
            motorLigado = false;
        }

        public int estadoTanque()
        {
            // retorno em %
            return (int)(estadoDoTanque * 100);
        }

        public void AdicionarPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoas) {
                Console.WriteLine("Veículo Lotado");
            }
            this.pessoas = pessoas;
        }
        public virtual string VerificarPessoas() { // virtual dá direito de sobrescrever ele ou não
            return "Existem " + this.pessoas + " pesoas no " + this.GetType().Name;
        }
    }
}
