using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_CADASTRO_DE_ALUNO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int Matricular(int matri)
        {
            if (matri >= 1000 && matri <= 9999)
            {
                lblErroMat.Text = "";
                lblErroTurma.Text = "";
            }
            else
            {
                lblErroMat.Text = "fora desse intervalo é inválido";
                lblErroTurma.Text = "fora desse intervalo é inválido";
            }
            return matri;
        }

        private string Nome(string name)
        {
            if (name == "")
            {
                lblErroNome.Text = "Insira o seu nome";
            }
            else
            {
                lblErroNome.Text = "Td tranquilo";
            }
            return name;
        }

        private string Sexo(string sex)
        {
            if (sex == "")
            {
                lblErroSexo.Text = "Insira o seu genero";
            }
            else
            {
                lblErroSexo.Text = "Genero salvo";
            }
            return sex;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            int matriculate = int.Parse(txtMatricula.Text);
            String nome = txtNome.Text;
            String sexo = cbxSexo.Text;

            txtMatricula.Text = Matricular(matriculate).ToString();
            txtNome.Text = Nome(nome).ToString();
            cbxSexo.Text = Sexo(sexo).ToString();
        }
    }
}
