using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Prefeito : Candidato
    {
        private VicePrefeito vice;
        //Classe que recebe o cadastro do cargo de Prefeito a partir da classe principal de Candidato.

        //Prefeito vai receber
        // Partido
        // Codigo Partido
        // Nome do Candidato
        // Nascimento
        // E-mail de cadastro

        public Prefeito( int partido, int codigo, string nome, string nasc, string email): base(partido, "Prefeito", codigo, nome, nasc, email)
        {
            Console.WriteLine("Digite o Nome:\n Data de nascimento:\n E-mail do Vice-Prefeito:");
            string nomeVice, nascVice, emailVice;
            nomeVice = Console.ReadLine();
            nascVice = Console.ReadLine();
            emailVice = Console.ReadLine();
            vice = new VicePrefeito(partido, codigo, nomeVice, nascVice, emailVice);
            ehPrefeito = true;

        }

        //Transforma todas as varíaveis para string;
        public override string ToString()
        {
            string resp = "Nome: " + getNome() + "Data de Nascimento: " + getNascimento() + "E-mail: " + getMail() + "Cargo: " + getCargo() + "Partido: " +
                getPartido() + "Código :" + getCodigo() + "\n\n\n Dados do Vice-Prefeito:\n" + vice.ToString();
            return resp;
        }

        //Imprimir a lista de candidatos na clases e lista de vice.
        public override void lista()
        {
            Console.WriteLine("\nPrefeito:");
            Console.WriteLine("Nome:" + getNome());
            Console.WriteLine("Codigo :" + getCodigo());
            Console.WriteLine("\nVice Prefeito:");
            vice.lista();
        }
    }
}