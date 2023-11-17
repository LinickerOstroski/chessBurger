using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessBurger
{
    class Lanche
    {
        string nomeLanche;
        string igredientes;
        float preco;

        public string NomeLanche { get => nomeLanche; set => nomeLanche = value; }
        public string Igredientes { get => igredientes; set => igredientes = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
