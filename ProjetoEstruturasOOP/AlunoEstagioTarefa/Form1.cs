using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoEstagioTarefa
{
    public partial class Form1 : Form
    {

        Curso curso = new Curso();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CAlcular a diferença de anos.
            int anos = dtpNascimento.Value.Year - DateTime.Today.Year;
            MessageBox.Show("Total de diferença" + anos, "Diferença");
        }

        private void btnCadastarAlno_Click(object sender, EventArgs e)
        {

        }
    }
}
