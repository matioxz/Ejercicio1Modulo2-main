using System;
using System.IO;
using System.Text.Json;
using EjercicioClase1Modulo2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio clase 1 modulo 2");

        // Rutas de los archivos JSON
        var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
        var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
        var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

        // Deserialización y impresión de los datos
        ImprimirDatosEjercicio1(pathEjercicio1);
        ImprimirDatosEjercicio2(pathEjercicio2);
        ImprimirDatosEjercicio3(pathEjercicio3);
    }

   static void ImprimirDatosEjercicio1(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var ejercicio1 = JsonSerializer.Deserialize<Ejercicio1>(data);

            Console.WriteLine("Datos del primer JSON:");
            Console.WriteLine($"Usuario: {ejercicio1.usuario}");
            Console.WriteLine("Amigos:");
            foreach (var amigo in ejercicio1.amigos_usuario)
            {
                Console.WriteLine($"- {amigo}");
            }
            Console.WriteLine($"Notificaciones: {ejercicio1.notificaciones_usuario}");
            Console.WriteLine();
        }

    static void ImprimirDatosEjercicio2(string filePath)
    {
        var data = File.ReadAllText(filePath);
        var ejercicio2 = JsonSerializer.Deserialize<Ejercicio2>(data);

        Console.WriteLine("Datos del segundo JSON:");
        foreach (var estadistica in ejercicio2.estadistica)
        {
            Console.WriteLine($"Equipo: {estadistica.equipo}");
            Console.WriteLine("Jugadores:");
            foreach (var jugador in estadistica.jugadores)
            {
                Console.WriteLine($"- Nombre: {jugador.nombre}, Kills: {jugador.kills}, Death: {jugador.death}");
            }
            Console.WriteLine($"Campeon: {estadistica.campeon}");
        }
        Console.WriteLine();
    }

    static void ImprimirDatosEjercicio3(string filePath)
    {
        var data = File.ReadAllText(filePath);
        var ejercicio3 = JsonSerializer.Deserialize<Ejercicio3>(data);

        Console.WriteLine("Datos del tercer JSON:");
        foreach (var producto in ejercicio3.productos)
        {
            Console.WriteLine($"Nombre: {producto.nombre}");
            Console.WriteLine($"Precio: {producto.precio}");
            Console.WriteLine($"Existencias: {producto.existencias}");
            Console.WriteLine($"Descuento disponible: {producto.descuento_disponible}");
            Console.WriteLine("Etiquetas:");
            foreach (var etiqueta in producto.etiquetas)
            {
                Console.WriteLine($"- {etiqueta}");
            }
            Console.WriteLine($"Peso: {producto.detalles.peso}");
            Console.WriteLine($"Dimensiones: Alto: {producto.detalles.dimensiones.alto}, Ancho: {producto.detalles.dimensiones.ancho}, Profundidad: {producto.detalles.dimensiones.profundidad}");
        }
    }
}


