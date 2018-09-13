namespace Garcom
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ListBox();
            this.itensPedidos = new System.Windows.Forms.ListBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.nmrDaMesa = new System.Windows.Forms.TextBox();
            this.nmrMesa = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipEnvio
            // 
            this.ipEnvio.AccessibleName = "";
            this.ipEnvio.Location = new System.Drawing.Point(39, 9);
            this.ipEnvio.Name = "ipEnvio";
            this.ipEnvio.Size = new System.Drawing.Size(100, 20);
            this.ipEnvio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // menu
            // 
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(16, 69);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(136, 186);
            this.menu.TabIndex = 2;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.DoubleClick += new System.EventHandler(this.adicionar_Click);
            // 
            // itensPedidos
            // 
            this.itensPedidos.FormattingEnabled = true;
            this.itensPedidos.Location = new System.Drawing.Point(251, 69);
            this.itensPedidos.Name = "itensPedidos";
            this.itensPedidos.Size = new System.Drawing.Size(147, 186);
            this.itensPedidos.TabIndex = 3;
            this.itensPedidos.DoubleClick += new System.EventHandler(this.voltar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(161, 86);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 4;
            this.adicionar.Text = ">>";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(161, 138);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "<<";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // nmrDaMesa
            // 
            this.nmrDaMesa.Location = new System.Drawing.Point(197, 9);
            this.nmrDaMesa.Name = "nmrDaMesa";
            this.nmrDaMesa.Size = new System.Drawing.Size(49, 20);
            this.nmrDaMesa.TabIndex = 6;
            // 
            // nmrMesa
            // 
            this.nmrMesa.AutoSize = true;
            this.nmrMesa.Location = new System.Drawing.Point(158, 12);
            this.nmrMesa.Name = "nmrMesa";
            this.nmrMesa.Size = new System.Drawing.Size(33, 13);
            this.nmrMesa.TabIndex = 7;
            this.nmrMesa.Text = "Mesa";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(419, 138);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(107, 57);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 261);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.nmrMesa);
            this.Controls.Add(this.nmrDaMesa);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.itensPedidos);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipEnvio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox menu;
        private System.Windows.Forms.ListBox itensPedidos;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox nmrDaMesa;
        private System.Windows.Forms.Label nmrMesa;
        private System.Windows.Forms.Button btnEnviar;
    }
}

