namespace Manejo_de_errores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese otro número");
            string num2 = Console.ReadLine();

            int num1ComoInt = int.Parse(num1);
            int num2ComoInt = int.Parse(num2);

            int resultado;

            try
            {
                resultado = num1ComoInt / num2ComoInt;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Te falto un numero");
            }
            catch (Exception)
            {
                Console.WriteLine("Surgio un error");
            }


        }
    }
}