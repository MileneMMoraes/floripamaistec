using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S03_Ex2_Aula_2
{
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            ProdutoFinanceiro PF1= new ProdutoFinanceiro();
            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "verde";
            Console.WriteLine("Nome: " + PF1.nome + "Cor: " + PF1.cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}
