using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                    
                }
            }
        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o id da Pessoa: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornarPorId(indiceSerie);
            
            System.Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o id da Pessoa: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            System.Console.WriteLine("Inserir nova pessoa");
            int indiceSerie = int.Parse(Console.ReadLine());
            

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dgigte o Nome da pessoa: ");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite a data de nascimento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dgigte o seu trabalho");
            string entradaTrabalho = Console.ReadLine();

            Series atualizaSerie = new Series(id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         Nome: entradaNome,
                                         Trabalho: entradaTrabalho,
                                         ano: entradaAno);
            
            repositorio.Atualizar(indiceSerie, atualizaSerie);
        }

        private static void InserirSeries()
        {
            System.Console.WriteLine("Inserir nova pessoa");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dgigte o Nome da pessoa: ");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite a data de nascimento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dgigte o seu trabalho");
            string entradaTrabalho = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         Nome: entradaNome,
                                         Trabalho: entradaTrabalho,
                                         ano: entradaAno);
            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar pessoas");

            var lista = repositorio.List();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma pessoa cadastrada. ");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                System.Console.WriteLine("#ID {0}: {1}", serie.retornaId(), serie.retornaNome(), excluido ? "Excluido" : ""); //verdadeiro falso
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Cadastro a seu dispor!!!");
            System.Console.WriteLine("Informe a opção desejada:");

            System.Console.WriteLine("1- Listar Pessoa");
            System.Console.WriteLine("2- Inserir nova pessoa");
            System.Console.WriteLine("3- Atualizar pessoa");
            System.Console.WriteLine("4- Excluir pessoa");
            System.Console.WriteLine("5- Visualizar pessoa");
            System.Console.WriteLine("C- Limpar Tela");
            System.Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
