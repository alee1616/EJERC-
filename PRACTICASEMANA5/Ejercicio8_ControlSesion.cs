using System;

namespace Marian
{
    public static class Ejercicio8_ControlSesion
    {
        // Variable global para el control de sesión
        private static bool sesionIniciada = false;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 8: CONTROL DE SESIÓN ===");
            Console.WriteLine($"Estado de sesión: {(sesionIniciada ? "Iniciada" : "No iniciada")}");
            
            if (!sesionIniciada)
            {
                string contraseña;
                Console.Write("Ingrese la contraseña: ");
                contraseña = Console.ReadLine();
                
                if (contraseña == "123456")
                {
                    sesionIniciada = true;
                    Console.WriteLine("¡Sesión iniciada correctamente!");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
            }
            else
            {
                Console.WriteLine("La sesión ya está iniciada.");
            }
        }
    }
}
