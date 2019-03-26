using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAluno
{
    class ListaDeUsuarios
    {
        public Usuario[] listadeusuario { get; private set; }
        public int tamanhodalista { get; private set; }
        public int fimdalista { get; private set; }

        public ListaDeUsuarios()
        {
            listadeusuario = null;
            tamanhodalista = 0;
            fimdalista = 0;
        }

        public ListaDeUsuarios(int tamanho)
        {
            listadeusuario = new Usuario[tamanho];
            tamanhodalista = tamanho;
            fimdalista = -1;
        }

        public void adicionar(Usuario usuario)
        {
            fimdalista++;
            if (!isfull())
            {
                listadeusuario[fimdalista] = usuario;
            }
            else
            {

            }
        }

        bool isfull()
        {
            if(fimdalista == tamanhodalista)
            {
                return true;
            }

            return false;
        }

        public void Ativar(int pos)
        {
            listadeusuario[pos].ativar();
        }
        public void Destavivar(int pos)
        {
            listadeusuario[pos].destivar();
        }

        public Usuario verUser(int pos)
        {
            return listadeusuario[pos];
        }
    }
}
