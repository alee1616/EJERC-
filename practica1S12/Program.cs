using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos e inicializamos la lista de cadenas.
            List<string> lista = new List<string>();
            bool continuar = true;

            Console.WriteLine("--- Programa de Gestión de Lista (C#) ---");

            while (continuar)
            {
                // Menú de opciones
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Eliminar elemento");
                Console.WriteLine("3. Mostrar elementos (opcional, para verificar)");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine("----------------");

                switch (opcion)
                {
                    // Caso 1: Agregar elemento
                    case "1":
                        Console.Write("Ingrese el elemento a agregar: ");
                        string elementoAgregar = Console.ReadLine();

                        // Usamos el método Add() para insertar el elemento.
                        lista.Add(elementoAgregar);
                        Console.WriteLine($"'{elementoAgregar}' agregado a la lista.");
                        break;

                    // Caso 2: Eliminar elemento
                    case "2":
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía. No hay elementos para eliminar.");
                            break;
                        }

                        Console.Write("Ingrese el elemento a eliminar: ");
                        string elementoEliminar = Console.ReadLine();

                        // Usamos el método Remove(). Devuelve 'true' si lo elimina.
                        bool eliminado = lista.Remove(elementoEliminar);

                        if (eliminado)
                        {
                            Console.WriteLine($"'{elementoEliminar}' ha sido eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"'{elementoEliminar}' no se encontró en la lista.");
                        }
                        break;

                    // Caso 3: Mostrar elementos
                    case "3":
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            Console.WriteLine("Elementos en la Lista:");
                            // Usamos un bucle foreach para recorrer e imprimir cada elemento.
                            foreach (var item in lista)
                            {
                                Console.WriteLine($"- {item}");
                            }
                        }
                        break;

                    // Caso 4: Salir
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    // Opción por defecto para entradas no válidas
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}

// Los nodos estan conformados por dos partes; el dato y la referencia al siguiente nodo.
// La lista enlazada simple permite almacenar elementos de manera dinámica,
// facilitando inserciones y eliminaciones sin necesidad de reestructurar toda la lista.    
// Esto la hace ideal para aplicaciones donde la cantidad de datos puede variar frecuentemente.