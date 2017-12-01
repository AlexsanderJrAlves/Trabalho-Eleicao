using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class VicePrefeito : Candidato
    {
        //Classe que recebe o cadastro do cargo de vice prefeito a partir da classe principal de Candidato.
        public int code;

        //Vice Prefeito vai receber
        // Partido
        // Codigo Partido
        // Nome do Candidato
        // Nascimento
        // E-mail de cadastro

        public VicePrefeito( int partido, int codigo, string nome, string nasc, string email) : base(partido, "Vice-Prefeito", codigo, nome, nasc, email)
        {
            this.code = codigo;
        }

        //Transforma todas as varíaveis para string;
        public override string ToString()
        {
            string resp = "Nome: " + getNome() + "Data de Nascimento: " + getNascimento() + "E-mail: " + getMail() + "Cargo: " + getCargo() + "Partido: " +
                getPartido() + "Código :" + getCodigo();
            return resp;
        }
        
        public override void lista()
        {
            Console.WriteLine("Nome:" + getNome());
            Console.WriteLine("Codigo :" + getCodigo());
        }
    }
}