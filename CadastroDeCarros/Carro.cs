using System;
namespace CadastroDeCarros
{
	public class Carro
	{
		public string marca;
		public string modelo;
		public string placa;
		public string cor;
		public Proprietario proprietario = new Proprietario();
	}
}

