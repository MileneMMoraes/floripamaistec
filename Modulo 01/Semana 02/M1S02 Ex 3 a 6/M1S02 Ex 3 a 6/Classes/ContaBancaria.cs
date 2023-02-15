using M1S02_Ex_3_a_6.Classes.Enum;

namespace M1S02_Ex_3_a_6.Classes
{
    public class ContaBancaria
    {
        // Semana 02 - Exercício 3
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

        // Semana 02 - Exercício 4
        public void Depositar (decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser depositado deve ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        // Semana 02 - Exercício 5
        public void Sacar (decimal valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("O valor a ser sacado deve ser maior do que 0");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("O valor de saque não pode ser maior que o saldo atual da conta");
            }
            else
            {
                saldo = saldo - valor;
            }
        }

        // Semana 02 - Exercício 6
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
