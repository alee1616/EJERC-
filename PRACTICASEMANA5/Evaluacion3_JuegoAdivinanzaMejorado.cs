using System;

namespace Marian
{
    public static class Evaluacion3_JuegoAdivinanzaMejorado
    {
        // Variables globales para el juego
        private static int numeroSecreto = 0;
        private static int intentosAdivinanza = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 3: JUEGO DE ADIVINANZA MEJORADO ===");
            
            if (numeroSecreto == 0)
            {
                Random rand = new Random();
                numeroSecreto = rand.Next(1, 101);
                intentosAdivinanza = 0;
                Console.WriteLine("Nuevo juego iniciado. Número secreto generado.");
            }
            
            AdivinarNumero();
        }

        private static void AdivinarNumero()
        {
            int intento;
            Console.Write("Adivine el número (1-100): ");
            while (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            intentosAdivinanza++;
            VerificarIntento(intento);
        }

        private static void VerificarIntento(int intento)
        {
            Console.WriteLine($"Intento #{intentosAdivinanza}");
            
            if (intento == numeroSecreto)
            {
                Console.WriteLine($"¡Correcto! Adivinó en {intentosAdivinanza} intentos.");
                numeroSecreto = 0; // Reset
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
