using M1S02_Ex_3_a_6.Classes.Enum;

namespace M1S02_Ex_3_a_6.Classes
{
    public class ContaBancaria
    {
        // Semana 03 - Exercício 4
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // Semana 03 - Exercício 3
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }
       
        // Semana 03 - Exercício 5
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
            Random random = new Random();
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);
        }

        //Semana 03 - Exercício 6
        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser transferido precisa ser maior do que 0");
                return;
            }
            if (valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            _saldo = _saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"O valor de R$ {valor} foi transferido com sucesso!");
        }

        // Semana 02 - Exercício 4
        public void Depositar (decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor a ser depositado deve ser maior do que 0");
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }

        // Semana 02 - Exercício 5
        public void Sacar (decimal valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("O valor a ser sacado deve ser maior do que 0");
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor de saque não pode ser maior que o saldo atual da conta");
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

        // Semana 02 - Exercício 6
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}
