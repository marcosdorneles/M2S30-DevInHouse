using CadastroDeCarros;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Carro> listaCarros = new List<Carro>();

        var proprietario1 = new Proprietario();
        proprietario1.nome = "Musie";
        proprietario1.telefone = "11 1111-1111";
        proprietario1.cpf = "46144256075";

        var proprietario2 = new Proprietario();
        proprietario2.nome = "Cifoway";
        proprietario2.telefone = "22 2222-22222";
        proprietario2.cpf = "96279223078";

        var proprietario3 = new Proprietario();
        proprietario3.nome = "Nuvyes";
        proprietario3.telefone = "33 3333-3333";
        proprietario3.cpf = "45568719055";

        var carro1 = new Carro();
        carro1.marca = "Mazda";
        carro1.modelo = "RX 7 2.6 Turbo";
        carro1.placa = "KGX-9537";
        carro1.cor = "Cinza";
        carro1.proprietario = proprietario1;

        var carro2 = new Carro();
        carro2.marca = "CHANA";
        carro2.modelo = "Cargo 1.0 8V 53cv (Pick-Up)";
        carro2.placa = "HMO-8778";
        carro2.cor = "Laranja";
        carro2.proprietario = proprietario2;

        var carro3 = new Carro();
        carro3.marca = "SSANGYONG";
        carro3.modelo = "Musso DX 2.9 Diesel";
        carro3.placa = "LWO-4502";
        carro3.cor = "Cinza";
        carro3.proprietario = proprietario3;


        listaCarros.Add(carro1);
        listaCarros.Add(carro2);
        listaCarros.Add(carro3);

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Cadastrar Carro");
            Console.WriteLine("2 - Consultar Carros");
            Console.WriteLine("3 - Sair");

            Console.Write("\nDigite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarNovoCarro(listaCarros);
                    break;
                case 2:
                    exibeCarros(listaCarros);
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

            Console.WriteLine();

            void CadastrarNovoCarro(List<Carro> listaCarros)
        {
            Console.WriteLine("Cadastro de Novo Carro\n");

            Console.Write("Digite a marca do carro: ");
            string marca = Console.ReadLine();

            Console.Write("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            Console.Write("Digite a cor do carro: ");
            string cor = Console.ReadLine();

            Console.WriteLine("\nDados do proprietário:");

            Console.Write("Digite o nome do proprietário: ");
            string nomeProprietario = Console.ReadLine();

            Console.Write("Digite o CPF do proprietário: ");
            string cpfProprietario = Console.ReadLine();

            Console.Write("Digite o telefone do proprietário: ");
            string telefoneProprietario = Console.ReadLine();

            Proprietario proprietario = new Proprietario();

            Carro novoCarro = new Carro();
            novoCarro.marca = marca;
            novoCarro.modelo = modelo;
            novoCarro.placa = placa;
            novoCarro.cor = cor;
            novoCarro.proprietario = proprietario;

            listaCarros.Add(novoCarro);

            Console.WriteLine("\nNovo carro cadastrado com sucesso!\n");
        }

        void exibeCarros(List<Carro> listaCarros)
        {
            Console.WriteLine("Lista de Carros:");
            foreach (Carro carro in listaCarros)
            {
                Console.WriteLine("Marca: " + carro.marca);
                Console.WriteLine("Modelo: " + carro.modelo);
                Console.WriteLine("Placa: " + carro.placa);
                Console.WriteLine("Cor: " + carro.cor);
                Console.WriteLine("Proprietário: ");
                Console.WriteLine("\tNome: " + carro.proprietario.nome);
                Console.WriteLine("\tCPF: " + carro.proprietario.cpf);
                Console.WriteLine("\tTelefone: " + carro.proprietario.telefone);
                Console.WriteLine();
            }
        }

    }
}