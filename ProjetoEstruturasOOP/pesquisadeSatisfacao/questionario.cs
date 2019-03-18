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
    public partial class questionario : Form
    {
        string[] asks = new string[7];
        int n = 0;
        int total;
        public questionario(string[] a, int loja)
        {
            asks = a; 
            InitializeComponent();
            lblAsk.Text = asks[n];

            switch (loja)
            {
                case 1:
                    lblLoja.Text = "Americanas";
                    pnlCor.BackColor = Color.Red;
                    break;
                case 2:
                    lblLoja.Text = "Submarino";
                    pnlCor.BackColor = Color.DeepSkyBlue;
                    break;
                case 3:
                    lblLoja.Text = "Saraiva";
                    pnlCor.BackColor = Color.Gold;
                    break;
            }


        }

        private void rbtnOtimo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            string x = "Cliente satisfeito com a empresa";

            if (n <= 5)
            {
                if (rbtnRuim.Checked == true) { total = total + 0; }
                else if (rbtnRegular.Checked == true) { total = total + 40; }
                else if (rbtnBom.Checked == true) { total = total + 60; }
                else if (rbtnMuitoB.Checked == true) { total = total + 80; }
                else if (rbtnOtimo.Checked == true) { total = total + 100; }
                lblAsk.Text = asks[++n];
            }
            else
            {
                if (total < 280) { x = "Cliente totalmente insatisfeito com a empresa"; }
                else if (total > 280 && total < 420) { x = "Cliente satisfeito com a empresa"; }
                else if (total > 420) { x = "Cliente extremamente satisfeito"; }
                btnI.Text = "Finalizar";
                MessageBox.Show("A loja:" + lblLoja.Text + "\nteve o total de " + total + " Pontos\n" + "e o "+x, "Resposta");
            }
        }
    }
}
