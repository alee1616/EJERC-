using System;

namespace Marian
{
    public static class Ejercicio9_PerimetroCirculo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 9: PERÍMETRO DE UN CÍRCULO ===");
            
            double radio;
            Console.Write("Ingrese el radio del círculo: ");
            while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
            {
                Console.Write("Ingrese un radio válido: ");
            }
            
            double perimetro = CalcularPerimetroCirculo(radio);
            Console.WriteLine($"El perímetro del círculo es: {perimetro:F2}");
        }

        private static double CalcularPerimetroCirculo(double radio)
        {
            // Variable local
            double pi = 3.14159;
            return 2 * pi * radio;
        }
    }
}
