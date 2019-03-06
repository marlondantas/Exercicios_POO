using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca1
{
    class Empregado : Pessoa

    {
        /* 
         * public double salario { get; set; }
         private string matricula { get; set; }
         */

        public double salario;
        private string matricula;

        public void setSalario(double s)
        {
            salario = s;
        }
        public double getSalario()
        {
            return salario;
        }

        public string getMatricula()
        {
            return matricula;
        }
        public void setMatricula(string m)
        {
            matricula = m;
        }

        public Empregado() : base()
        {
            MessageBox.Show("A classe  Empregado, derivada da classe Pessoa.", "Aviso");
        }

        public double DescontoINSS()
        {
            MessageBox.Show("A % de desconto é:" + Convert.ToString(_calDesconto(salario)), "Aviso");
            return salario * (_calDesconto(salario)/100);
        }

        float _calDesconto(double salario)
        {
            if (salario < 3000.00f)
            {
                return 3f;
            }
            else if ((salario > 3001.00) && (salario < 7000.00))
            {
                return 5f;
            }
            else if( salario > 7000.00 )
            {
                return 11f;
            }
            return 00.00f;
        }
    }
}
