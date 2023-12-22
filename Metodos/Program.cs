namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumar(12, 10));
        }

        public static int Sumar(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }

    }
}