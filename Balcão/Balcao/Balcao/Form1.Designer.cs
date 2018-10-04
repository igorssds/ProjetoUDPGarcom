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
            this.pedidoBalcao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pedidoBalcao
            // 
            this.pedidoBalcao.FormattingEnabled = true;
            this.pedidoBalcao.Location = new System.Drawing.Point(22, 52);
            this.pedidoBalcao.Name = "pedidoBalcao";
            this.pedidoBalcao.Size = new System.Drawing.Size(228, 225);
            this.pedidoBalcao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 315);
            this.Controls.Add(this.pedidoBalcao);
            this.Name = "Form1";
            this.Text = "Balcão";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox pedidoBalcao;
    }
}

