using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Voto
    {
        //Classe para receber os votos.
        //Vai estar recebendo o nome prefeito e vereador

        private int votoPrefeito;
        private int votoVereador;
        
        public Voto(string prefeito, string vereador)
        {
            try
            {
                votoPrefeito = int.Parse(prefeito);
            }
            catch (Exception)
            {
                votoPrefeito = 0;
            }
            try
            {
                votoVereador = int.Parse(vereador);
            }
            catch (Exception)
            {
                votoVereador = 0;
            }
        }

        //Get que vai estar recebendo o voto de cada candidato.
        //Prefeito
        //Vereador

        public int getVotoPrefeito()
        {
            return votoPrefeito;
        }
        public int getVotoVereador()
        {
            return votoVereador; 
        }
    }
}
