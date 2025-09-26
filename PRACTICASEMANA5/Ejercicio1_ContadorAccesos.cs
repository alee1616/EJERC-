using System;

namespace Marian
{
    public static class Ejercicio1_ContadorAccesos
    {
        // Variable global para el contador de accesos
        private static int contadorAccesos = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EJERCICIO 1: CONTADOR DE ACCESOS GLOBAL ===");
            IncrementarContador();
        }

        private static void IncrementarContador()
        {
            contadorAccesos++;
            Console.WriteLine($"El método se ha ejecutado {contadorAccesos} veces.");
        }
    }
}
