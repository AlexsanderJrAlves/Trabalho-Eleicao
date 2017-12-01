using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class CadastroEleitor
    {
        //Cria array list eleitor.
        List<Eleitor> p = new List<Eleitor>();
        //Verifica se o codigo ja existe no array list.
        public bool EhTitulo(int s)
        {
            bool resp = false;
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == s)
                {
                    resp = false;
                }
                else resp = true;
            }

            return resp;
        }
        //Cadastra um novo eleitor.
        public void cadastrar(int titulo, Local local, string nome, string nascimento)
        {
            Eleitor aux = new Eleitor( titulo, local.getZona(), local.getSecao(), nome, nascimento);
            this.p.Add(aux);

        }
        //Exclui o eleitor pelo titulo.
        public void excluir(int titulo)
        {
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == titulo)
                {
                    p.Remove(n);
                }

            }
        }
        //Lista os eleitores, nome e titulo.
        public void listar()
        {
            foreach (Eleitor n in p)
            {
                Console.WriteLine("Nome:" + n.getNome());
                Console.WriteLine("Codigo :" + n.getTitulo());
            }
        }
        //Pesquisa eleitor.
        public void pesquisa(int titulo)
        {
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == titulo)
                {
                    n.ToString();
                }
            }
        }
        //Altera os dados do eleitor.
        public void alterar(int titulo)
        {
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == titulo)
                {
                    Console.WriteLine("Digite um novo nome!");
                    string a = Console.ReadLine();
                    Console.WriteLine("Digite uma novo nascimento!");
                    string b = Console.ReadLine();
                    n.setNome(a);
                    n.setNascimento(b);

                }
            }
        }
        //Retorna a zona.
        public int getZona(int titulo)
        {
            int zona = 0;
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == titulo)
                {
                    zona = n.getZona();
                }
            }
            return zona;
        }
        //Retorna uma seçao.
        public int getSecao(int titulo)
        {
            int secao = 0;
            foreach (Eleitor n in p)
            {
                if (n.getTitulo() == titulo)
                {
                    secao = n.getSecao();
                }
            }
            return secao;
        }
    }
}
