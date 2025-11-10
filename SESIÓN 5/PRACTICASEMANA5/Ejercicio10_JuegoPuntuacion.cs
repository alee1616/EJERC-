using System;

namespace Marian
{
    public static class Ejercicio10_JuegoPuntuacion
    {
        // Variable global para la puntuación
        private static int puntuacion = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 10: JUEGO DE PUNTUACIÓN ===");
            Console.WriteLine($"Puntuación actual: {puntuacion}");
            
            GanarPuntos();
        }

        private static void GanarPuntos()
        {
            puntuacion += 10;
            Console.WriteLine($"¡Puntos ganados! Nueva puntuación: {puntuacion}");
        }
    }
}
