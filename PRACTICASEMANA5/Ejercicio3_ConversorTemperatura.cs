using System;

namespace Marian
{
    public static class Ejercicio3_ConversorTemperatura
    {
        // Variable global para la escala de conversión
        private static string escalaConversion = "Celsius a Fahrenheit";

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 3: CONVERSOR DE TEMPERATURA ===");
            Console.WriteLine($"Escala de conversión actual: {escalaConversion}");
            
            double temperatura;
            Console.Write("Ingrese la temperatura: ");
            while (!double.TryParse(Console.ReadLine(), out temperatura))
            {
                Console.Write("Ingrese un valor válido: ");
            }
            
            ConvertirTemperatura(temperatura);
        }

        private static void ConvertirTemperatura(double temp)
        {
            double resultado;
            if (escalaConversion == "Celsius a Fahrenheit")
            {
                resultado = (temp * 9.0 / 5.0) + 32;
                Console.WriteLine($"{temp}°C = {resultado}°F");
            }
            else
            {
                resultado = (temp - 32) * 5.0 / 9.0;
                Console.WriteLine($"{temp}°F = {resultado}°C");
            }
        }
    }
}
