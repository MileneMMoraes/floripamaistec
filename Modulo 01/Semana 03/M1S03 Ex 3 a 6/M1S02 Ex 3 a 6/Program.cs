// Semana 3 - Exercícos de 3 a 6

using M1S02_Ex_3_a_6.Classes;
using M1S02_Ex_3_a_6.Classes.Enum;

ContaBancaria conta1 = new ContaBancaria(1234, 5678, "Milene Moraes", TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria("Fulano", TipoContaEnum.POUPANCA);

conta1.Depositar(200);

conta1.Transferir(conta2, 50);

conta1.ExibirSaldo();

conta2.ExibirSaldo();