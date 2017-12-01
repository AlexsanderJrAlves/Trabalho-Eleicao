using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    public class Menu
    {
        //Variáveis globais para receber os valores atribuídos pelos menus

        CadastraCanditado candidatos = new CadastraCanditado();
        CadastraPartido partidos = new CadastraPartido();
        CadastroEleitor eleitores = new CadastroEleitor();
        CadastroUrna urnas = new CadastroUrna();

        //Telas de Inicio
        public void Inicio()
        {
            opcaoInicio();
        }
        public void opcaoInicio()
        {
            Console.WriteLine("Sistema Eleitoral Brasileiro do Nordeste");
            Console.WriteLine("Informe o que você deseja fazer:");
            Console.WriteLine("Modulo Administrador [1] \nRealizar Votação [2]");
            int opcao = int.Parse(Console.ReadLine());
            do
            {
                switch (opcao)
                {
                    case 1:
                        login();
                        break;
                    case 2:
                        eleicoes();
                        break;
                }

            } while (opcao != 1 || opcao != 2);
        }

        //Tela de Login, A senha é 1234
        public void login()
        {
            int senha = 1234;
            Console.WriteLine("Digite a senha!");
            try
            {
                int senha_aux = int.Parse(Console.ReadLine());
                if(senha==senha_aux){
                    administrador();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha Errada!\n Tente novamente!");
                    login();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error! \n Tente novamente!");
                login();
            }
        }

        //Telas de Administração
        public void administrador()
        {
            Console.WriteLine("Modulo Administrador!");
            opcaoAdmin();

        }
        public void opcaoAdmin()
        {
            Console.WriteLine("Modulo Candidatos - 1 ");
            Console.WriteLine("Modulo Partidos - 2 ");
            Console.WriteLine("Modulo Eleitores - 3 ");
            Console.WriteLine("Modulo Urnas -  4 ");
            Console.WriteLine("Apurar Votação - 5 ");
            Console.WriteLine("Voltar - 6 ");
            int aux = int.Parse(Console.ReadLine());
            do
            {
                switch (aux)
                {
                    case 1:
                        opcaoCandidato();
                        break;
                    case 2:
                        opcaoPartido();
                        break;
                    case 3:
                        opcaoEleitor();
                        break;
                    case 4:
                        opcaoUrna();
                        break;
                    case 5:
                        opcaoApurar();
                        break;

                    case 6:
                        Console.Clear();
                        opcaoInicio();
                        break;


                }
            } while (aux < 1 || aux > 7);
        }        
        public void opcaoCandidato()
        {
            Console.WriteLine("Cadastro - 1 ");
            Console.WriteLine("Exclusão - 2 ");
            Console.WriteLine("Modo lista - 3 ");
            Console.WriteLine("Pesquisa -  4 ");
            Console.WriteLine("Alteração - 5 ");
            Console.WriteLine("Sair - 6 ");
            int aux = int.Parse(Console.ReadLine());
            do
            {
                switch (aux)
                {
                    case 1:
                        if (partidos.temPartido())
                        {
                            string nome, idade, email;
                            int part,codigo;
                            Console.WriteLine("Para cadastrar digite: Nome:\nData de Nascimento:\nCodigo:\nE-mail:\nPartido:");
                            nome = Console.ReadLine();
                            idade = Console.ReadLine();
                            codigo = int.Parse(Console.ReadLine());
                            if (candidatos.Ehcodigo(codigo) == false)
                            {
                                Console.WriteLine("Codigo já em uso!");
                                opcaoCandidato();
                            }
                            email = Console.ReadLine();
                            part = int.Parse(Console.ReadLine());
                            if (partidos.ehCadastravel(part))
                            {
                                bool ehPrefeito = EhPrefeito();
                                Candidato candi;
                                if (ehPrefeito == true)
                                {
                                    candi = candidatos.escolha(ehPrefeito, part, Valida.getCodPre(codigo), nome, idade, email);
                                }
                                else candi = candidatos.escolha(ehPrefeito, part, Valida.getCodVer(codigo), nome, idade, email);
                                if (ehPrefeito == true)
                                {
                                    partidos.IncluiPrefeito(candi, part);
                                }
                                else partidos.IncluiVereador(candi, part);
                                Console.Clear();
                                opcaoCandidato();

                            }
                            else
                            {
                                Console.WriteLine("Não existe esse Partido!");
                                opcaoCandidato();
                            }
                            
                        }else
                        {
                            Console.WriteLine("Não existe Partidos, Cadastre pelo menos 1!");
                            opcaoAdmin();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o codigo para excluir!");
                        int a = int.Parse(Console.ReadLine());
                        candidatos.excluir(a);
                        Console.ReadKey();
                        Console.Clear();
                        opcaoCandidato();
                        break;
                    case 3:
                        candidatos.listar();
                        Console.ReadKey();
                        opcaoCandidato();
                        break;
                    case 4:
                        Console.WriteLine("Digite o codigo para pesquisar!");
                        int b = int.Parse(Console.ReadLine());
                        candidatos.pesquisa(b);
                        Console.ReadKey();
                        opcaoCandidato();
                        break;
                    case 5:
                        Console.WriteLine("Digite o codigo para alterar!");
                        int c = int.Parse(Console.ReadLine());
                        candidatos.pesquisa(c);
                        Console.ReadKey();
                        opcaoCandidato();
                        break;
                    case 6:
                        Console.Clear();
                        opcaoInicio();
                        break;
                    
                }
            } while (aux < 1 || aux > 6);
        }       
        public void opcaoPartido()
        {

            Console.WriteLine("Cadastro - 1 ");
            Console.WriteLine("Exclusão - 2 ");
            Console.WriteLine("Modo lista - 3 ");
            Console.WriteLine("Pesquisa -  4 ");
            Console.WriteLine("Alteração - 5 ");
            Console.WriteLine("Sair - 6 ");
            int aux = int.Parse(Console.ReadLine());
            do
            {
                switch (aux)
                {
                    case 1:
                        string nome, sigla;
                        int codigo;
                        Console.WriteLine("Para cadastrar digite: Nome do partido:\nSigla do Partido:\nCodigo do Partido:\n");
                        nome = Console.ReadLine();
                        sigla = Console.ReadLine();
                        if (partidos.EhSigla(sigla))
                        {
                            codigo = int.Parse(Console.ReadLine());
                            partidos.cadastrar(nome, codigo, sigla);
                            opcaoPartido();
                        }
                        else
                        {
                            Console.WriteLine("Sigla em uso!");
                            opcaoPartido();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o codigo para excluir!");
                        int a = int.Parse(Console.ReadLine());
                        partidos.excluir(a);
                        opcaoPartido();
                        break;
                    case 3:
                        partidos.listar();
                        break;
                    case 4:
                        Console.WriteLine("Digite o codigo para pesquisar!");
                        int b = int.Parse(Console.ReadLine());
                        partidos.pesquisa(b);
                        opcaoPartido();
                        break;
                    case 5:
                        Console.WriteLine("Digite o codigo para alterar!");
                        int c = int.Parse(Console.ReadLine());
                        partidos.pesquisa(c);
                        opcaoPartido();
                        break;
                    case 6:
                        Console.Clear();
                        opcaoInicio();
                        break;

                    default:
                        break;

                }
            } while (aux < 1 || aux > 6);

        }
        public void opcaoUrna()
        {
            Console.WriteLine("Cadastro - 1 ");
            Console.WriteLine("Exclusão - 2 ");
            Console.WriteLine("Pesquisa -  3 ");
            Console.WriteLine("Alteração - 4 ");
            Console.WriteLine("Sair - 5 ");
            int aux = int.Parse(Console.ReadLine());
            do
            {
                switch (aux)
                {
                    //titulo, int zona, int secao,string nome, string nascimento
                    case 1:
                        string nome;
                        Console.WriteLine("Para cadastrar digite:\nNome da Urna:");
                        nome = Console.ReadLine();
                        urnas.cadastrar(nome);
                        opcaoUrna();
                        break;
                    case 2:
                        Console.WriteLine("Digite a seção e a zona para excluir!");
                        int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
                        urnas.excluir(a, b);
                        opcaoUrna();
                        break;
                    case 3:
                        Console.WriteLine("Digite a seção e a zona para pesquisar!");
                        int c = int.Parse(Console.ReadLine()), d = int.Parse(Console.ReadLine());
                        urnas.pesquisa(c, d);
                        opcaoUrna();
                        break;
                    case 4:
                        Console.WriteLine("Digite a seção e a zona para alterar!");
                        int e = int.Parse(Console.ReadLine()), f = int.Parse(Console.ReadLine());
                        urnas.alterar(e, f);
                        opcaoUrna();
                        break;
                    case 5:
                        Console.Clear();
                        opcaoInicio();
                        break;

                    default:
                        break;
                }
            } while (aux < 1 || aux > 5);
        }
        public void opcaoEleitor()
        {
            {
                Console.WriteLine("Cadastro - 1 ");
                Console.WriteLine("Exclusão - 2 ");
                Console.WriteLine("Modo lista - 3 ");
                Console.WriteLine("Pesquisa -  4 ");
                Console.WriteLine("Alteração - 5 ");
                Console.WriteLine("Sair - 6 ");
                int aux = int.Parse(Console.ReadLine());
                do
                {
                    switch (aux)
                    {
                        //titulo, int zona, int secao,string nome, string nascimento
                        case 1:
                            string nome, nascimento;
                            int titulo, zona, secao;                         
                            Console.WriteLine("Para cadastrar digite:\nNro Titulo:\nZona Eleitoral:\nSessão:\nNome do Eleitor:\nData dde Nascimento:\n");
                            titulo = int.Parse(Console.ReadLine());
                            zona = int.Parse(Console.ReadLine());
                            secao = int.Parse(Console.ReadLine());
                            Local local = urnas.retornaLocal(zona, secao);
                            nome = Console.ReadLine();
                            nascimento = Console.ReadLine();
                            if (eleitores.EhTitulo(titulo) == false)
                            {
                                Console.WriteLine("Titulo em uso!");
                                opcaoEleitor();
                            }
                            if (local == null)
                            {
                                Console.WriteLine("Urna não existe!");
                                opcaoEleitor();
                            }
                            else
                            {
                                eleitores.cadastrar(titulo, local, nome, nascimento);
                                opcaoEleitor();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Digite o Titulo para excluir!");
                            int a = int.Parse(Console.ReadLine());
                            eleitores.excluir(a);
                            opcaoEleitor();
                            break;
                        case 3:
                            eleitores.listar();
                            Console.ReadKey();
                            opcaoEleitor();
                            break;
                        case 4:
                            Console.WriteLine("Digite o Titulo para pesquisar!");
                            int b = int.Parse(Console.ReadLine());
                            eleitores.pesquisa(b);
                            Console.ReadKey();
                            opcaoEleitor();
                            break;
                        case 5:
                            Console.WriteLine("Digite o Titulo para alterar!");
                            int c = int.Parse(Console.ReadLine());
                            eleitores.pesquisa(c);
                            opcaoEleitor();
                            break;
                        case 6:
                            Console.Clear();
                            opcaoInicio();
                            break;

                        default:
                            break;
                    }
                } while (aux < 1 || aux > 7);
            }
        }
        public void opcaoApurar()
        {
            Console.Clear();
            Console.WriteLine("Apuração das Elições");
            int contVotos = 0;
            foreach (Urna u in urnas.GetList())
            {
                foreach (Voto v in u.GetList())
                {
                    candidatos.AtribuiVoto(v.getVotoPrefeito());
                    contVotos++;
                    candidatos.AtribuiVoto(v.getVotoVereador());
                }
            }
            List<Candidato> prefeitos = new List<Candidato>();
            List<Candidato> vereador = new List<Candidato>();
            foreach (Candidato c in candidatos.GetList())
            {
                if (c.getEhPrefeito() == true)
                {
                    prefeitos = candidatos.GetList().OrderByDescending(candidatos => candidatos.getVoto()).ToList();
                }
                if (c.getEhPrefeito() == false)
                {
                    vereador = candidatos.GetList().OrderByDescending(candidatos => candidatos.getVoto()).ToList();
                }
            }
            CadastraCanditado aux = new CadastraCanditado();
            aux.SetList(vereador);
            foreach (Candidato v in aux.GetList())
            {
                Console.WriteLine("Vereadores :");
                Console.WriteLine("\nNome:" + v.getNome() + "\nPartido:" + v.getPartido() + "\nNúmero de votos:" + v.getVoto());
            }
            if (prefeitos[0].getVoto() > contVotos / 2)
            {
                Console.WriteLine("Prefeito Eleito :");
                Console.WriteLine("\nNome:" + prefeitos[0].getNome() + "\nPartido:" + prefeitos[0].getPartido() + "\nNúmero de votos:" + prefeitos[0].getVoto());
            }
            else
            {
                Console.WriteLine("Candidatos à Prefeito no segundo turno :");
                Console.WriteLine("Candidato 1 :");
                Console.WriteLine("\nNome:" + prefeitos[0].getNome() + "\nPartido:" + prefeitos[0].getPartido() + "\nNúmero de votos:" + prefeitos[0].getVoto());
                Console.WriteLine("Candidatos 2 :");
                Console.WriteLine("\nNome:" + prefeitos[1].getNome() + "\nPartido:" + prefeitos[1].getPartido() + "\nNúmero de votos:" + prefeitos[1].getVoto());
            }


        }

        //Telas das Eleições
        public void eleicoes()
        {
            Console.WriteLine("Bem vindo ao Sistema de Eleições!");
            opcaoEleicoes();

        }
        public void opcaoEleicoes()
        {
            Console.WriteLine("Escolha uma opção!");
            Console.WriteLine("1 - Votar\n2-Sair");
            int aux = int.Parse(Console.ReadLine());
            do
            {
                switch (aux)
                {
                    case 1:
                        opcaoVotacao();
                        break;

                    case 2:
                        opcaoInicio();
                        break;
                }
            } while (aux < 1 || aux > 2);
        }
        public void opcaoVotacao()
        {
            try
            {
                Console.WriteLine("Para iniciar digite o Titulo de Eleitor");
                int titulo = int.Parse(Console.ReadLine());
                int zona = eleitores.getZona(titulo);
                int secao = eleitores.getSecao(titulo);
                Console.WriteLine("Digite o número do seu candidato a prefeito!");
                string numPrefeito = Console.ReadLine();
                Console.WriteLine("Digite o número do seu candidato a vereador");
                string numVereador = Console.ReadLine();
                Urna u = urnas.GetUrna(secao, zona);
                u.addVoto(numPrefeito, numVereador);
                Console.Clear();
                opcaoEleicoes();
            }
            catch
            {
                Console.WriteLine("Deu Erro! Tente Novamente!");
                opcaoEleicoes();
            }
        }

        //Funcao auxiliar para saber se é Prefeito ou Vereador
        public bool EhPrefeito()
        {
            bool ehPrefeito = false;
            Console.WriteLine("Esse candidato é:");
            Console.WriteLine("1 - Prefeito");
            Console.WriteLine("2 - Vereador");
            int aux = int.Parse(Console.ReadLine());
            if (aux == 1)
            {
                ehPrefeito = true;
            }
            return ehPrefeito;

        }
    }    
}
