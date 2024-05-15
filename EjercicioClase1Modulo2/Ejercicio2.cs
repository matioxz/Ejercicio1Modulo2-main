namespace EjercicioClase1Modulo2
{
    public class Jugador
    {
        public string nombre { get; set; }
        public int kills { get; set; }
        public int death { get; set; }
    }

    public class Estadistica
    {
        public string equipo { get; set; }
        public Jugador[] jugadores { get; set; }
        public bool campeon { get; set; }
    }

    public class Ejercicio2
    {
        public Estadistica[] estadistica { get; set; }
    }
}




