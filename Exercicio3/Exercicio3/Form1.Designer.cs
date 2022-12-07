namespace Exercicio3
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
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.botao1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.BackColor = System.Drawing.Color.White;
            this.primeiraMensagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.ForeColor = System.Drawing.Color.Red;
            this.primeiraMensagem.Location = new System.Drawing.Point(358, 27);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(151, 28);
            this.primeiraMensagem.TabIndex = 0;
            this.primeiraMensagem.Text = "Mensagem1";
            this.primeiraMensagem.Click += new System.EventHandler(this.primeiraMensagem_Click);
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botao1.Location = new System.Drawing.Point(12, 12);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(340, 67);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "Mudar COR!";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 467);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.primeiraMensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label primeiraMensagem;
        private System.Windows.Forms.Button botao1;
    }
}

