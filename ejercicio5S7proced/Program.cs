// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // -------- PROCEDIMIENTO (sin retorno) --------
    static void ContarVocales(string texto)
    {
        int contador = 0; // inicializa contador
        string vocales = "aeiouAEIOU"; // define las vocales a buscar
        foreach (char c in texto) // recorre cada caracter
        {
            if (vocales.Contains(c)) // si es vocal
            {
                contador++; // incrementa contador
            }
        }
        // Muestra el resultado directamente
        Console.WriteLine($"La cantidad de vocales es: {contador}");
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string entrada = Console.ReadLine();

        // Llamada al procedimiento
        ContarVocales(entrada);

        Console.WriteLine("Programa finalizado.");
    }
}
