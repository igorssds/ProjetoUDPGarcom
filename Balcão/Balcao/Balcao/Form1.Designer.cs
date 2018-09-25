namespace Balcao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ip = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.pedidoBalcao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(56, 25);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(100, 20);
            this.Ip.TabIndex = 7;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(27, 25);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(23, 13);
            this.aa.TabIndex = 6;
            this.aa.Text = "IP :";
            // 
            // pedidoBalcao
            // 
            this.pedidoBalcao.FormattingEnabled = true;
            this.pedidoBalcao.Location = new System.Drawing.Point(30, 90);
            this.pedidoBalcao.Name = "pedidoBalcao";
            this.pedidoBalcao.Size = new System.Drawing.Size(168, 186);
            this.pedidoBalcao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 315);
            this.Controls.Add(this.pedidoBalcao);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.aa);
            this.Name = "Form1";
            this.Text = "Balcão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.ListBox pedidoBalcao;
    }
}

