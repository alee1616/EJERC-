using System;

namespace Marian
{
    public static class Ejercicio6_JuegoIntentos
    {
        // Variables globales para el juego
        private static int numeroSecreto = 0;
        private static int intentosAdivinanza = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 6: JUEGO DE INTENTOS ===");
            
            if (numeroSecreto == 0)
            {
                Random rand = new Random();
                numeroSecreto = rand.Next(1, 101);
                intentosAdivinanza = 0;
                Console.WriteLine("Se ha generado un número secreto entre 1 y 100.");
            }
            
            int intento;
            Console.Write("Adivine el número (1-100): ");
            while (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            intentosAdivinanza++;
            Console.WriteLine($"Intento #{intentosAdivinanza}");
            
            if (intento == numeroSecreto)
            {
                Console.WriteLine("¡Correcto! Ha adivinado el número.");
                numeroSecreto = 0; // Reset para nuevo juego
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El número es mayor.");
            }
            else
            {
                Console.WriteLine("El número es menor.");
            }
        }
    }
}
