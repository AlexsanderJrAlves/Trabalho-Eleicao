using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Urna
    {
        //Variáveis e um ArrayList para armazenar dados
        private string nome;
        private Local local;
        List<Voto> votos = new List<Voto>();

        //Coonstrutor
        public Urna(string nome)
        {
            this.nome = nome;
            local = new Local();
        }

        //Getters e Setters
        public Local getLocal()
        {
            return local;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getZona()
        {
            return local.getZona();
        }
        public int getSecao()
        {
            return local.getSecao();
        }

        //Adiciona um voto a Urna
        public void addVoto(string numPrefeito, string numVereador)
        {
            Voto v = new Voto(numPrefeito, numVereador);
            votos.Add(v);
        }

        //Retorna a posição do ArrayList com os votos
        public List<Voto> GetList()
        {
            return votos;
        }
    }
}
