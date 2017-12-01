using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class CadastraCanditado
    {
        //Lista os candidatos.
        List<Candidato> p = new List<Candidato>();

        //Verifica se o codigo ja existe no array list.
        public bool Ehcodigo(int codigo)
        {
            bool resp = false;
            foreach (Candidato n in p)
            {
                if (n.getCodigo() == codigo)
                {
                    resp = false;
                }
                else resp = true;
            }

            return resp;
        }
        //Cadastra prefeito.
        public Candidato cadastrarPrefeito(int partido, int codigo, string nome, string nascimento, string email)
        {
            Candidato aux = new Prefeito(partido, codigo, nome, nascimento, email);
            this.p.Add(aux);
            return aux;

        }
        //Cadastra Vereador
        public Candidato cadastrarVereador(int partido, int codigo, string nome, string nascimento, string email)
        {
            Candidato aux = new Vereador(partido, codigo, nome, nascimento, email);
            this.p.Add(aux);
            return aux;

        }
        //Exclui candidato.
        public void excluir(int num)
        {
            foreach (Candidato n in p)
            {
                if (n.getCodigo() == num)
                {
                    p.Remove(n);
                }

            }
        }
        //Lista o candidato.
        public void listar()
        {
            foreach (Candidato n in p)
            {
                n.lista();
            }
        }

        //Pesquisa o candidato.
        public void pesquisa(int num)
        {
            foreach (Candidato n in p)
            {
                if (n.getCodigo() == num)
                {
                    n.ToString();
                }
            }
        }
        //Altera o candidato.
        public void alterar(int num)
        {
            foreach (Candidato n in p)
            {
                if (n.getCodigo() == num)
                {
                    Console.WriteLine("Digite um novo nome!");
                    string a = Console.ReadLine();
                    Console.WriteLine("Digite uma novo email!");
                    string b = Console.ReadLine();
                    n.setNome(a);
                    n.setMail(b);

                }
            }
        }
        //Define se e prefeito ou vereador na lista.
        public Candidato escolha(bool escolha,int part,int codigo ,string nome, string idade, string email)
        {
            Candidato resp;

            if(escolha == true)
            {
               resp =  cadastrarPrefeito(part, codigo, nome, idade, email);
            }else resp = cadastrarVereador(part, codigo, nome, idade, email);

            return resp;
        }

        //Atribui voto ao candidato.
        public void AtribuiVoto(int codigo)
        {
            foreach(Candidato can in p)
            {
                if(codigo == can.getCodigo())
                {
                    can.setVoto();
                }
            }
        }

        //Retornar a posiçao do array list.
        public List<Candidato> GetList()
        {
            return p;
        }
        //Atribuir o array list do parametro a variavel do objeto.
        public void SetList(List<Candidato> lista)
        {
            p = lista;
        }
    }
}
