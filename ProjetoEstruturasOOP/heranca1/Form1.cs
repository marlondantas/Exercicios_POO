using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empregado x = new Empregado();

        private void btnCalDesc_Click(object sender, EventArgs e)
        {
            x.setNome(txtnome.Text);
            x.setIdade(Convert.ToInt32( txtIdade.Text));
            x.setSexo(txtsexo.Text);

            x.setMatricula(txtMatricula.Text);
            x.setSalario(Convert.ToDouble(txtSalario.Text));

            txtresp.Text = (x.getSalario()+x.DescontoINSS())+"";
            txtDesconto.Text = x.DescontoINSS() + "";

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string dados = "Nome: "+x.getNome()+"\n Idade: "+x.getIdade()+"\n Sexo: "+x.getsexo()+"\n Matricula: "+x.getMatricula()+ "\n Salario: "+x.getSalario();

            MessageBox.Show("Dados:\n "+dados,"Dados da Pessoa:");
        }
    }
}
