using System;
using System.Collections.Generic;

namespace Marian
{
    public static class Evaluacion6_SistemaRegistroUsuarios
    {
        // Lista global para almacenar usuarios registrados
        private static List<string> usuariosRegistrados = new List<string>();

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 6: SISTEMA DE REGISTRO DE USUARIOS ===");
            
            Console.WriteLine("\n1. Registrar nuevo usuario");
            Console.WriteLine("2. Validar si usuario existe");
            Console.WriteLine("3. Mostrar todos los usuarios");
            Console.Write("Seleccione una opción: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion)
            {
                case 1:
                    RegistrarUsuario();
                    break;
                case 2:
                    ValidarUsuario();
                    break;
                case 3:
                    MostrarUsuarios();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        private static int LeerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        private static void RegistrarUsuario()
        {
            string nombreUsuario;
            Console.Write("Nombre de usuario: ");
            nombreUsuario = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                Console.WriteLine("El nombre de usuario no puede estar vacío.");
                return;
            }
            
            if (usuariosRegistrados.Contains(nombreUsuario))
            {
                Console.WriteLine("El usuario ya existe.");
            }
            else
            {
                usuariosRegistrados.Add(nombreUsuario);
                Console.WriteLine($"Usuario '{nombreUsuario}' registrado exitosamente.");
            }
        }

        private static void ValidarUsuario()
        {
            string nombreUsuario;
            Console.Write("Nombre de usuario a validar: ");
            nombreUsuario = Console.ReadLine();
            
            if (usuariosRegistrados.Contains(nombreUsuario))
            {
                Console.WriteLine($"El usuario '{nombreUsuario}' existe en el sistema.");
            }
            else
            {
                Console.WriteLine($"El usuario '{nombreUsuario}' no existe en el sistema.");
            }
        }

        private static void MostrarUsuarios()
        {
            if (usuariosRegistrados.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                return;
            }
            
            Console.WriteLine("Usuarios registrados:");
            for (int i = 0; i < usuariosRegistrados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {usuariosRegistrados[i]}");
            }
        }
    }
}
