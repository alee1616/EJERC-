// See https://aka.ms/new-console-template for more information
using System;
//Excepciones objetivo: FormatException y OverflowException
//Contexto: En una ferretería (PVC conduit SCH40, accesorios), el cajero ingresa cantidades y precios desde teclado.
//Problema real: Se pueden ingresar textos no numéricos o números fuera de rango.
//Tareas
//Pida cantidad (int) y precioUnitario (decimal).
//Calcule 
//subtotal = cantidad * precioUnitario, 
//iva = 0.15m * subtotal, 
//total = subtotal + iva.
//Capture formato inválido y desbordes con mensajes útiles.
//Entradas de ejemplo
//cantidad: "diez“
//precioUnitario: "199.99“
//Resultado esperado: “Entrada inválida. Use solo números (ej. 10).”

class Ferreteria// Calculo de IVA
{
    static void Main() // Punto de entrada del programa
    {
        try // Bloque para capturar posibles errores de conversión using System; 
            // Si el usuario ingresa algo que no se puede convertir a número, se maneja la excepción
            //try-catch: Se usa para capturar errores y evitar que el programa falle.

        {
            // Solicitar al usuario la cantidad de artículos
            Console.Write("  >>>> Ingrese la cantidad de artículos:   ");
            string cantidadInput = Console.ReadLine(); // Guardamos lo que el usuario escribió como texto

            // Convertimos el texto a un número entero usando Convert.ToInt32
            // Si el usuario escribe algo no numérico, lanzará FormatException
            // Si el número es demasiado grande para int, lanzará OverflowException
            int cantidad = Convert.ToInt32(cantidadInput);

            // Solicitar al usuario el precio unitario de cada artículo
            Console.Write(" >>>>Ingrese el precio unitario: <<<<");
            string precioInput = Console.ReadLine(); // Guardamos el texto ingresado

            // Convertimos el texto a decimal usando Convert.ToDecimal
            // FormatException si no es número, OverflowException si es demasiado grande
            decimal precioUnitario = Convert.ToDecimal(precioInput);

            // Calculamos el subtotal multiplicando cantidad por precio unitario
            decimal subtotal = cantidad * precioUnitario;

            // Calculamos el IVA (15% del subtotal)
            decimal iva = subtotal * 0.15m; // 'm' indica que es decimal

            // Calculamos el total sumando subtotal + IVA
            decimal total = subtotal + iva;

            // Mostramos los resultados formateados con 2 decimales
            Console.WriteLine($"\n /// Subtotal: C${subtotal:F2}"); // F2 formatea a 2 decimales
            Console.WriteLine($" ///IVA (15%): C${iva:F2}");
            Console.WriteLine($" ///Total a pagar: C${total:F2}");
        }
        // Capturamos errores de formato: el usuario ingresó letras o símbolos en lugar de números
        catch (FormatException) // Si el usuario ingresa algo que no se puede convertir a número
        // Ejemplo: "diez" o "12,34.56", el formatException es para errores de formato
        {
            Console.WriteLine(" **** Entrada inválida. Use solo números (ej. 10 o 199.99).*** \n      **Intente de nuevo.** ");
        }
        // Capturamos errores de desbordamiento: el número es demasiado grande o pequeño para el tipo
        catch (OverflowException) // Si el número es demasiado grande o pequeño para int o decimal
        // Ejemplo: ingresar 9999999999999999999999999
        {
            Console.WriteLine("Número demasiado grande o pequeño. Intente un valor razonable.");
        }
    }
}
// Fin del programa