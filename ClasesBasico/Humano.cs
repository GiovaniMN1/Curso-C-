namespace ClasesBasico
{
    internal class Humano
    {
        // Atributos
        public string nombre;

        public Humano(string nombre)
        {
            this.nombre = nombre;
        }




        //Metodos
        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {nombre}");
        }
    }
}
