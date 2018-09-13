using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozinha
{
    class PedidoMesa
    {
        public int Mesa { get; set; }
        public Pedido Pedido { get; set; }

        public PedidoMesa(int mesa, Pedido pedido)
        {
            Mesa = mesa;
            Pedido = pedido;
        }

        public override string ToString()
        {
            return Mesa + " - " + Pedido;
        }
    }
}
