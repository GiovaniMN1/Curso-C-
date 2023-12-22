namespace Operador_ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;

            string resultado = numero >= 10 ? $"{numero} es mayor a 10" : $"{numero} es menor a 10";
            Console.WriteLine(resultado);
        }
    }
}