namespace EjercicioClase1Modulo2
{
    public class Dimensiones
    {
        public int alto { get; set; }
        public int ancho { get; set; }
        public int profundidad { get; set; }
    }

    public class Detalles
    {
        public double peso { get; set; }
        public Dimensiones dimensiones { get; set; }
    }

    public class Producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public int existencias { get; set; }
        public bool descuento_disponible { get; set; }
        public string[] etiquetas { get; set; }
        public Detalles detalles { get; set; }
    }

    public class Ejercicio3
    {
        public Producto[] productos { get; set; }
    }
}


