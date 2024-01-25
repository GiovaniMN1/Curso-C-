namespace Intefaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReproductorMultimedia reproductor = new ReproductorDeMusica();

            reproductor.Reproducir();
            reproductor.Pausar();
            reproductor.Detener();
        }

        public interface IReproductorMultimedia
        {
            void Reproducir();
            void Pausar();
            void Detener();
        }
        public class ReproductorDeMusica : IReproductorMultimedia
        {
            public void Reproducir()
            {
                Console.WriteLine("Reproduciendo música");
            }

            public void Pausar()
            {
                Console.WriteLine("Pausando música");
            }

            public void Detener()
            {
                Console.WriteLine("Deteniendo música");
            }
        }

    }
}