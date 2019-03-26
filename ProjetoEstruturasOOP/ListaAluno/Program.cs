using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eae beleza? \nÉ o seguinte fala cantos usuarios serão cadastrados ai na moral!\n");
            int total;

            Int32.TryParse(Console.ReadLine(), out total);

            ListaDeUsuarios lista = new ListaDeUsuarios(total);

            Console.WriteLine(total + " Usuario? Otimo vamos começar");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("usuario: " + i+1);

                Console.WriteLine("id:");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("username:");
                string username = Console.ReadLine();
                Console.WriteLine("senha:");
                string senha = Console.ReadLine();
                Console.WriteLine("email:");
                string email = Console.ReadLine();
                Console.WriteLine("telefone:");
                string telefone = Console.ReadLine();
                Console.WriteLine("cpf:");
                string cpf = Console.ReadLine();

                Usuario novo = new Usuario(id,true,username,senha,email,telefone,cpf,"hoje");

                lista.adicionar(novo);

                Console.WriteLine("Cadastro realizado com sucesso");
            }

            Console.WriteLine("Isso ai todos os cadastro realizados.\nVou imprimir os dados");

            for (int i = 0; i < total; i++)
            {
                Usuario velho = new Usuario(lista.verUser(i));

                Console.WriteLine("Username: "+velho.username+" Senha:"+velho.senha);
            }



            Console.ReadLine();
        }
    }
}
