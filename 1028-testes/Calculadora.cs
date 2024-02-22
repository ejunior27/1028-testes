namespace _1028_testes
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int v1, int v2)
        {
            return v1 + v2;
        }

        public int Dividir(int v1, int v2)
        {
            return v1 / v2;
        }

        public int Subtrair(int v1, int v2)
        {
            return v2 - v1;
        }

        public int Multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
