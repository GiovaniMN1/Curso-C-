namespace Desafío_de_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Empleado empleado = new Empleado("Juan", "Lopez", 1000);
            Jefe jefe = new Jefe ("Bmw", "Pedro", "Martinez", 3000);
            Pasante pasante = new Pasante(8, 6, "Mario", "Montes",500);
            Console.WriteLine(jefe.Dirigir());
            Console.WriteLine(pasante.Trabajar());

        }

        public class Empleado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public float Salario { get; set; }

            public Empleado(string nombre, string apellido, float salario)
            {
                Nombre = nombre;
                Apellido = apellido;
                Salario = salario;
            }

            public string Trabajar()
            {
                return "Estoy trabajando";
            }
            public string Descansar()
            {
                return "Estoy descansandio";
            }

            

          
        }

        public class Jefe: Empleado
        {
            public string AutoDeEmpresa { get; set; }

            public Jefe(string autoDeEmpresa, string nombre, string apellido, float salario):base(nombre, apellido, salario)
            {
                AutoDeEmpresa = autoDeEmpresa;
            }

            public string Dirigir()
            {
                return "Soy el Jefe";
            }

           
        }
        public class Pasante: Empleado
        {
            public int HorasDeTrabajo { get; set; }
            public int HorasDeEscuela { get; set; }

            public Pasante(int horasDeTrabajo, int horasDeEscuela, string nombre, string apellido, float salario):base (nombre,apellido, salario)
            {
                HorasDeTrabajo = horasDeTrabajo;
                HorasDeEscuela = horasDeEscuela;
            }
            public  string Trabajar()
            {
                int operacionHorasTrabajo = HorasDeTrabajo * 5;
                return $"la cantidad de horas semanales de trabajo del pasante: {operacionHorasTrabajo}";
            }
            public string Aprender()
            {
                return $"Estoy aprendiendo durante {HorasDeEscuela} cantidad de horas ";
            }

        }



    }
}
