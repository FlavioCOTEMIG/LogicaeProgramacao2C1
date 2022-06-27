using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabor_e_Vida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Categoria = cbxCategoria.Text;
            float Custo = float.Parse(txtPrecoCusto.Text);
            float Venda = float.Parse(txtPrecoVenda.Text);
            int Estoque = int.Parse(txtEstoqueMinimo.Text);
            int Quantidade = int.Parse(txtQuantidade.Text);
            int Imposto = int.Parse(txtImposto.Text);
            float Valor_Imposto;

            switch (Categoria)
            {
                case "Alimentos":
                    lblErroCategoria.Text = "Categoria Salva";
                    break;

                case "Bebidas":
                    lblErroCategoria.Text = "Categoria Salva";
                    break;

                default:
                    lblErroCategoria.Text = "O campo da categoria invalido";
                    break;
            }


            if (Custo > 0)
            {
                lblErroCusto.Text = "";
            }
            else
            {
                lblErroCusto.Text = "Preço do custo invalido";
            }


            if (Venda > Custo)
            {
                lblErroCusto.Text = "";
            }
            else
            {
                lblErroCusto.Text = "Preço da venda invalida";
            }


            if (Quantidade < Estoque)
            {
                lblErroQuantidade.Text = "Quantidade invalida";
                lblErroEstoque.Text = "Estoque invalido";
            }
            else
            {
                lblErroQuantidade.Text = "";
                lblErroEstoque.Text = "";
            }


            if (Imposto < 1)
            {
                lblErroImposto.Text = "Valor Invalido";
            }
            else
            {
                Valor_Imposto = Venda / (Imposto * 100);
                lblErroImposto.Text = "Valor do imposto: R$" + Valor_Imposto.ToString("N2");
            }
        }
    }
}
