using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cozinha
{
    public partial class Form1 : Form
    {
        private LibUDP.UDPSocket socket;

        public Form1()
        {
            InitializeComponent();

            socket = new LibUDP.UDPSocket(MensagemRecebida, 6001);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            socket.Close();
            socket.Dispose();
        }

        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            int mesa = buffer[0];
            int qntdade = buffer[1];

            for (int i = 0; i < qntdade; i++)
            {
                int id = (int)buffer[i + 2];
                pedidoRecebido.Items.Add(new PedidoMesa(mesa, Pedido.GetFindByid(id)));
            }
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {

            if (pedidoRecebido.SelectedItem != null)
            {
                pedidoPronto.Items.Add(pedidoRecebido.SelectedItem);
                pedidoRecebido.Items.RemoveAt(pedidoRecebido.SelectedIndex);
            }

        }

        private void enviarBalcao_Click(object sender, EventArgs e)
        {
            PedidoMesa pedido = (PedidoMesa)pedidoPronto.SelectedItem;

            if (pedido == null)
            {
                return;
            }

            byte[] bytes = new byte[3];
            bytes[0] = (byte)pedido.Mesa;
            bytes[1] = 1;
            bytes[2] = (byte)pedido.Pedido.Id;

            pedidoPronto.Items.RemoveAt(pedidoPronto.SelectedIndex);

            string ip = Ip.Text;
            socket.Send(bytes, ip, 6002);

        }


    }
}

