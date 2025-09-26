using System;

namespace Marian
{
    public static class Evaluacion10_NumeroCapicua
    {
        // Variable global para el número original
        private static int numeroOriginal = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 10: NÚMERO CAPICÚA ===");
            
            int numero;
            Console.Write("Ingrese un número entero positivo: ");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Ingrese un número entero positivo válido: ");
            }
            
            numeroOriginal = numero;
            
            if (EsCapicua(numero))
            {
                Console.WriteLine($"El número {numero} es capicúa.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es capicúa.");
            }
        }

        private static bool EsCapicua(int numero)
        {
            int numeroInvertido = InvertirNumero(numero);
            return numero == numeroInvertido;
        }

        private static int InvertirNumero(int numero)
        {
            int invertido = 0;
            while (numero > 0)
            {
                invertido = invertido * 10 + numero % 10;
                numero /= 10;
            }
            return invertido;
        }
    }
}
