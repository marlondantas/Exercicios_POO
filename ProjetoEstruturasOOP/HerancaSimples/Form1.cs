using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaSimples
{
    public partial class Form1 : Form
    {
        professor x = new professor();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            x.setNome(textBox1.Text);
            x.setEndereco(textBox2.Text);
            x.setTitulacao(textBox3.Text);
            x.setDisciplina(textBox4.Text);


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xa = "Os dados guardados são: \nNome:"+x.getNome()+ "\nEndereco: "+x.getEndereco()+"\nTitulação:"+x.getTitulacao()+"\nDisciplina:"+x.getDisciplina();
            MessageBox.Show(xa , "Dados");
        }
    }
}
