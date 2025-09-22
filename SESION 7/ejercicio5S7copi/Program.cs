// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función que cuenta las vocales en una cadena de texto usando referencia
    // Se usa 'ref' en el parámetro 'contador' para que la variable se modifique directamente
    // en el lugar donde se llama la función, no solo dentro de la función.
    static void ContarVocales(string texto, ref int contador)
    // La función no retorna nada (void), pero modifica el valor 
    // de 'contador' pasado por referencia
    // Esto permite que el valor original de 'contador' en Main cambie
    // sin necesidad de usar 'return'
    {
        string vocales = "aeiouAEIOU";
        // Cadena con todas las vocales (mayúsculas y minúsculas)
        contador = 0; // Inicializamos el contador en 0
        foreach (char c in texto)
        // Recorremos cada caracter de la cadena ingresada
        // 'c' es el caracter actual en la iteración
        {
            if (vocales.Contains(c))
            // Si el caracter es una vocal
            // Incrementamos el contador
            {
                contador++; // Sumamos 1 al contador
            }
        }
        // No se usa 'return', porque el resultado se guarda 
        // directamente en la variable pasada por referencia
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string entrada = Console.ReadLine();
        // Leemos la cadena ingresada por el usuario
        int cantidadVocales = 0;
        // Declaramos la variable que almacenará la cantidad de vocales
        // Al llamar la función, usamos 'ref' para indicar que la variable se pasa por referencia
        ContarVocales(entrada, ref cantidadVocales);
        // Ahora 'cantidadVocales' tiene el resultado porque fue modificada dentro de la función
        Console.WriteLine($"La cantidad de vocales es: {cantidadVocales}");
    }
}
//1.Agregar ref al parámetro
//Así indicas que la variable se pasa por referencia, no por valor.
//Esto permite que la función modifique directamente la variable original.

//2. Cambiar el tipo de retorno a void
//Ya no necesitas devolver el resultado, porque la variable se modifica dentro de la función.

//3. Inicializar la variable antes de llamar la función
//La variable que pasas por referencia debe existir antes de llamar la función.

//4. Usar ref también al llamar la función
//Es obligatorio para que C# sepa que quieres pasar la variable por referencia.

//¿Por qué se hace así?
//Cuando usas ref, los cambios hechos en la función afectan la variable original.
//Es útil si quieres modificar varias variables o evitar el uso de valores de retorno.