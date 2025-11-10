using System;

namespace Marian
{
    public static class Ejercicio2_AreaRectangulo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 2: ÁREA DE UN RECTÁNGULO ===");
            
            // Variables locales
            double baseRectangulo, alturaRectangulo, area;
            
            Console.Write("Ingrese la base del rectángulo: ");
            while (!double.TryParse(Console.ReadLine(), out baseRectangulo) || baseRectangulo <= 0)
            {
                Console.Write("Ingrese un valor válido para la base: ");
            }
            
            Console.Write("Ingrese la altura del rectángulo: ");
            while (!double.TryParse(Console.ReadLine(), out alturaRectangulo) || alturaRectangulo <= 0)
            {
                Console.Write("Ingrese un valor válido para la altura: ");
            }
            
            area = baseRectangulo * alturaRectangulo;
            Console.WriteLine($"El área del rectángulo es: {area}");
        }
    }
}
