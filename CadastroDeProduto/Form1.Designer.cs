namespace CadastroDeProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeProduto = new System.Windows.Forms.TextBox();
            this.Preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exibir = new System.Windows.Forms.RichTextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // NomeProduto
            // 
            this.NomeProduto.Location = new System.Drawing.Point(39, 48);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(100, 20);
            this.NomeProduto.TabIndex = 1;
            // 
            // Preco
            // 
            this.Preco.Location = new System.Drawing.Point(39, 124);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(100, 20);
            this.Preco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preco";
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(39, 208);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(100, 20);
            this.Quantidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // exibir
            // 
            this.exibir.Location = new System.Drawing.Point(363, 48);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(405, 260);
            this.exibir.TabIndex = 6;
            this.exibir.Text = "";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(39, 270);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(112, 23);
            this.Salvar.TabIndex = 7;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeProduto;
        private System.Windows.Forms.TextBox Preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox exibir;
        private System.Windows.Forms.Button Salvar;
    }
}

