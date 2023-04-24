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
    }
}