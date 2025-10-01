using System;

// Clase principal Program
// Aquí está el método Main que es el punto de entrada del programa.
class Program
{
    static void Main(string[] args)
    {
        // ----------------------------------
        // CREACIÓN DE OBJETOS (MASCOTAS)
        // ----------------------------------
        // Usamos la clase Mascota para crear dos objetos distintos:
        Mascota perro = new Mascota("Firulais", "Perro");  
        Mascota gato = new Mascota("Misu", "Gato");

        // ----------------------------------
        // ESTADO INICIAL DE LAS MASCOTAS
        // ----------------------------------
        perro.Estado();
        gato.Estado();

        // ----------------------------------
        // ACCIONES CON EL PERRO
        // ----------------------------------
        perro.Jugar(3);       // Firulais juega 3 minutos → gasta 30 de energía
        perro.Estado();       // Se muestra el estado después de jugar
        perro.Alimentar(20);  // Firulais come y recupera +20 de energía
        perro.Estado();       // Se muestra el estado actualizado

        Console.WriteLine();  // Línea en blanco para separar

        // ----------------------------------
        // ACCIONES CON EL GATO
        // ----------------------------------
        gato.Jugar(5);        // Misu juega 5 minutos → gasta 50 de energía
        gato.Estado();        // Estado después de jugar
        gato.Alimentar(15);   // Misu come y recupera +15 de energía
        gato.Estado();        // Estado actualizado

        // ----------------------------------
        // FIN DEL PROGRAMA
        // ----------------------------------
        // Console.ReadLine se usa para que la ventana de la consola
        // no se cierre automáticamente al terminar.
        Console.ReadLine();
    }
}
