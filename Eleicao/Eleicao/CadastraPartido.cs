using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class CadastraPartido
    {
        //ArrayList usada para manipulação dos dados
        List<Partido> p = new List<Partido>();

        //Verifica se uma sigla já foi usada
        public bool EhSigla(string s)
        {
            bool resp = true;
            foreach(Partido n in p)
            {
                if (n.getSigla() == s)
                {
                    resp = false;
                }
                else resp = true;
            }

            return resp;
        }

        //Cadastra um Partido
        public void cadastrar(string nome, int numero, string sigla)
        {
            Partido aux = new Partido(nome, numero,sigla);
            this.p.Add(aux);

        }

        //Exclui um Partido 
        public void excluir(int num)
        {
            foreach (Partido n in p)
            {
                if (n.getNumero() == num)
                {
                    n.limpa();
                    p.Remove(n);
                }
                
            }
        }

        //Exibe em formato de lista os Partidos existentes
        public void listar()
        {
            foreach(Partido n in p)
            {
                Console.WriteLine(n.list());
            }
        }

        //Pesquisa um Partido a partir do Numero
        public void pesquisa (int numPartido)
        {
            foreach(Partido n in p) {
                if (n.getNumero() == numPartido)
                {
                    n.ToString();
                }
            }
        }
        //Altera Nome e Sigla a partir do Numero do Partido
        public void alterar(int num)
        {
            foreach (Partido n in p)
            {
                if (n.getNumero() == num)
                {
                    Console.WriteLine("Digite um novo nome!");
                    string a = Console.ReadLine();
                    Console.WriteLine("Digite uma nova sigla!");
                    string b = Console.ReadLine();
                    n.setNomePartido(a);
                    n.setSigla(b);

                }
            }
        }

        //Verifica se um partido existe para cadastrar um Candidato
        public bool ehCadastravel(int codigo)
        {
            bool resp = false;
            foreach(Partido part in p)
            {
                if (part.getNumero() == codigo)
                {
                    resp = true;
                }
            }
            return resp;
        }

        //Verifica se existem Partidos instanciados
        public bool temPartido()
        {
            bool resp = false;
            if(p.Count > 0)
            {
                resp = true;
            }
            return resp;
        }

        //Atribui um Prefeito à um Partido
        public void IncluiPrefeito(Candidato prefeito, int codigo)
        {
            foreach(Partido part in p)
            {
                if(part.getNumero() == codigo)
                {
                    part.addPrefeito(prefeito);
                }
            }
        }

        //Atribui um Vereador à um Partido
        public void IncluiVereador(Candidato vereador, int codigo)
        {
            foreach (Partido part in p)
            {
                if (part.getNumero() == codigo)
                {
                    part.addVereador(vereador);
                }
            }
        }
    }
}
