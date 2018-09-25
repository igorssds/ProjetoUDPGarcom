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
        
        int mesa = 0;
        int qntdade = 0;
        bool validarMsgRecebida = true;

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
            if (validarMsgRecebida)
            {
                mesa = buffer[0];
                qntdade = buffer[1];

                int count = 2;

                for (int i = 0; i < qntdade; i++)
                {
                    int id = (int)buffer[count];
                    pedidoRecebido.Items.Add(new PedidoMesa(mesa, Pedido.GetFindByid(id)));
                    count++;
                }
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

        private void pedidoPronto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enviarBalcao_Click(object sender, EventArgs e)
        {
            Byte[] bytes = new Byte[pedidoPronto.Items.Count+1];

            int primeiraMesa = 0;
            bytes[0] = (byte)primeiraMesa;

            for (int i = 1; i < pedidoPronto.Items.Count+1; i++)
            {                
                bytes[i] = (byte)((PedidoMesa)pedidoPronto.Items[i]).getId();
        
            }
            validarMsgRecebida = false;
            string ip = Ip.Text;
            socket.Send(bytes, ip, 6001);

        }
    }
}

