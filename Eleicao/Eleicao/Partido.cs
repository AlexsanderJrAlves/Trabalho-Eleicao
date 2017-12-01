using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Partido
    {
        //Classe para cirar Partido, vai receber o nome e a Sigla.
        //Dentro de cada partido vai existir uma lista de candidato Prefeito e Vereadores.
        //Vice-Prefeito vai herdar de prefeito automáticamente.


        private string nomePartido;
        private string sigla;
        private readonly int num;
        public List<Candidato> vereadores = new List<Candidato>();
        private Candidato prefeito;


        //Partido vai receber nome, numero e sigla do partido
        public Partido(string nome, int numero,string sigla)
        {
            this.sigla = sigla;
            nomePartido = nome;
            num = numero;
        }
        public int getNumero()
        {
            return num;
        }
        public string getSigla()
        {
            return sigla;
        }
        public string getPartido()
        {
            return nomePartido;
        }
        public void setNomePartido(string n)
        {
            nomePartido = n;
        }
        public void setSigla(string n)
        {
            sigla = n;
        }

        //Função para limpar a lista de vereadores
        //Define prefeito como null ao chamar.

        public void limpa(){

            prefeito = null;
            foreach(Vereador v in vereadores)
            {
                vereadores.Remove(v);
            }

        }
        //Imprimindo a lista de partidos.
        public string list()
        {
            string a = "Número: " + getNumero() + "\n Sigla: " + getSigla();
            return a;
        }
        public override string ToString()
        {
            string a = "Nome do Partido: " + getPartido() + "\n" +list();
            return a;
        }

        //Função para adicionar prefeito em candidato
        public void addPrefeito(Candidato prefeito)
        {
            this.prefeito = prefeito; 
        }
        //Função para adicionar vereador em candidato
        public void addVereador(Candidato vereador)
        {
            vereadores.Add(vereador);
        }
    }
}
