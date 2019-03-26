using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAluno
{
    class Usuario
    {
        public int id { get; private set; }
        public bool status { get; private set; }
        public string username { get; private set; }
        public string senha { get; private set; }
        public string email { get; private set; }
        public string telefone { get; private set; }
        public string cpf { get; private set; }
        public string data_inscricao { get; private set; }

        public Usuario()
        {
            id = 0;
            status = false;
            username = "";
            senha = "";
            email = "";
            telefone = "";
            cpf = "";
            data_inscricao = "";
        }
        public Usuario(int i, bool s, string u, string se, string e, string t,string c,string d)
        {
            id = i;
            status = s;
            username = u;
            senha = se;
            email = e;
            telefone = t;
            cpf = c;
            data_inscricao = d;
        }

        public Usuario(Usuario usuario)
        {
            id = usuario.id;
            status = usuario.status;
            username = usuario.username;
            senha = usuario.senha;
            email = usuario.email;
            telefone = usuario.telefone;
            cpf = usuario.cpf;
            data_inscricao = usuario.data_inscricao;
        }

        public void destivar()
        {
            status = false;
        }
        public void ativar()
        {
            status = true;
        }

    }
}
