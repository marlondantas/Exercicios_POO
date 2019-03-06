using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaSimples
{


    class professor : funcionario
    {
        string titulacao = "";
        string disciplina = "";

        public professor() : base()
        {
            //todo codigo fonte do funcionario e atribuido para o esse campo do construtor case seja colocado o ":base()"
            MessageBox.Show("A classe  professor, derivada da classe funcionario.","Aviso");
        }

        public string getTitulacao()
        {
            return titulacao;
        }
        public string getDisciplina()
        {
            return disciplina;   
        }

        public void setTitulacao(string a)
        {
            titulacao = a;
        }

        public void setDisciplina(string b)
        {
            disciplina = b;
        }

    }

}
