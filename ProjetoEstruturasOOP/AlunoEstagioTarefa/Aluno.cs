using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoEstagioTarefa
{
    class Aluno
    {
        private string nome;
        private DateTime datanasc;
        private string matricula;

        public Aluno()
        {
            MessageBox.Show("Classe 'Aluno' sendo usada no momento", "Aviso");
        }


        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public DateTime Datanasc
        {
            set { datanasc = value; }
            get { return datanasc; }
        }

        public string Matricula
        {
            set { matricula = value; }
            get { return matricula; }
        }
    }
}
