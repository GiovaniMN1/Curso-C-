namespace Conversiones_explicitas_e_implicitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversión implícita de int a double

            int num = 10;
            double numDouble = num;
            Console.WriteLine($"Conversión implícita de int a double - {numDouble}");

            // Conversión explícita de double a int

            double numDecimal = 12.40;
            int numInt = (int)numDecimal;
            Console.WriteLine($"Conversión explícita de double a int - {numInt}");

            // Conversión explícita de double a int
            double decimalNumber = 123.45;
            int entero = Convert.ToInt32(decimalNumber);
            Console.WriteLine(entero);

        }
    }
}