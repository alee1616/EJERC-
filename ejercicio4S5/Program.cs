// See https://aka.ms/new-console-template for more information
﻿using System;  // Necesario para usar Console
using System.Collections.Generic; // Necesario para usar List<T>

namespace BibliotecaEstructurada // Namespace para organizar el código
{
    // Clase Libro -> representa un libro en la biblioteca
    class Libro
    {
        public string Titulo { get; set; } //aca a string le ponemos public para que se pueda acceder desde otras clases 
                                           //y el {get; set;} es para definir una propiedad automática
        public string Autor { get; set; } // get (leer) y set (modificar) permiten controlar 
        //cómo se accede y modifica un valor privado de una clase.
    }   // usamos eso porque esas propiedades permiten agregar reglas, 
        // como evitar valores negativos, registrar cambios, etc.

    class Program // Clase principal del programa
    {
        // Lista global de libros disponibles en la biblioteca
        static List<Libro> biblioteca = new List<Libro>(); // static para que sea accesible desde Main y otros métodos
                                                           //con la clase del libro como tipo de dato el new se le pone a la lista para inicializarla y que no de error
                                                           // Punto de entrada del programa
        static void Main(string[] args) // el string[] args es para recibir argumentos desde la línea de comandos
        {
            // Bucle principal del programa
            int opcion;
            do // Bucle para mostrar el menú y procesar opciones
            {
                MostrarMenu(); // Procedimiento para mostrar opciones
                opcion = LeerOpcion(); // Función para leer y validar la opción elegida

                // Estructura de control para decidir la acción
                switch (opcion) // switch es una estructura de control que permite seleccionar 
                // entre múltiples opciones basadas en el valor de una variable (opcion)
                {
                    case 1:
                        RegistrarLibro(); // Procedimiento para registrar un libro
                        break;
                    case 2:
                        BuscarPorAutor(); // Procedimiento para buscar libros por autor
                        break;
                    case 3:
                        MostrarLibros(); // Procedimiento para mostrar el listado de títulos
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema... ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4); // Repite hasta que el usuario elija salir
            // El do-while asegura que el menú se muestre al menos una vez y luego se repita
            // hasta que la condición (opcion != 4) sea falsa, es decir, cuando el usuario elija la opción 4 para salir.
        }

        // -------------------- Procedimientos y Funciones --------------------

        // Procedimiento que muestra el menú principal
        static void MostrarMenu() // static para que sea accesible desde Main
        {
            Console.WriteLine("\n=== Sistema de Gestión de Biblioteca ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Buscar por autor");
            Console.WriteLine("3. Mostrar listado de títulos disponibles");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }

        // Función que lee la opción ingresada y valida que sea un número
        static int LeerOpcion() //este int es porque devuelve un entero y con el mismo static para que sea accesible desde otros métodos
        {
            int opcion; // Variable para almacenar la opción
            bool valido = int.TryParse(Console.ReadLine(), out opcion); // Intenta convertir la entrada
            if (!valido) // usando el operador ! para negar la condición
            {
                opcion = -1; // Retorna un valor inválido para que el switch lo detecte
            }
            return opcion; // si no retorna la opción válida
        }

        // Procedimiento para registrar un libro en la lista
        static void RegistrarLibro()
        {
            Console.WriteLine("\n--- Registro de Libro ---");

            // Validar que el título no sea vacío
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(titulo)) // IsNullOrWhiteSpace verifica si la cadena es null, 
            //vacía o solo espacios en blanco para evitar entradas inválidas
            {
                Console.WriteLine("El título no puede estar vacío.");
                return; // Sale del procedimiento
            }

            // Validar que el autor no sea vacío
            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(autor))
            {
                Console.WriteLine("El autor no puede estar vacío.");
                return;
            }

            // Crear un objeto libro y agregarlo a la lista
            Libro nuevoLibro = new Libro { Titulo = titulo, Autor = autor };
            biblioteca.Add(nuevoLibro);

            Console.WriteLine("Libro registrado con éxito.");
        }

        // Procedimiento para buscar libros por autor
        static void BuscarPorAutor()
        {
            Console.WriteLine("\n--- Búsqueda por Autor ---");
            Console.Write("Ingrese el nombre del autor: ");
            string autor = Console.ReadLine();

            // Filtrar los libros de ese autor
            List<Libro> encontrados = biblioteca.FindAll(libro => libro.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
            // con el findall se puede buscar en la lista todos los libros que coincidan con el argumento
            // el StringComparison.OrdinalIgnoreCase es para que no distinga entre mayúsculas y minúsculas


            // Mostrar resultados
            if (encontrados.Count > 0)
            {
                Console.WriteLine($"\nLibros encontrados de {autor}:");
                foreach (var libro in encontrados)
                {
                    Console.WriteLine($"- {libro.Titulo}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron libros de ese autor.");
            }
        }

        // Procedimiento para mostrar todos los libros registrados
        static void MostrarLibros()
        {
            Console.WriteLine("\n--- Listado de Libros Disponibles ---");

            if (biblioteca.Count == 0)
            {
                Console.WriteLine("No hay libros registrados en la biblioteca.");
            }
            else
            {
                foreach (var libro in biblioteca)
                {
                    Console.WriteLine($"Título: {libro.Titulo} | Autor: {libro.Autor}");
                }
            }
        }
    }
}
