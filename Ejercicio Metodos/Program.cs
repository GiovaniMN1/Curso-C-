namespace Ejercicio_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string amigo1 = "Juan";
            string amigo2 = "Pedro";
            string amigo3 = "Pablo";

            Console.WriteLine(Saludar(amigo1));
            Console.WriteLine(Saludar(amigo2));
            Console.WriteLine(Saludar(amigo3));

        }

        public static string Saludar(string nombre)
        {
            return $"Hola, {nombre}";
        }
    }
}