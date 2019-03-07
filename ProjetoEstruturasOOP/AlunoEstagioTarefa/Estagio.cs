using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoEstagioTarefa
{
    class Estagio : Aluno
    {
        private string vaga;
        private string empresa;
        private int cargahoraria;

        public Estagio()
        {
            MessageBox.Show("Classe 'Estagio' sendo usada no momento, derivado do Aluno", "Aviso");
        }


        public string Vaga
        {
            set{ vaga = value; }
            get{ return vaga; }
        }
        public string Empresa
        {
            set { empresa = value; }
            get { return empresa; }
        }
        public int Cargahoraria
        {
            set { cargahoraria = value; }
            get { return cargahoraria; }
        }

    }
}
