// See https://aka.ms/new-console-template for more information

//Ejercicio 2: Intercambiar valores (uso de ref)
using System; // Importa el espacio de nombres System para usar la consola

class Program //   Define la clase principal del programa
{
    //Tipo: procedimiento porque retorna void, con parametros por referencia (ref)
    //Uso: cuando necesitas modificar variables originales (intercambiar valores, actualizar contadores, etc.).
    static void Intercambiar(ref int x, ref int y)
    // Define un método que intercambia dos valores enteros usando referencias
    // Los parámetros se pasan por referencia con 'ref'
    // Esto permite modificar los valores originales
    // en lugar de trabajar con copias locales
    //lo que retorna es void porque no devuelve nada entonces es un procedimiento
    {
        // Intercambia los valores de x e y usando una variable temporal
        // Al usar 'ref', los cambios afectan a las variables originales
        // fuera del método
        // Esto es útil para intercambiar valores sin necesidad de devolverlos
        // como en una función tradicional
    {
        int temp = x; // Almacena temporalmente el valor de x
        x = y; // Asigna el valor de y a x
        y = temp; // Asigna el valor temporal (original de x) a y
    }

    //Tipo: procedimiento porque retorna void. y no contiene ningún parámetro
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
// }
// y = temp;
// {
// int temp = x;
// static void Intercambiar(ref int x, ref int y)
// x = y;


//2 Procedimientos en total:
//Intercambiar → procedimiento con parámetros por referencia.
//Main → procedimiento (sin parámetros).