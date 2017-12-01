using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eleicao
{
    // Candidato é uima classe abstrata e é usada em polimorfismo para os candidatos
    public abstract class  Candidato : Pessoa
    {
        private int idCandidato;
        private int partido;
        private string cargo;
        private int codigo;
        private string email;
        private int voto;
        protected bool ehPrefeito;

        //Construtor
        public Candidato(int partido, string cargo, int codigo, string nome, string nascimento, string email) : base(nome, nascimento)
        {
            this.idCandidato = idCandidato++;
            this.partido = partido;
            this.cargo = cargo;
            this.codigo = codigo;
            this.email = email;

        }

        //Getters e Setters
        public void setPartido(int partido)
        {
            this.partido = partido;
        }
        public int getPartido()
        {
            return partido;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }
        public string getCargo()
        {
            return this.cargo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }
        public void setMail(string email)
        {
            this.email = email;
        }
        public string getMail()
        {
            return this.email;
        }

        //Método para ser sobreescrito
        public abstract void lista();

        //Atribui um voto
        public void setVoto()
        {
            voto++;
        }

        //Retorna o toral de votos
        public int getVoto()
        {
            return voto;
        }
        public bool getEhPrefeito()
        {
            return ehPrefeito;
        }

    }

}