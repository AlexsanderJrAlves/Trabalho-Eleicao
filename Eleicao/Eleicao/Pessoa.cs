using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eleicao
{
    public class Pessoa
    {
        //Classe Pessoa vai receber nome e nascimento, será a classe base para o cadastro de candidato.
        private string nome;
        private string nascimento;
        
        public Pessoa(string nome, string nascimento)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }
        public string getNascimento()
        {
            return this.nascimento;
        }

    }
}