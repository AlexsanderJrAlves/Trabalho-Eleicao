using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class CadastroUrna
    {
        List<Urna> p = new List<Urna>();

       
        public void cadastrar(string nome)
        {
            Urna aux = new Urna(nome);
            this.p.Add(aux);

        }
        //Exclui uma urna pela secao.
        public void excluir(int secao, int zona)
        {
            foreach (Urna n in p)
            {
                if (n.getSecao() == secao && n.getZona() == zona)
                {
                    p.Remove(n);
                }

            }
        }
     
        //Pesquisa o nome da urna.
        public void pesquisa(int secao, int zona)
        {
            foreach (Urna n in p)
            {
                if (n.getSecao() == secao && n.getZona() == zona)
                {
                    n.getNome();
                }
            }
        }
        //Altera o nome da urna
        public void alterar(int secao, int zona)
        {
            foreach (Urna n in p)
            {
                if (n.getSecao() == secao && n.getZona() == zona)
                {
                    Console.WriteLine("Digite um novo nome!");
                    string a = Console.ReadLine();
                    n.setNome(a);
                }
            }
        }
        //Retorna o local da urna.
        public Local retornaLocal(int secao, int zona)
        {
            Local resp = null;

            foreach (Urna n in p)
            {
                if (n.getSecao() == secao && n.getZona() == zona)
                {
                    resp = n.getLocal();
                }
            }

            return resp;
        }
        //Retorna uma urna pela seçao e zona.
        public Urna GetUrna(int secao,int zona)
        {
            Urna resp = null;

            foreach (Urna n in p)
            {
                if (n.getSecao() == secao && n.getZona() == zona)
                {
                    resp = n;
                }
            }
            return resp;
        }
        //Retornar as listas das urnas.
        public List<Urna> GetList()
        {
            return p;
        }
    }
}
