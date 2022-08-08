namespace PROJETO_CADASTRO_DE_ALUNO
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblErroMat = new System.Windows.Forms.Label();
            this.lblErroNome = new System.Windows.Forms.Label();
            this.lblErroSexo = new System.Windows.Forms.Label();
            this.lblErroTurma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do Aluno";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(26, 97);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(29, 113);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 2;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbxSexo.Location = new System.Drawing.Point(29, 229);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(331, 21);
            this.cbxSexo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 169);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(739, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Completo:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(26, 213);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(415, 229);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(353, 20);
            this.txtTurma.TabIndex = 9;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(412, 213);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 8;
            this.lblTurma.Text = "Turma:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(29, 294);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(739, 20);
            this.txtObservacoes.TabIndex = 16;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(26, 278);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 10;
            this.lblObservacoes.Text = "Observações:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(315, 350);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(140, 40);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // lblErroMat
            // 
            this.lblErroMat.AutoSize = true;
            this.lblErroMat.Location = new System.Drawing.Point(135, 116);
            this.lblErroMat.Name = "lblErroMat";
            this.lblErroMat.Size = new System.Drawing.Size(0, 13);
            this.lblErroMat.TabIndex = 18;
            // 
            // lblErroNome
            // 
            this.lblErroNome.AutoSize = true;
            this.lblErroNome.Location = new System.Drawing.Point(26, 192);
            this.lblErroNome.Name = "lblErroNome";
            this.lblErroNome.Size = new System.Drawing.Size(0, 13);
            this.lblErroNome.TabIndex = 19;
            // 
            // lblErroSexo
            // 
            this.lblErroSexo.AutoSize = true;
            this.lblErroSexo.Location = new System.Drawing.Point(26, 253);
            this.lblErroSexo.Name = "lblErroSexo";
            this.lblErroSexo.Size = new System.Drawing.Size(0, 13);
            this.lblErroSexo.TabIndex = 20;
            // 
            // lblErroTurma
            // 
            this.lblErroTurma.AutoSize = true;
            this.lblErroTurma.Location = new System.Drawing.Point(412, 253);
            this.lblErroTurma.Name = "lblErroTurma";
            this.lblErroTurma.Size = new System.Drawing.Size(0, 13);
            this.lblErroTurma.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErroTurma);
            this.Controls.Add(this.lblErroSexo);
            this.Controls.Add(this.lblErroNome);
            this.Controls.Add(this.lblErroMat);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblErroMat;
        private System.Windows.Forms.Label lblErroNome;
        private System.Windows.Forms.Label lblErroSexo;
        private System.Windows.Forms.Label lblErroTurma;
    }
}

