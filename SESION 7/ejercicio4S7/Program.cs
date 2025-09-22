// See https://aka.ms/new-console-template for more information
//Ejercicio 4: Calcular IVA y total a pagar
using System; // Importa el espacio de nombres System para usar la consola y tipos de datos

class Program // Define la clase principal del programa
{
    // Función que calcula el IVA y el total a pagar según la cantidad y el precio unitario
    // Parámetros: cantidad (int), precioUnitario (decimal)
    // Retorno: void (no retorna nada, solo muestra resultados en consola)
    static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
    // Estaba mal puesta 
    // Esta función calcula el subtotal, el IVA y el total a pagar
    // según la cantidad de productos y el precio unitario proporcionados.
    // Muestra los resultados en la consola con dos decimales para el formato monetario
    {
        // Calcula el subtotal multiplicando la cantidad por el precio unitario
        // ya estaban, pero estaban desorganizados.
        decimal subtotal = cantidad * precioUnitario;

        // Calcula el IVA como el 15% del subtotal
        decimal iva = subtotal * 0.15m;

        // Calcula el total sumando el subtotal y el IVA
        decimal total = subtotal + iva;

        // Muestra la cantidad de productos
        Console.WriteLine($"Cantidad: {cantidad}");

        // Muestra el precio unitario con dos decimales
        Console.WriteLine($"Precio unitario: {precioUnitario:F2}");

        // Muestra el subtotal con dos decimales
        Console.WriteLine($"Subtotal: {subtotal:F2}"); 

        // Muestra el IVA calculado con dos decimales
        Console.WriteLine($"IVA (15%): {iva:F2}");// ya estaba

        // Muestra el total a pagar con dos decimales
        Console.WriteLine($"Total a pagar: {total:F2}"); //ya estaba
    }

    // Función principal del programa
    static void Main(string[] args)
    // Método Main que se ejecuta al iniciar el programa
    // Solicita al usuario la cantidad de productos y el precio unitario

    {
        // Solicita al usuario la cantidad de productos
        // Utiliza int.Parse para convertir la entrada del usuario a un entero
        // Maneja posibles excepciones si la entrada no es un número válido
        Console.Write("Ingrese la cantidad de productos: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Solicita al usuario el precio unitario del producto
        // Utiliza decimal.Parse para convertir la entrada del usuario a un decimal
        // Maneja posibles excepciones si la entrada no es un número válido
        Console.Write("Ingrese el precio unitario del producto: ");
        decimal precioUnitario = decimal.Parse(Console.ReadLine());

        // Llama a la función para calcular y mostrar el IVA y el total
        // pasa la cantidad y el precio unitario como argumentos
        CalcularIVAyTotal(cantidad, precioUnitario);
    }
}

/*
// Ejercicio 4: Calcular el IVA del 15% y el total a pagar según la cantidad y el precio unitario de un producto.

decimal iva = subtotal * 0.15m;
Console.WriteLine($"IVA (15%): {iva}");
Console.WriteLine($"Total a pagar: {totalF2}"); 

static void CalcularIVATotal(decimal precioUnitario) 
{
    decimal cantidad;
    Console.WriteLine($"Cantidad: {cantidad}");
    Console.WriteLine($"Precio unitario: {precioUnitario}");
    Console.WriteLine($"Subtotal: {subtotal}");
    
    decimal subtotal = cantidad * precioUnitario;
}



--- Organización y explicación ---

1. Se creó la función 'CalcularIVAyTotal' que recibe la cantidad y el precio unitario.
2. Dentro de la función, primero se calcula el subtotal (cantidad * precioUnitario).
3. Luego se calcula el IVA como el 15% del subtotal.
4. Después se calcula el total sumando el subtotal y el IVA.
5. Se muestran todos los valores calculados con mensajes descriptivos.
6. En el método 'Main', se solicita al usuario la cantidad y el precio unitario, y se llama a la función para mostrar los resultados.

Así, el orden es: entrada de datos -> cálculo de subtotal -> cálculo de IVA -> cálculo de total -> salida de resultados.
Cada elemento está comentado para explicar su función y propósito.
*/
    // Solicita al usuario la cantidad de productos y el precio unitario
    // Llama a la función para calcular y mostrar el IVA y el total