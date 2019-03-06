using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HerancaSimples
{


    class funcionario
    {
        private string nome = "";
        private string endereco = "";

        public funcionario()
        {
            MessageBox.Show("A classe funcionario esta sendo executada","Aviso");
        }

        public void setNome(string a)
        {
            nome = a;
        }

        public void setEndereco(string b)
        {
            endereco = b;
        }

        public string getNome()
        {
            return nome;
        }
        public string getEndereco()
        {
            return endereco;                
        }
    }



}
