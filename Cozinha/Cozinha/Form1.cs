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

            socket = new LibUDP.UDPSocket(MensagemRecebida, 6200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            string mensagem = Encoding.UTF8.GetString(buffer, 0, size);

            lblNmrMesa.Text = buffer[0].ToString();

            int p = buffer[1];
            foreach (Pedido id in Pedido.)
            {

            }
        }

        private void pedidoRecebido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
