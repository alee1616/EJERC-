// See https://aka.ms/new-console-template for more information
// Descripción: Programa que calcula el IVA para una ferretería
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

using System;

// Descripción: Programa que calcula el IVA para una ferretería

using System;

class Ferreteria // Calculo de IVA
{
    static void Main() // Punto de entrada del programa
    {
        int cantidad = 0; // Variable para la cantidad de artículos
        decimal precioUnitario = 0; // Variable para el precio unitario

        // Validar cantidad
        while (true)
        {
            Console.Write(" >>>> Ingrese la cantidad de artículos: "); // Muestra mensaje
            string cantidadInput = Console.ReadLine() ?? ""; // Lee la entrada del usuario, nunca será null
            try
            {
                cantidad = Convert.ToInt32(cantidadInput); // Convierte la entrada a entero
                if (cantidad <= 0)
                {
                    Console.WriteLine("La cantidad debe ser mayor que cero. Intente de nuevo.\n");
                    continue; // Repite el bucle
                }
                break; // Entrada válida, sale del bucle
            }
            catch (FormatException)
            {
                Console.WriteLine(" **** Entrada inválida. Use solo números enteros (ej. 10).*** \n *Intente de nuevo.* ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande o pequeño. Intente un valor razonable.\n");
            }
        }

        // Validar precio unitario, similarm    al bloque anterior
        while (true) // Bucle infinito para validar el precio unitario y también manejar excepciones
                     // Se repetirá hasta que el usuario ingrese un valor válido
                     // Este bucle permite pedir el precio unitario varias veces si la entrada es inválida
                     // hasta que se encuentra una instrucción que lo detenga, como break. 
        {
            Console.Write(" >>>>Ingrese el precio unitario: <<<<"); // Muestra mensaje
            string precioInput = Console.ReadLine() ?? ""; // Lee la entrada del usuario, nunca será null
            try // Intenta convertir la entrada a decimal y validar que sea positiva
            {
                precioUnitario = Convert.ToDecimal(precioInput); // Convierte la entrada a decimal
                if (precioUnitario <= 0) // Verifica que el precio sea positivo y mayor que cero
                {
                    Console.WriteLine("El precio unitario debe ser mayor que cero. Intente de nuevo.\n");
                    continue; // Repite el bucle si la condición no se cumple.
                }
                break; // Entrada válida, sale del bucle
            }
            // Capturamos errores de formato: el texto no es un número válido
            catch (FormatException)// Si el usuario ingresa algo que no se puede convertir a número
        // Ejemplo: "diez" o "12,34.56", el formatException es para errores de formato
            {
                Console.WriteLine(" **** Entrada inválida. Use solo números (ej. 199.99).*** \n *Intente de nuevo.* ");
            }
            // Capturamos errores de desbordamiento: el número es demasiado grande o pequeño para el tipo
            catch (OverflowException) // Si el número es demasiado grande o pequeño para int o decimal
        // Ejemplo: ingresar 9999999999999999999999999 y el overflowException es para errores de rango.
            {
                Console.WriteLine("Número demasiado grande o pequeño. Intente un valor razonable.\n");
            }
        }

        // Calcular subtotal, IVA y total
        decimal subtotal = cantidad * precioUnitario; // Multiplica cantidad por precio
        decimal iva = subtotal * 0.15m; // Calcula el IVA (15%)
        decimal total = subtotal + iva; // Suma subtotal e IVA

        // Mostrar resultados formateados con dos decimales
        Console.WriteLine($"\n /// Subtotal: C${subtotal:F2}"); // Muestra el subtotal, formateado a 2 decimales
        Console.WriteLine($" ///IVA (15%): C${iva:F2}"); // Muestra el IVA
        Console.WriteLine($" ///Total a pagar: C${total:F2}"); // Muestra el total
    }
}