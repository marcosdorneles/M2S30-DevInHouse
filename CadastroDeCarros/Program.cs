using CadastroDeCarros;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
    }
}