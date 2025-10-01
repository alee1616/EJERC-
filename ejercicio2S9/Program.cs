// Crea un programa en C# que simule una mascota virtual utilizando clases y objetos.

using System;

class Mascota
{
    // Atributos (variables que representan características de la mascota)
    public string nombre;   // almacena el nombre de la mascota
    public string tipo;     // almacena el tipo de mascota (perro, gato, etc.)
    public int energia;     // nivel de energía de la mascota (0 a 100)

    // Constructor: se usa para inicializar un objeto de la clase Mascota
    public Mascota(string nombre, string tipo)
    {
        this.nombre = nombre;   // "this" se usa para diferenciar entre el parámetro y el atributo
        this.tipo = tipo;
        this.energia = 100;     // todas las mascotas empiezan con energía al 100
    }

    // Método para jugar: recibe un tiempo en minutos y descuenta energía
    public void Jugar(int tiempo)
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
    public void Alimentar(int cantidad)
    {
        energia += cantidad;   // se suma energía
        if (energia > 100)     // la energía no puede pasar de 100
        {
            energia = 100;
        }
        Console.WriteLine(nombre + " ha sido alimentado con +" + cantidad + " de energía.");
    }

    // Método para mostrar el estado de la mascota
    public void Estado()
    {
        Console.WriteLine("Mascota: " + nombre + " | Tipo: " + tipo + " | Energía: " + energia);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear dos objetos de la clase Mascota usando el constructor
        Mascota perro = new Mascota("Firulais", "Perro");  
        Mascota gato = new Mascota("Misu", "Gato");

        // Mostrar el estado inicial de cada mascota
        perro.Estado();
        gato.Estado();

        // Acciones con el perro
        perro.Jugar(3);   // el perro juega 3 minutos → gasta 30 de energía
        perro.Estado();   // se muestra el estado después de jugar
        perro.Alimentar(20); // se alimenta al perro con +20 de energía
        perro.Estado();   // se muestra el estado actualizado

        Console.WriteLine(); // salto de línea para separar las acciones

        // Acciones con el gato
        gato.Jugar(5);    // el gato juega 5 minutos → gasta 50 de energía
        gato.Estado();    // se muestra el estado después de jugar
        gato.Alimentar(15); // se alimenta al gato con +15 de energía
        gato.Estado();    // se muestra el estado actualizado

        // Esto se usa para pausar la consola y que el programa no se cierre automáticamente
        Console.ReadLine();
    }
}

