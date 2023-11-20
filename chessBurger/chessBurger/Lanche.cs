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
        string ingredientes;
        float preco;

        public string NomeLanche { get => nomeLanche; set => nomeLanche = value; }
        public string Ingredientes { get => ingredientes; set => ingredientes = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
