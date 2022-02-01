using System;

namespace CadastroMotos
{
    class Program
    {
        private static MotoRepositorio repositorio = new MotoRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarMotos();
                        break;
                    case "2":
                        InserirMoto();
                        break;
                    case "3":
                        AtualizarMoto();
                        break;
                    case "4":
                        DeleteMoto();
                        break;
                    case "5":
                        VisualizarMoto();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarMotos()
        {
            Console.WriteLine("Listar Motos");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma moto cadastrada.");
                return;
            }

            foreach (var motos in lista)
            {
                var excluido = motos.retornaNome();

                Console.WriteLine("#ID {0}: - {1} {2}", motos.retornaId(), motos.retornaNome());
            }
        }
        private static void InserirMoto()
        {
            Console.WriteLine("Inserir nova moto");

            foreach (int i in Enum.GetValues(typeof(Estilo)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Estilo), i));
            }
            Console.Write("Digite o estilo entre as opções acima: ");
            int entradaEstilo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da moto: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Ano de fabricação da moto: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da moto: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a cilindrada da moto: ");
            int entradaCilindrada = int.Parse(Console.ReadLine());

            Moto novaMoto = new Moto(id: repositorio.NextId(),
                              estilo: (Estilo)entradaEstilo,
                              nome: entradaNome,
                              anoFabricacao: entradaAno,
                              cilindrada: entradaCilindrada,
                              descricao: entradaDescricao);

            repositorio.Insert(novaMoto);
        }
        private static void AtualizarMoto()
        {
            Console.Write("Digite o id da Moto: ");
            int indiceMoto = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Estilo)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Estilo), i));
            }
            Console.Write("Digite o estilo entre as opções acima: ");
            int entradaEstilo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da moto: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Ano de fabricação da moto: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da moto: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a cilindrada da moto: ");
            int entradaCilindrada = int.Parse(Console.ReadLine());

            Moto atualizaMoto = new Moto(id: repositorio.NextId(),
                              estilo: (Estilo)entradaEstilo,
                              nome: entradaNome,
                              anoFabricacao: entradaAno,
                              cilindrada: entradaCilindrada,
                              descricao: entradaDescricao);

            repositorio.Atualiza(indiceMoto, atualizaMoto);
        }
        private static void DeleteMoto()
        {
            Console.Write("Digite o id da Moto: ");
            int listaMotos = int.Parse(Console.ReadLine());

            repositorio.Delete(listaMotos);
        }
        private static void VisualizarMoto()
        {
            Console.Write("Digite o id da série: ");
            int listaMotos = int.Parse(Console.ReadLine());

            var moto = repositorio.ReturnById(listaMotos);

            Console.WriteLine(moto);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Motos Adventure a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Motos");
            Console.WriteLine("2- Inserir nova Moto");
            Console.WriteLine("3- Atualizar Moto");
            Console.WriteLine("4- Excluir Moto");
            Console.WriteLine("5- Visualizar Moto");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
