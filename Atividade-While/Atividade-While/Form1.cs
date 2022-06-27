using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplos_Click(object sender, EventArgs e)
        {
            int counter = 3;

            while (counter <= 99)
            {
                MessageBox.Show("Multiplo de 3: " + counter);
                counter = counter + 3;
            }
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int counter = 100;

            while (counter <= 1000)
            {
                MessageBox.Show("Número de 100 a 1000: " + counter);
                counter = counter + 1;
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            int counter = 10;
            int Student = 1;

            while (counter <= 50)
            {
                MessageBox.Show("Aluno " + Student + ": " + counter);
                counter = counter + 10;
                Student = Student + 1;
            }
        }
    }
}
