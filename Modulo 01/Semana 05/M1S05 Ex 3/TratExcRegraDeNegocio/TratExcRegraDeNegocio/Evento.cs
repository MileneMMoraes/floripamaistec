using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecoes
{
    internal class Evento
    {
        int qtdLugares;
        int qntIngressosVendidos;

        public Evento()
        {
        }

        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }

        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!");
        }
    }
}
