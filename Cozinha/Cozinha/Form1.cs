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

            int count = 2;

            for (int i = 0; i< qntdade; i++ )
            {
                int id = (int)buffer[count];
                pedidoRecebido.Items.Add(new PedidoMesa(mesa, Pedido.GetFindByid(id)));
                count++;
            }
        }
    }
}
