using System;

namespace Marian
{
    public static class Evaluacion5_CalculadoraCientifica
    {
        // Variable global para el último resultado
        private static double ultimoResultado = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 5: CALCULADORA CIENTÍFICA ===");
            Console.WriteLine($"Último resultado: {ultimoResultado}");
            
            Console.WriteLine("\n1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.Write("Seleccione una operación: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion)
            {
                case 1:
                    RealizarSuma();
                    break;
                case 2:
                    RealizarResta();
                    break;
                case 3:
                    RealizarMultiplicacion();
                    break;
                case 4:
                    RealizarDivision();
                    break;
                case 5:
                    RealizarPotencia();
                    break;
                case 6:
                    RealizarRaizCuadrada();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        private static int LeerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        private static void RealizarSuma()
        {
            double num1, num2;
            Console.Write("Primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            Console.Write("Segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            ultimoResultado = num1 + num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarResta()
        {
            double num1, num2;
            Console.Write("Primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            Console.Write("Segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            ultimoResultado = num1 - num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarMultiplicacion()
        {
            double num1, num2;
            Console.Write("Primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            Console.Write("Segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            ultimoResultado = num1 * num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarDivision()
        {
            double num1, num2;
            Console.Write("Primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            Console.Write("Segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.Write("Ingrese un número válido (diferente de 0): ");
            }
            
            ultimoResultado = num1 / num2;
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarPotencia()
        {
            double baseNum, exponente;
            Console.Write("Base: ");
            while (!double.TryParse(Console.ReadLine(), out baseNum))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            Console.Write("Exponente: ");
            while (!double.TryParse(Console.ReadLine(), out exponente))
            {
                Console.Write("Ingrese un número válido: ");
            }
            
            ultimoResultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }

        private static void RealizarRaizCuadrada()
        {
            double numero;
            Console.Write("Número: ");
            while (!double.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Ingrese un número válido (mayor o igual a 0): ");
            }
            
            ultimoResultado = Math.Sqrt(numero);
            Console.WriteLine($"Resultado: {ultimoResultado}");
        }
    }
}
