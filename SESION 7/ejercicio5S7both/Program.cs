// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // -------- FUNCIÓN --------
    // Calcula y devuelve la cantidad de vocales en la cadena (con retorno)
    static int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";
        foreach (char c in texto)
            if (vocales.Contains(c)) contador++;
        return contador; // devuelve el número de vocales
    }

    // -------- PROCEDIMIENTO --------
    // Muestra la cantidad de vocales en consola (sin retorno)
    static void MostrarVocales(string texto)
    {
        int cantidad = ContarVocales(texto); // llama a la función
        Console.WriteLine($"La cantidad de vocales es: {cantidad}");
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string entrada = Console.ReadLine();

        // Opción 1: Usar la función directamente
        int cantidad = ContarVocales(entrada);
        Console.WriteLine($"[Función] La cantidad de vocales es: {cantidad}");

        // Opción 2: Usar el procedimiento (que internamente llama a la función)
        MostrarVocales(entrada);

        Console.WriteLine("Programa finalizado.");
    }
}
