namespace _1028_testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            var result = calc.Somar(2, 2);

            Console.WriteLine(result);
        }
    }
}
