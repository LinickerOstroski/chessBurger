using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessBurger
{
    class Pedido
    {
        string nomeCliente;
        int lancheEscolhido;

        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public int LancheEscolhido { get => lancheEscolhido; set => lancheEscolhido = value; }
    }
}
