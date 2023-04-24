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

        double Soma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

         double Soma(double num1, double num2, double num3)
        {
            double resultado = num1 + num2 + num3;
            return resultado;
        }


        int resultado1 = Soma(3, 5); 
        double resultado2 = Soma(2.5, 3.7); 
        double resultado3 = Soma(1.0, 2.0, 3.0);

        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);
        Console.WriteLine(resultado3);

    }
}