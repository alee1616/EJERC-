using System;

namespace Marian
{
    public static class Evaluacion2_CajeroAutomatico
    {
        // Variable global para el saldo de la cuenta
        private static double saldoCuenta = 1000.0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 2: CAJERO AUTOMÁTICO ===");
            Console.WriteLine($"Saldo actual: ${saldoCuenta:F2}");
            
            Console.WriteLine("\n1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.Write("Seleccione una opción: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion)
            {
                case 1:
                    DepositarDinero();
                    break;
                case 2:
                    RetirarDinero();
                    break;
                case 3:
                    ConsultarSaldo();
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

        private static void DepositarDinero()
        {
            double cantidad;
            Console.Write("Cantidad a depositar: $");
            while (!double.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Ingrese una cantidad válida: $");
            }
            
            saldoCuenta += cantidad;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${saldoCuenta:F2}");
        }

        private static void RetirarDinero()
        {
            double cantidad;
            Console.Write("Cantidad a retirar: $");
            while (!double.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Ingrese una cantidad válida: $");
            }
            
            if (cantidad <= saldoCuenta)
            {
                saldoCuenta -= cantidad;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${saldoCuenta:F2}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        private static void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo actual: ${saldoCuenta:F2}");
        }
    }
}
