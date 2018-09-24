namespace Cozinha
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
            this.enviarBalcao = new System.Windows.Forms.Button();
            this.pedidoRecebido = new System.Windows.Forms.ListBox();
            this.pedidoPronto = new System.Windows.Forms.ListBox();
            this.btnPronto = new System.Windows.Forms.Button();
            this.aa = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enviarBalcao
            // 
            this.enviarBalcao.Location = new System.Drawing.Point(481, 107);
            this.enviarBalcao.Name = "enviarBalcao";
            this.enviarBalcao.Size = new System.Drawing.Size(75, 83);
            this.enviarBalcao.TabIndex = 0;
            this.enviarBalcao.Text = "Enviar";
            this.enviarBalcao.UseVisualStyleBackColor = true;
            this.enviarBalcao.Click += new System.EventHandler(this.enviarBalcao_Click);
            // 
            // pedidoRecebido
            // 
            this.pedidoRecebido.FormattingEnabled = true;
            this.pedidoRecebido.Location = new System.Drawing.Point(18, 53);
            this.pedidoRecebido.Name = "pedidoRecebido";
            this.pedidoRecebido.Size = new System.Drawing.Size(168, 186);
            this.pedidoRecebido.TabIndex = 1;
            // 
            // pedidoPronto
            // 
            this.pedidoPronto.FormattingEnabled = true;
            this.pedidoPronto.Location = new System.Drawing.Point(295, 53);
            this.pedidoPronto.Name = "pedidoPronto";
            this.pedidoPronto.Size = new System.Drawing.Size(158, 186);
            this.pedidoPronto.TabIndex = 2;
            this.pedidoPronto.SelectedIndexChanged += new System.EventHandler(this.pedidoPronto_SelectedIndexChanged);
            // 
            // btnPronto
            // 
            this.btnPronto.Location = new System.Drawing.Point(203, 137);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(75, 23);
            this.btnPronto.TabIndex = 3;
            this.btnPronto.Text = ">>";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(28, 9);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(23, 13);
            this.aa.TabIndex = 4;
            this.aa.Text = "IP :";
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(57, 9);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(100, 20);
            this.Ip.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.pedidoPronto);
            this.Controls.Add(this.pedidoRecebido);
            this.Controls.Add(this.enviarBalcao);
            this.Name = "Form1";
            this.Text = "Cozinha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviarBalcao;
        private System.Windows.Forms.ListBox pedidoRecebido;
        private System.Windows.Forms.ListBox pedidoPronto;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.TextBox Ip;
    }
}

