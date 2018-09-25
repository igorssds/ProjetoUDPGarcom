using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balcao
{
    public partial class Form1 : Form
    {
        private LibUDP.UDPSocket socket;
        int mesa = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            int qtd = buffer.Length;

            for (int i = 0; i < qtd; i++)
            {
                buffer[i] = (byte)mesa;
                pedidoBalcao.Items.Add(new PedidoMesa(mesa, Pedido.GetFindByid(id)));
            }


        }
    }
}
