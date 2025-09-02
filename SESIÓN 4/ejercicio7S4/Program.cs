// See https://aka.ms/new-console-template for more information
using System;

class FerreteriaVentas // Control de ventas en una ferretería 
{
    static void Main() // Punto de entrada del programa
    {
        // Variables para llevar el control
        int numeroProductos = 0;      // Contador de productos registrados
        int totalVentas = 0;          // Acumulador del total de ventas
        int totalProductosVendidos = 0; // Acumulador de la cantidad total de productos vendidos

        Console.WriteLine(" ////// Control de Ventas de la Ferretería //////"); // Título del programa

        while (true) // Bucle infinito para ingresar productos
        {
            Console.WriteLine(" >>>> Ingrese las cantidades del producto vendido"); // Instrucción para el usuario
            Console.WriteLine("          📌(Ingrese  un 0 para terminar):       "); // Instrucción para terminar
            int cantidad = Convert.ToInt32(Console.ReadLine()); // Leer la cantidad vendida

            if (cantidad == 0) // Condición para terminar el ingreso de productos
            {
                // Terminar ingreso de productos
                break; // Salir del bucle
            }

            Console.Write(" <<<< Ingrese el precio unitario del producto (C$ enteros): "); // Solicitar precio unitario
            int precio = Convert.ToInt32(Console.ReadLine()); // Leer el precio unitario

            int venta = cantidad * precio;           // Calcula la venta individual
            totalVentas += venta;                     // Suma al total de ventas
            totalProductosVendidos += cantidad;      // Suma al total de productos vendidos
            numeroProductos++;                        // Aumenta el contador de productos distintos

            // Verificar si supera C$10,000
            // Revisar si esta venta individual supera C$10,000
            if (venta > 10000)
            {
                System.Console.WriteLine("¡ALERTA! Esta venta individual supera C$10,000 (posible venta mayorista)."); // Mensaje de alerta
            }
            // Mostrar la venta registrada

            Console.WriteLine(">>> La venta fue registrada de: C$" + venta + "\n"); // Mostrar venta registrada
        }

        // Mostrar resultados finales
        Console.WriteLine("\n      ... Resumen del Día ..."); // Título del resumen
        Console.WriteLine("======================================="); // Separador
        Console.WriteLine("Total de productos vendidos: " + totalProductosVendidos);// Mostrar total de productos vendidos
        Console.WriteLine(">>> Número de productos registrados: " + numeroProductos);// Mostrar número de productos distintos
        Console.WriteLine(">>> Total de ventas: C$" + totalVentas);// Mostrar total de ventas

        
        Console.WriteLine("\n*** Gracias por usar el sistema de control de ventas.*** "); // Mensaje de despedida
    }
}
