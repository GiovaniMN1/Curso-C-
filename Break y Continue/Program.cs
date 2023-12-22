namespace Break_y_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Break
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    if (i == 5)
            //    {
            //        break; // Sale del bucle cuando i es igual a 5
            //    }
            //    i++;
            //}

            //// Continue
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Salta a la siguiente iteración si i es par
                }
                Console.WriteLine(i);
            }

        }
    }
}