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
            socket = new LibUDP.UDPSocket(MensagemRecebida, 6002);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            socket.Close();
            socket.Dispose();
        }


        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            
            int validarMesa = 0;

            for (int i = 0; i < size; i++)
            {
                buffer[i] = (byte)mesa;

                if(validarMesa != mesa)
                {
                    pedidoBalcao.Items.Add(mesa);
                    validarMesa = mesa;
                }
                
            }


        }
    }
}
