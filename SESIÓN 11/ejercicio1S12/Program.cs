using System;
using System.Collections.Generic;
using System.Linq; // Necesario para .Average(), .Count, .Sort(), y .Reverse()

// --- CAMBIO: Nombre del namespace ---
namespace GestorDeEnterosApp 
{
    // --- CAMBIO: Nombre de la clase ---
    internal class Aplicacion 
    {
        // --- CAMBIO: Nombre del método ---
        // Función para imprimir las opciones del menú
        static void ImprimirMenuOpciones()
        {
            // --- CAMBIO: Textos de consola ---
            Console.WriteLine("\n--- Gestor de Colección de Números ---");
            Console.WriteLine("1. Añadir número");
            Console.WriteLine("2. Quitar número");
            Console.WriteLine("3. Listar colección");
            Console.WriteLine("4. Ver promedio");
            Console.WriteLine("5. Ordenar (Menor a Mayor)");
            Console.WriteLine("6. Ordenar (Mayor a Menor)");
            Console.WriteLine("7. Salir");
            Console.Write("Digite su selección: ");
        }

        // --- CAMBIO: Nombre del método ---
        // Función para leer y validar la opción del usuario
        static int LeerOpcionUsuario()
        {
            // --- CAMBIO: Nombre de variable interna ---
            if (int.TryParse(Console.ReadLine(), out int opcionParseada))
            {
                return opcionParseada;
            }
            return 0; // Devuelve 0 si la entrada no es un entero
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para añadir un número a la colección
        static void AnadirNumero(List<int> listaNumeros)
        {
            Console.Write("Ingrese el valor entero a añadir: ");
            // --- CAMBIO: Nombre de variable interna ---
            if (int.TryParse(Console.ReadLine(), out int numeroNuevo))
            {
                listaNumeros.Add(numeroNuevo);
                Console.WriteLine($"Valor '{numeroNuevo}' añadido correctamente.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ser un número entero.");
            }
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para quitar un número de la colección
        static void QuitarNumero(List<int> listaNumeros)
        {
            Console.Write("Ingrese el valor entero a quitar: ");
            // --- CAMBIO: Nombre de variable interna ---
            if (int.TryParse(Console.ReadLine(), out int numeroAEliminar))
            {
                if (listaNumeros.Remove(numeroAEliminar))
                {
                    Console.WriteLine($"Valor '{numeroAEliminar}' quitado de la colección.");
                }
                else
                {
                    Console.WriteLine($"Valor '{numeroAEliminar}' no fue encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ser un número entero.");
            }
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para listar todos los números en la colección
        static void ListarNumeros(List<int> listaNumeros)
        {
            Console.WriteLine("\n--- Contenido de la Colección ---");
            if (listaNumeros.Count == 0)
            {
                Console.WriteLine("La colección está vacía.");
            }
            else
            {
                Console.WriteLine("Elementos actuales:");
                // --- CAMBIO: Nombre de variable de bucle ---
                foreach (var numero in listaNumeros)
                {
                    Console.WriteLine($"* {numero}");
                }
            }
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para obtener y mostrar el promedio de la colección
        static void ObtenerPromedio(List<int> listaNumeros)
        {
            Console.WriteLine("\n--- Cálculo de Promedio ---");
            if (listaNumeros.Count == 0)
            {
                Console.WriteLine("La colección está vacía. No hay promedio.");
            }
            else
            {
                // --- CAMBIO: Nombre de variable interna ---
                double resultadoPromedio = listaNumeros.Average();
                Console.WriteLine($"Total de elementos: {listaNumeros.Count}");
                Console.WriteLine($"El promedio es: {resultadoPromedio:F2}"); // :F2 para 2 decimales
            }
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para ordenar de menor a mayor
        static void OrdenarDeMenorAMayor(List<int> listaNumeros)
        {
            if (listaNumeros.Count == 0)
            {
                Console.WriteLine("Colección vacía, no se puede ordenar.");
                return;
            }
            listaNumeros.Sort();
            Console.WriteLine("Colección ordenada de menor a mayor.");
        }

        // --- CAMBIO: Nombre del método y parámetro ---
        // Función para ordenar de mayor a menor
        static void OrdenarDeMayorAMenor(List<int> listaNumeros)
        {
            if (listaNumeros.Count == 0)
            {
                Console.WriteLine("Colección vacía, no se puede ordenar.");
                return;
            }
            listaNumeros.Sort();
            listaNumeros.Reverse();
            Console.WriteLine("Colección ordenada de mayor a menor.");
        }

        // --- Funcion Principal (Main) ---
        static void Main(string[] args)
        {
            // --- CAMBIO: Nombre de la variable de lista ---
            List<int> numeros = new List<int>();
            // --- CAMBIO: Nombre de la variable de control del bucle ---
            bool ejecutando = true;

            while (ejecutando)
            {
                // --- CAMBIO: Llamadas a métodos renombrados ---
                ImprimirMenuOpciones();
                // --- CAMBIO: Nombre de variable ---
                int seleccionUsuario = LeerOpcionUsuario(); 

                switch (seleccionUsuario)
                {
                    case 1:
                        AnadirNumero(numeros); // Llamada al método renombrado
                        break;
                    case 2:
                        QuitarNumero(numeros); // Llamada al método renombrado
                        break;
                    case 3:
                        ListarNumeros(numeros); // Llamada al método renombrado
                        break;
                    case 4:
                        ObtenerPromedio(numeros); // Llamada al método renombrado
                        break;
                    case 5:
                        OrdenarDeMenorAMayor(numeros); // Llamada al método renombrado
                        break;
                    case 6:
                        OrdenarDeMayorAMenor(numeros); // Llamada al método renombrado
                        break;
                    case 7:
                        ejecutando = false;
                        Console.WriteLine("Finalizando la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Selección incorrecta. Por favor, intente de nuevo.");
                        break;
                }
            }
        }
    }
}