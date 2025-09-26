using System;

namespace Marian
{
    public static class Ejercicio5_EdadPersona
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 5: EDAD DE UNA PERSONA ===");
            
            // Variables locales
            int añoNacimiento, añoActual, edad;
            
            añoActual = DateTime.Now.Year;
            
            Console.Write("Ingrese su año de nacimiento: ");
            while (!int.TryParse(Console.ReadLine(), out añoNacimiento) || añoNacimiento < 1900 || añoNacimiento > añoActual)
            {
                Console.Write("Ingrese un año válido: ");
            }
            
            edad = añoActual - añoNacimiento;
            Console.WriteLine($"Su edad es: {edad} años");
        }
    }
}
