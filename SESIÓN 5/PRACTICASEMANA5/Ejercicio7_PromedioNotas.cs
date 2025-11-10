using System;

namespace Marian
{
    public static class Ejercicio7_PromedioNotas
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 7: PROMEDIO DE NOTAS ===");
            
            // Variables locales
            double nota1, nota2, nota3, promedio;
            
            Console.Write("Ingrese la primera nota: ");
            while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 10)
            {
                Console.Write("Ingrese una nota válida (0-10): ");
            }
            
            Console.Write("Ingrese la segunda nota: ");
            while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 10)
            {
                Console.Write("Ingrese una nota válida (0-10): ");
            }
            
            Console.Write("Ingrese la tercera nota: ");
            while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 10)
            {
                Console.Write("Ingrese una nota válida (0-10): ");
            }
            
            promedio = (nota1 + nota2 + nota3) / 3.0;
            Console.WriteLine($"El promedio de las tres notas es: {promedio:F2}");
        }
    }
}
