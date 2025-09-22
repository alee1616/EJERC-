// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    // Encabezado del método:
    // static = indica que el método pertenece a la clase Program y se puede llamar sin crear objetos.
    // int = tipo de dato de retorno (número entero).
    // MayorDeTres = nombre del método.
    // (int a, int b, int c) = parámetros por VALOR (se reciben copias de los números).
    //
    // Si fuera por referencia, deberíamos escribir:
    // static int MayorDeTres(ref int a, ref int b, ref int c)
    static int MayorDeTres(int a, int b, int c)
    {
        // Cuerpo del método:
        // Math.Max(x, y) devuelve el mayor de dos números.
        // Aquí lo usamos dos veces: primero entre b y c, luego entre ese resultado y a.
        return Math.Max(a, Math.Max(b, c));
        // Devuelve el mayor de los tres números
        // Si fuera por referencia:
        // 1. Cambiar la firma del método como se indicó arriba.
        // 2. Llamar así: int mayor = MayorDeTres(ref a, ref b, ref c);
        // Esto permitiría que dentro de la función se puedan modificar los valores originales de a, b y c.
        // Aunque en este caso no es necesario modificar los valores, solo compararlos.


        // Con ref, podrías modificar a, b y c directamente en Main,
        // aunque en este caso no tiene mucho sentido porque solo queremos compararlos.
    }

    static void Main()
    {
        // Bucle infinito para repetir hasta que se ingrese el centinela (-99).
        while (true)
        {
            // Leer el primer número (a).
            Console.Write("Ingrese a (o -99 para terminar): ");
            int a = int.Parse(Console.ReadLine()!);
            if (a == -99) break; // condición de salida (centinela)

            // Leer el segundo número (b).
            Console.Write("Ingrese b (o -99 para terminar): ");
            int b = int.Parse(Console.ReadLine()!);
            if (b == -99) break; // condición de salida (centinela)

            // Leer el tercer número (c).
            Console.Write("Ingrese c (o -99 para terminar): ");
            int c = int.Parse(Console.ReadLine()!);
            if (c == -99) break; // condición de salida (centinela)

            // Llamada a la función pasando los valores como argumentos.
            // En este caso se pasan por valor (copias).
            int mayor = MayorDeTres(a, b, c);

            // Mostrar el resultado en pantalla.
            Console.WriteLine($"El mayor es: {mayor}\n");

            // Si fuera por referencia:
            // 1. Cambiar la firma del método: static int MayorDeTres(ref int a, ref int b, ref int c)
            // 2. Llamar así: int mayor = MayorDeTres(ref a, ref b, ref c);
            // Esto permitiría que dentro de la función se puedan modificar los valores originales de a, b y c.
        }

        // 👉 Mensaje final al salir del bucle (cuando se ingresa -99).
        Console.WriteLine("Fin del programa.");
    }
}
