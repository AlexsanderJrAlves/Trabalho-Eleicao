using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    //Classe eleitor pegando os dados da classe pessoa.
    public class Eleitor : Pessoa
    {
        //Variaveis da classe eleitor 
        //Readonly variavel que recebe um valor que nao pode ser mudado.
        private readonly int titulo;
        private int zona;
        private int secao;

        //Metodo construtor com parametros
        public Eleitor(int titulo, int zona, int secao,string nome, string nascimento) : base(nome, nascimento)
        {
            this.titulo = titulo;
            this.zona = zona;
            this.secao = secao;
        }

        public int getTitulo()
        {
            return titulo;
        }
        public void setZona(int z)
        {
            zona = z;
        }
        public int getZona()
        {
            return zona;
        }
        public void setSecao(int s)
        {
            secao = s;
        }
        public int getSecao()
        {
            return secao;
        }
        //Sobreecreve o metodo da classe object.
        public override string ToString()
        {
            string resp = "Nome: " + getNome() + "Data de Nascimento: " + getNascimento() + "Titulo : " + getTitulo() + "Seção: " +
                getSecao() + "Zona :" + getZona();
            return resp;
        }
    }
}
