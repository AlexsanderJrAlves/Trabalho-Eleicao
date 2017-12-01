using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Local
    {
        //Classe Local vai receber zona e secao, ambos com valores 0 e 1.
        
        private static int zonaCont = 0;
        private static int secaoCont = 1;
        private readonly int zona;
        private readonly int secao;

        //Não permite em várias urnas tenha a mesma sessão e zona
        public Local()
        {
            if(zonaCont == 100)
            {
                zonaCont = 0;
                secao++;
                zona = zonaCont;
                secao = secaoCont;
            }
            else
            {
                zona = zonaCont;
                secao = secaoCont;
            }
        }

        //retorna Zona
        public int getZona()
        {
            return zona;
        }
        //Retorna sessão
        public int getSecao()
        {
            return secao;
        }

    }
}
