namespace Sabor_e_Vida
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblErroCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErroVenda = new System.Windows.Forms.Label();
            this.lblErroCusto = new System.Windows.Forms.Label();
            this.lblErroQuantidade = new System.Windows.Forms.Label();
            this.lblErroEstoque = new System.Windows.Forms.Label();
            this.lblErroImposto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(36, 108);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(447, 22);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(41, 87);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoEllipsis = true;
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(41, 161);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoCusto.TabIndex = 4;
            this.lblPrecoCusto.Text = "Preço de Custo:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCusto.Location = new System.Drawing.Point(36, 182);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(223, 22);
            this.txtPrecoCusto.TabIndex = 3;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoEllipsis = true;
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(41, 228);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 6;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(36, 249);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(223, 22);
            this.txtPrecoVenda.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoEllipsis = true;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 294);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(136, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria: Alimento\\Bebida";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoEllipsis = true;
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(288, 294);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(121, 13);
            this.lblImposto.TabIndex = 14;
            this.lblImposto.Text = "Alíquota de imposto (%):";
            // 
            // txtImposto
            // 
            this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(283, 315);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(194, 22);
            this.txtImposto.TabIndex = 13;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoEllipsis = true;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(288, 228);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(283, 249);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(194, 22);
            this.txtQuantidade.TabIndex = 11;
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoEllipsis = true;
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(288, 161);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(87, 13);
            this.lblEstoqueMinimo.TabIndex = 10;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo:";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(283, 182);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(194, 22);
            this.txtEstoqueMinimo.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(335, 391);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(142, 47);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "",
            "Alimentos",
            "Bebidas"});
            this.cbxCategoria.Location = new System.Drawing.Point(36, 315);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoria.TabIndex = 16;
            // 
            // lblErroCategoria
            // 
            this.lblErroCategoria.AutoEllipsis = true;
            this.lblErroCategoria.AutoSize = true;
            this.lblErroCategoria.Location = new System.Drawing.Point(33, 342);
            this.lblErroCategoria.Name = "lblErroCategoria";
            this.lblErroCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblErroCategoria.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // lblErroVenda
            // 
            this.lblErroVenda.AutoEllipsis = true;
            this.lblErroVenda.AutoSize = true;
            this.lblErroVenda.Location = new System.Drawing.Point(33, 274);
            this.lblErroVenda.Name = "lblErroVenda";
            this.lblErroVenda.Size = new System.Drawing.Size(0, 13);
            this.lblErroVenda.TabIndex = 19;
            // 
            // lblErroCusto
            // 
            this.lblErroCusto.AutoEllipsis = true;
            this.lblErroCusto.AutoSize = true;
            this.lblErroCusto.Location = new System.Drawing.Point(33, 207);
            this.lblErroCusto.Name = "lblErroCusto";
            this.lblErroCusto.Size = new System.Drawing.Size(0, 13);
            this.lblErroCusto.TabIndex = 20;
            // 
            // lblErroQuantidade
            // 
            this.lblErroQuantidade.AutoEllipsis = true;
            this.lblErroQuantidade.AutoSize = true;
            this.lblErroQuantidade.Location = new System.Drawing.Point(280, 274);
            this.lblErroQuantidade.Name = "lblErroQuantidade";
            this.lblErroQuantidade.Size = new System.Drawing.Size(0, 13);
            this.lblErroQuantidade.TabIndex = 22;
            // 
            // lblErroEstoque
            // 
            this.lblErroEstoque.AutoEllipsis = true;
            this.lblErroEstoque.AutoSize = true;
            this.lblErroEstoque.Location = new System.Drawing.Point(280, 207);
            this.lblErroEstoque.Name = "lblErroEstoque";
            this.lblErroEstoque.Size = new System.Drawing.Size(0, 13);
            this.lblErroEstoque.TabIndex = 23;
            // 
            // lblErroImposto
            // 
            this.lblErroImposto.AutoEllipsis = true;
            this.lblErroImposto.AutoSize = true;
            this.lblErroImposto.Location = new System.Drawing.Point(280, 340);
            this.lblErroImposto.Name = "lblErroImposto";
            this.lblErroImposto.Size = new System.Drawing.Size(0, 13);
            this.lblErroImposto.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lblErroImposto);
            this.Controls.Add(this.lblErroEstoque);
            this.Controls.Add(this.lblErroQuantidade);
            this.Controls.Add(this.lblErroCusto);
            this.Controls.Add(this.lblErroVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErroCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblErroCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErroVenda;
        private System.Windows.Forms.Label lblErroCusto;
        private System.Windows.Forms.Label lblErroQuantidade;
        private System.Windows.Forms.Label lblErroEstoque;
        private System.Windows.Forms.Label lblErroImposto;
    }
}

