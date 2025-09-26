using System;

namespace Marian
{
    public static class Ejercicio4_SumaAcumulada
    {
        // Variable global para la suma acumulada
        private static double sumaTotal = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 4: SUMA ACUMULADA ===");
            Console.WriteLine($"Suma total actual: {sumaTotal}");
            
            double numero;
            Console.Write("Ingrese un número para sumar: ");
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Ingrese un valor válido: ");
            }
            
            sumaTotal += numero;
            Console.WriteLine($"Nueva suma total: {sumaTotal}");
        }
    }
}
