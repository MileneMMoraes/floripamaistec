using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex_1_a_6.Classes
{
    // Semana 04 - Exercício 3:
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Semana 04 - Exercício 6:
        public override void Sacar(decimal valor)
        {
            valor += 0.50M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}
