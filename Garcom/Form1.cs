using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garcom
{
    public partial class Form1 : Form
    {
        private LibUDP.UDPSocket socket;

        public Form1()
        {

            InitializeComponent();
            menu.Items.AddRange(Pedido.Listar());
            socket = new LibUDP.UDPSocket();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            if (menu.SelectedItem != null)
            {
                itensPedidos.Items.Add(menu.SelectedItem);
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            if (itensPedidos.SelectedItem != null) 
            {
                itensPedidos.Items.RemoveAt(itensPedidos.SelectedIndex);
            }
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Byte[] bytes = new Byte[itensPedidos.Items.Count + 2];

            bytes[0] = (byte)int.Parse(nmrDaMesa.Text);
            bytes[1] = (byte)itensPedidos.Items.Count;

            int count = 0;

            for (int i = 2; i < itensPedidos.Items.Count+2 ; i++)
            {

                bytes[i] = (byte)((Pedido)itensPedidos.Items[count]).Id;
                count++;
            }

            string ip = ipEnvio.Text;
           
            socket.Send(bytes, ip, 6001);

        }

       
    }
}
