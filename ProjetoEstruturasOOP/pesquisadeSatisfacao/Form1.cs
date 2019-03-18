using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesquisadeSatisfacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DialogResult result;
            result = MessageBox.Show("Você deseja Participar da Pesquisa?", "Aviso", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.No)
            {

                // Closes the parent form.
                MessageBox.Show("Obrigado!", "Aviso");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pesquisa a = new Pesquisa();
            a.responde_questionario(1);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pesquisa a = new Pesquisa();
            a.responde_questionario(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisa a = new Pesquisa();
            a.responde_questionario(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
