using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesquisadeSatisfacao
{
    class Pesquisa
    {
        public int codigo_empresa { get; set; }
        public int pontuacao { get; set; }

        public Pesquisa()
        {
            pontuacao = 0;
        }

        public void responde_questionario(int l)
        {
            String[] pergutas = new string[7];
            pergutas[0] = "Tempo de atendimento";
            pergutas[1] = "Educação do vendedor";
            pergutas[2] = "Clareza das informações prestadas";
            pergutas[3] = "Instruções claras e corretas\nsobre a entrega";
            pergutas[4] = "Instruções claras e corretas\nsobre a montagem";
            pergutas[5] = "Atendimento do entregador";
            pergutas[6] = "Conformidade da entrega";

            questionario quest = new questionario(pergutas,l);
            quest.ShowDialog();
        }

        public int getPontos()
        {
            return pontuacao;
        }

    }
}
