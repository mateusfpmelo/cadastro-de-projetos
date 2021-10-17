using System;

namespace Dio.Projetos
{
    class Program
    {
        static ProjetoRepositorio repositorio = new ProjetoRepositorio();
        static void Main(string[] args)
        {
            string opcaousuario = ObterOpcaoUsuario();

            while (opcaousuario.ToUpper() != "X")
            { 
                switch (opcaousuario)
                {
                    case "1":
                    Listarprojetos();
                    break;
                    case "2":
                    InserirProjeto();
                    break;
                    case "3":
                    AtualizarProjeto();
                    break;
                    case "4":
                    ExcluirProjeto();
                    break;
                    case "5":
                    VisualizarProjeto();
                    break;
                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaousuario = ObterOpcaoUsuario();
                
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        


        private static void InserirProjeto()
        {
            Console.WriteLine("Inserir novo projeto");
            foreach (int i in Enum.GetValues(typeof(Categoria))) //getvalues vai retornar todas opções
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Categoria), i)); //getname irá mostrar todas opções 
            }
            Console.Write("Digite o tipo de projeto entre as opções acima: ");
            int entradacategoria = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente:");
            string entradanome = Console.ReadLine();

            Console.Write("Digite o status do projeto:");
            string entradastatus = Console.ReadLine();

            Console.Write("Digite o ano de conclusão do projeto:");
            int entradaAno = int.Parse(Console.ReadLine());

            Projeto novoprojeto = new Projeto(id: repositorio.ProximoID(),
                                                categoria: (Categoria)entradacategoria,
                                                NomeCliente: entradanome,
                                                StatusProjeto: entradastatus,
                                                AnoConclusao: entradaAno);
            repositorio.Insere(novoprojeto);
        }
        private static void Listarprojetos()
        { 
            Console.WriteLine("Listar projetos");
            var lista = repositorio.Lista();
            if (lista.Count == 0 )
            { 
                Console.WriteLine("Nenhum projeto cadastrado.");
                return;
            }
            foreach (var projeto in lista)
            { 
                var excluido = projeto.retornaexcluido();
                
                Console.WriteLine("#ID {0}: - {1} - {2} ", projeto.retornaID(), projeto.retornaNomeCliente(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void ExcluirProjeto()
        { 
            Console.Write("Digite o id do projeto: ");
            int indiceprojeto = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceprojeto);
        }


        private static void VisualizarProjeto()
        {
            Console.Write("Digite o id do projeto: ");
            int indiceprojeto = int.Parse(Console.ReadLine());
            
            var projeto = repositorio.RetornaPorId(indiceprojeto);

            Console.WriteLine(projeto);
        }


        private static void AtualizarProjeto()
        { 
            Console.Write("Digite o id do projeto: ");
            int indiceprojeto = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Categoria), i));
            }
            Console.WriteLine("Digite o tipo de projeto entre as opções acima: ");
            int entradacategoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente:");
            string entradanome = Console.ReadLine();

            Console.WriteLine("Digite o nome do projeto:");
            string entradastatus = Console.ReadLine();

            Console.WriteLine("Digite o ano de conclusão do projeto:");
            int entradaAno = int.Parse(Console.ReadLine());

            Projeto atualizaprojeto = new Projeto(id: indiceprojeto,
                                                categoria: (Categoria)entradacategoria,
                                                NomeCliente: entradanome,
                                                StatusProjeto: entradastatus,
                                                AnoConclusao: entradaAno);
            repositorio.Atualiza(indiceprojeto, atualizaprojeto);
        }

        
        private static string ObterOpcaoUsuario()
        { 
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar projetos");
            Console.WriteLine("2- Inserir novo projeto");
            Console.WriteLine("3- Atualizar projeto");
            Console.WriteLine("4- Excluir projeto");
            Console.WriteLine("5- Visualizar projeto");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaousuario;
        }
    }
}
