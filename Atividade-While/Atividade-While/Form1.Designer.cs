namespace Atividade_While
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
            this.btnMultiplos = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiplos
            // 
            this.btnMultiplos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplos.Location = new System.Drawing.Point(19, 12);
            this.btnMultiplos.Name = "btnMultiplos";
            this.btnMultiplos.Size = new System.Drawing.Size(216, 45);
            this.btnMultiplos.TabIndex = 2;
            this.btnMultiplos.Text = "Multiplos de 3 (de 1 a 99)";
            this.btnMultiplos.UseVisualStyleBackColor = true;
            this.btnMultiplos.Click += new System.EventHandler(this.btnMultiplos_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.Location = new System.Drawing.Point(19, 109);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(216, 45);
            this.btnNumeros.TabIndex = 3;
            this.btnNumeros.Text = "Números de 100 a 1000";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(33, 404);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 4;
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.Location = new System.Drawing.Point(19, 210);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(216, 45);
            this.btnAluno.TabIndex = 5;
            this.btnAluno.Text = "Nº de alunos de 10 a 50";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 267);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnMultiplos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMultiplos;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAluno;
    }
}

