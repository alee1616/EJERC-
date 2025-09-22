// See https://aka.ms/new-console-template for more information
using System; // Importa el espacio de nombres System para usar la consola

class Program //   Define la clase principal del programa
{
    static void Intercambiar(ref int x, ref int y)
    // Define un método que intercambia dos valores enteros usando referencias
    // Los parámetros se pasan por referencia con 'ref'
    // Esto permite modificar los valores originales
    // en lugar de trabajar con copias locales
    {
        int temp = x; // Almacena temporalmente el valor de x
        x = y; // Asigna el valor de y a x
        y = temp; // Asigna el valor temporal (original de x) a y
    }

    static void Main() // Punto de entrada del programa
    {
        int a = 3, b = 7;
        // Declara e inicializa dos variables enteras
        // Muestra los valores antes del intercambio
        // Utiliza interpolación de cadenas para mostrar los valores
        Console.WriteLine($"Antes: a={a}, b={b}");
        // Llama al método Intercambiar pasando las variables por referencia
        // Esto permite que los cambios realizados dentro del método
        // afecten a las variables originales

        Intercambiar(ref a, ref b);
        // Muestra los valores después del intercambio
        // Nuevamente, utiliza interpolación de cadenas para mostrar los valores
        // Los valores de a y b deberían estar intercambiados

        Console.WriteLine($"Después: a={a}, b={b}");
        // Muestra los valores después del intercambio
        // Nuevamente, utiliza interpolación de cadenas para mostrar los valores
        // Los valores de a y b deberían estar intercambiados
    }
}
