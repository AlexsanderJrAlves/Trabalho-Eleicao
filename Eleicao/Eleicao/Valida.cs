using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public static class Valida
    { 
        //Classe de validação, ela recebe os códigos dos vereadores com 4 digitos para saeber se é vereador ou não.
        private static int ValidaV(int codigo)
        {
            int codigoVer = codigo;
            try
            {
                if (codigoVer > 9999 || codigoVer < 0000)
                {
                    Console.WriteLine("Deu Erro, tente novamente!!!");

                }
                if (codigoVer.ToString().Length != 4)
                {
                    Console.WriteLine("Deu Erro, tente novamente!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Deu Erro, tente novamente!!!");
            }
            return codigoVer;
        }
        public static int getCodVer(int codigo)
        {
            return ValidaV(codigo);
        }
        //função para validar prefeito com dois digitos
        private static int ValidaP(int codigo)
        {           
            int codigoPre = codigo;
            try
            {
                if (codigoPre >100 || codigoPre <00)
                {
                    Console.WriteLine("Deu Erro, tente novamente!!!");

                }if(codigoPre.ToString().Length != 2)
                {
                    Console.WriteLine("Deu Erro, tente novamente!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Deu Erro, tente novamente!!!");
            }
            return codigoPre;
        }
        public static int getCodPre(int codigo)
        {
            return ValidaP(codigo);
        }
    }
}