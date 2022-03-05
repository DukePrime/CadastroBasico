using System;

namespace Dio.TechSystem
{
    class Progran
    {
        static ServRepositorio repositorio = new ServRepositorio();
        static void Main(string[] args)
        {
            
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarServicos();
						break;
					case "2":
						InserirServicos();
						break;
					case "3":
						AtualizarServicos();
						break;
					case "4":
						ExcluirServicos();
						break;
					case "5":
						VisualizarServicos();
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
        private static void ListarServicos()
		{
			Console.WriteLine("Listar Serviços");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma serviço cadastrado.");
				return;
			}

			foreach (var servicos in lista)
			{
                var excluido = servicos.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", servicos.retornaId(), servicos.retornaRazaoSocial(), (excluido ? "*Excluído*" : ""));
			}
		}
        private static void InserirServicos()
		{
			Console.WriteLine("Inserir nova série");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(ServicosE)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(ServicosE), i));
			}
			Console.Write("Digite o Id do serviço entre as opções acima: ");
			int entradaServicosE = int.Parse(Console.ReadLine());

			Console.Write("Digite a Razão Social da Empresa: ");
			string entradaRazaoSocial = Console.ReadLine();

			Console.Write("Digite o CNPJ: ");
			string entradaCNPJ = (Console.ReadLine());

            Console.Write("Digite o CEP: ");
			string entradaCEP = (Console.ReadLine());

            Console.Write("Digite o Estado: ");
			string entradaEstado = (Console.ReadLine());

            Console.Write("Digite a Cidade: ");
			string entradaCidade = (Console.ReadLine());

            Console.Write("Digite o Telefone: ");
			string entradaTelefone = (Console.ReadLine());

            Console.Write("Digite o E-mail: ");
			string entradaEmail = (Console.ReadLine());

			Console.Write("Digite a Descrição do serviço prestado: ");
			string entradaDescricao = Console.ReadLine();

			Servicos novoServico = new Servicos(id: repositorio.ProximoId(),
										servicosE: (ServicosE)entradaServicosE,
										razaoSocial: entradaRazaoSocial,
										cnpj: entradaCNPJ,
                                        cep: entradaCEP,
                                        estado: entradaEstado,
                                        cidade: entradaCidade,
                                        telefone: entradaTelefone,
                                        email: entradaEmail,
										descricao: entradaDescricao);

			repositorio.Insere(novoServico);
		}
        private static void AtualizarServicos()
		{
			Console.Write("Digite o id do serviço: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(ServicosE)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(ServicosE), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaServicosE = int.Parse(Console.ReadLine());

			Console.Write("Digite a Razão Social da Empresa: ");
			string entradaRazaoSocial = Console.ReadLine();

			Console.Write("Digite o CNPJ: ");
			string entradaCNPJ = (Console.ReadLine());
            Console.Write("Digite o CEP: ");
			string entradaCEP = (Console.ReadLine());

            Console.Write("Digite o Estado: ");
			string entradaEstado = (Console.ReadLine());

            Console.Write("Digite a Cidade: ");
			string entradaCidade = (Console.ReadLine());

            Console.Write("Digite o Telefone: ");
			string entradaTelefone = (Console.ReadLine());

            Console.Write("Digite o E-mail: ");
			string entradaEmail = (Console.ReadLine());

			Console.Write("Digite a Descrição da serviço prestado: ");
			string entradaDescricao = Console.ReadLine();

			Servicos atualizaSerie = new Servicos(id: indiceSerie,
										servicosE: (ServicosE)entradaServicosE,
										razaoSocial: entradaRazaoSocial,
										cnpj: entradaCNPJ,
                                        cep: entradaCEP,
                                        estado: entradaEstado,
                                        cidade: entradaCidade,
                                        telefone: entradaTelefone,
                                        email: entradaEmail,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
            Console.WriteLine("|-----------------------------------------------------|");
			Console.WriteLine("|#DIO.TechSystem plataforma de serviços tecnologicos #|");
            Console.WriteLine("|-----------------------------------------------------|");
			Console.WriteLine("|          Informe o número opção desejada:           |");
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("|                                                     |");
			Console.WriteLine("|                [1] Listar serviços                  |");
			Console.WriteLine("|                [2] Inserir novo serviços            |");
            Console.WriteLine("|                [3] Atualizar novo serviços          |");
			Console.WriteLine("|                [4] Excluir serviços                 |");
			Console.WriteLine("|                [5] Visualizar serviços              |");
			Console.WriteLine("|                [C] Limpar Tela                      |");
			Console.WriteLine("|                [X] Sair                             |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|-----------------------------------------------------|");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
        private static void ExcluirServicos()
		{
			Console.Write("Digite o id do prestador de serviço: ");
			int indiceServicos = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceServicos);
		}
         private static void VisualizarServicos()		{
			Console.Write("Digite o id do prestador de serviço: ");
			int indiceServicos = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceServicos);

			Console.WriteLine(serie);
		}
    }
}