using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balcao
{
    class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Id + " - " + Nome;
        }

        public static Pedido[] Listar()
        {
            Pedido[] pedidos = new Pedido[30];

            pedidos[0] = new Pedido { Nome = "Coca Cola", Id = 20 };
            pedidos[1] = new Pedido { Nome = "Jiló", Id = 10 };
            pedidos[2] = new Pedido { Nome = "cus cus", Id = 5 };
            pedidos[3] = new Pedido { Nome = "yakisoba", Id = 35 };
            pedidos[4] = new Pedido { Nome = "sal", Id = 120 };
            pedidos[5] = new Pedido { Nome = "tofú", Id = 26 };
            pedidos[6] = new Pedido { Nome = "pão com ovo", Id = 6 };
            pedidos[7] = new Pedido { Nome = "Guarana Gzus", Id = 33 };
            pedidos[8] = new Pedido { Nome = "Corote", Id = 51 };
            pedidos[9] = new Pedido { Nome = "Alcachofra", Id = 8 };
            pedidos[10] = new Pedido { Nome = "hot dog", Id = 27 };
            pedidos[11] = new Pedido { Nome = "feijoada", Id = 45 };
            pedidos[12] = new Pedido { Nome = "bolo de cenoura", Id = 98 };
            pedidos[13] = new Pedido { Nome = "Maionese", Id = 1 };
            pedidos[14] = new Pedido { Nome = "pizza Doce", Id = 13 };
            pedidos[15] = new Pedido { Nome = "Baião de Dois", Id = 22 };
            pedidos[16] = new Pedido { Nome = "Banana", Id = 44 };
            pedidos[17] = new Pedido { Nome = "cajuina", Id = 255 };
            pedidos[18] = new Pedido { Nome = "Caipirinha", Id = 59 };
            pedidos[19] = new Pedido { Nome = "Caqui", Id = 19 };
            pedidos[20] = new Pedido { Nome = "Bem casado", Id = 68 };
            pedidos[21] = new Pedido { Nome = "Tapioca", Id = 92 };
            pedidos[22] = new Pedido { Nome = "Panqueca", Id = 50 };
            pedidos[23] = new Pedido { Nome = "pacoca", Id = 60 };
            pedidos[24] = new Pedido { Nome = "Sushi", Id = 75 };
            pedidos[25] = new Pedido { Nome = "Guacamole", Id = 23 };
            pedidos[26] = new Pedido { Nome = "Esfiha", Id = 7 };
            pedidos[27] = new Pedido { Nome = "Frango Assado", Id = 96 };
            pedidos[28] = new Pedido { Nome = "Pastel", Id = 39 };
            pedidos[29] = new Pedido { Nome = "Açai", Id = 2 };

            Array.Sort(pedidos, (a, b) =>
            {
                return string.Compare(a.Nome, b.Nome, true);
            });

            return pedidos;
        }

        public static int GetProduto(string nome)
        {
            Pedido[] pedidos = Listar();
            int id = -1;
            for (int i = 0; i < pedidos.Length; i++)
            {
                if (pedidos[i].Nome == nome)
                {
                    id = pedidos[i].Id;
                    break;
                }
            }
            return id;
        }

        public static Pedido GetFindByid(int idrecebido)
        {
            Pedido[] pedidos = Listar();
            String nome = "";
            for (int i = 0; i < pedidos.Length; i++)
            {
                if (pedidos[i].Id == idrecebido)
                {
                    return pedidos[i];
                }
            }
            return null;
        }
    }
}

