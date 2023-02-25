using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex_1_a_6.Classes
{
    // Semana 04 - Exercício 2:
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            Saldo = 0;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser sacado deve ser maior do que 0");
                return;
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor de saque não pode ser maior que o saldo atual da conta");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Saque com o valor de R$ {valor} realizado com sucesso!");
            }
        }
       
        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser depositado deve ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
                Console.WriteLine($"Depósito com o valor de R$ {valor} realizado com sucesso!");
            }
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser transferido precisa ser maior do que 0");
                return;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"O valor de R$ {valor} foi transferido com sucesso!");
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}