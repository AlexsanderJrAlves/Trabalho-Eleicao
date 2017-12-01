using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe principal para executar o programa, chama a classe Menu e a
            //partir dela executa o programa de eleição.

            Menu programa = new Menu();
            programa.Inicio();
            Console.ReadKey();
        }
    }
}
