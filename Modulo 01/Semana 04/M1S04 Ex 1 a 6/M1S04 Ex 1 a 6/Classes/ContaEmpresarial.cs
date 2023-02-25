using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex_1_a_6.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        // Semana 04 - Exercício 4:
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }

        // Semana 04 - Exercício 3 e 4:
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            // Semana 04 - Exercício 4:
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;
            //Não adicionei o ValorUsado aqui pois o mesmo tem relação com o empréstimo

            //Semana 04 - Exercício 3:
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }

        // Semana 04 - Exercício 5:
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0 para realizar um empréstimo!");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("O valor ultrapassa seu limite de empréstimo disponível!");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo ativo, para realizar um novo é necessário pagar o anterior!");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }

        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if (total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento total do empréstimo!");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Empréstimo no valor total, incluindo juros, de R$ {total} pago com sucesso!");
        }

        // Semana 04 - Exercício 6:
        public override void Sacar(decimal valor)
        {
            valor += 1.00M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
    }
}
