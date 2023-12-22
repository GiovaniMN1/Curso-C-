namespace Ingreso_del_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            // Llamar al método Suma con los números ingresados
            int resultadoSuma = num1 + num2;

            // Mostrar el resultado
            Console.WriteLine($"La suma es: {resultadoSuma}");
        }


    }
}
