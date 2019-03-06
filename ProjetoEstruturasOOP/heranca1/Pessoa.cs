using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca1
{
    class Pessoa
    {
        private string nome;

        /*
        public string nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        */
        private string sexo;
        private int idade;

        public Pessoa()
        {
            MessageBox.Show("A classe funcionario esta sendo executada","Aviso");
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(String n)
        {
            nome = n;
        }

        public string getsexo()
        {
            return sexo;
        }
        public void setSexo(string s)
        {
            sexo = s;
        }

        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int i)
        {
            idade = i;
        }
    }
}
