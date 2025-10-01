//EJERCICIO 2 - SESIÓN 9
// Crea un programa en C# que simule una mascota virtual utilizando clases y objetos.

using System;

class Mascota
{
    // Atributos (variables que representan características de la mascota)
    // el public se usa para que se pueda acceder desde fuera de la clase, entonces son "públicos".
    public string nombre;   // almacena el nombre de la mascota
    public string tipo;     // almacena el tipo de mascota (perro, gato, etc.)
    public int energia;     // nivel de energía de la mascota (0 a 100 en este caso)

    // Constructor: se usa para inicializar un objeto de la clase Mascota
    public Mascota(string nombre, string tipo)
    //se pusieron parámetros para inicializar los atributos
    //con public Mascota(string nombre, string tipo, int energia) se podría inicializar la energía también
    //este devuelve un objeto de tipo Mascota
    {
        this.nombre = nombre;
        // "this" se usa para diferenciar entre el parámetro y el atributo
        // this es para referirse al objeto actual, en este caso al objeto Mascota que se está creando.
        this.tipo = tipo;
        this.energia = 100;     // todas las mascotas empiezan con energía al 100
    }

    // Método para jugar: recibe un tiempo en minutos y descuenta energía
    public void Jugar(int tiempo) 
    // se usó void porque no devuelve ningún valor
    {
        int gasto = tiempo * 10;   // cada minuto de juego gasta 10 puntos de energía
        if (energia >= gasto)      // solo puede jugar si tiene suficiente energía
        {
            energia -= gasto;  // se descuenta la energía
            Console.WriteLine(nombre + " ha jugado durante " + tiempo + " minutos. Energía -" + gasto);
        }
        else
        {
            Console.WriteLine(nombre + " no tiene suficiente energía para jugar."); 
        }
    }

    // Método para alimentar: recibe una cantidad y aumenta la energía
    public void Alimentar(int cantidad) // se usa void porque no devuelve ningún valor
    {
        energia += cantidad;   // se suma energía, al alimentar a la mascota
        if (energia > 100)     // la energía no puede pasar de 100
        {
            energia = 100;
        }
        Console.WriteLine(nombre + " ha sido alimentado con +" + cantidad + " de energía.");
    }

    // Método para mostrar el estado de la mascota
    public void Estado()
    // se usa void porque no devuelve ningún valor y solo muestra información
    // Muestra el nombre, tipo y nivel de energía actual.
    {
        Console.WriteLine("Mascota: " + nombre + " | Tipo: " + tipo + " | Energía: " + energia);
    }
}

// Clase principal Programa
// Aquí está el método Main que es el punto de entrada del programa.
// CREACIÓN DE OBJETOS (MASCOTAS)
// Usamos la clase Mascota para crear dos objetos distintos:
//los dos objetos creados son independientes, cada uno tiene sus propios atributos
//en este caso son perro y gato
//este es el "programa principal" que usa la clase Mascota, donde lo llamas métodos y muestra resultados
class Program
{
    static void Main(string[] args)
    {
        // CREACIÓN DE OBJETOS (MASCOTAS)
        // Usamos la clase Mascota para crear dos objetos distintos:

        Mascota perro = new Mascota("Firulais", "Perro");
        Mascota gato = new Mascota("Misu", "Gato");
        Console.WriteLine();  // Línea en blanco para separar

        Console.WriteLine(">>>>>> ESTADO INICIAL <<<<<<");
        // ESTADO INICIAL DE LAS MASCOTAS
        perro.Estado(); // Muestra el estado inicial del perro que esta conectado a la variable perro  y llama al método Estado.
        gato.Estado(); // Muestra el estado inicial del gato que esta conectado a la variable gato y llama al método Estado.

        Console.WriteLine("\n////// ACCIONES DE FIRULAIS //////");

        // ACCIONES CON EL PERRO
        perro.Jugar(3);       // Firulais juega 3 minutos → gasta 30 de energía
        perro.Estado();       // Se muestra el estado después de jugar
        perro.Alimentar(20);  // Firulais come y recupera +20 de energía
        perro.Estado();       // Se muestra el estado actualizado

        Console.WriteLine();  // Línea en blanco para separar


        Console.WriteLine("\n////// ACCIONES DE FIRULAIS //////");
        // ACCIONES CON EL GATO
        gato.Jugar(5);        // Misu juega 5 minutos → gasta 50 de energía
        gato.Estado();        // Estado después de jugar
        gato.Alimentar(15);   // Misu come y recupera +15 de energía
        gato.Estado();        // Estado actualizado


        // FIN DEL PROGRAMA
        // Console.ReadLine se usa para que la ventana de la consola
        // no se cierre automáticamente al terminar.
        Console.WriteLine("\n****** FIN DEL PROGRAMA ******");
        Console.ReadLine();
    }
}
