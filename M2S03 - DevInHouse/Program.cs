internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


         int Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        int resultado = Soma(3, 5);

        Console.WriteLine(resultado);


    }
}