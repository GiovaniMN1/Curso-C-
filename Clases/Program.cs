namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(2, "Veanta 1", 12);

        }

        public class Sale
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Value { get; set; }

            public Sale(int id, string name, int value)
            {

                this.Id = id;
                this.Name = name;
                this.Value = value;
            }

            public string GetInfo()
            {
                Console.WriteLine($"{Id}, {Name}, {Value}");
            }

        }
    }
}