using System;

namespace Marian
{
    public static class Evaluacion1_SistemaInventario
    {
        // Variable global para el total de productos
        private static int totalProductos = 0;

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 1: SISTEMA DE INVENTARIO ===");
            Console.WriteLine($"Total de productos en inventario: {totalProductos}");
            
            Console.WriteLine("\n1. Agregar productos");
            Console.WriteLine("2. Retirar productos");
            Console.WriteLine("3. Consultar inventario");
            Console.Write("Seleccione una opción: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion)
            {
                case 1:
                    AgregarProductos();
                    break;
                case 2:
                    RetirarProductos();
                    break;
                case 3:
                    ConsultarInventario();
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

        private static void AgregarProductos()
        {
            int cantidad;
            Console.Write("Cantidad de productos a agregar: ");
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Ingrese una cantidad válida: ");
            }
            
            totalProductos += cantidad;
            Console.WriteLine($"Se agregaron {cantidad} productos. Total: {totalProductos}");
        }

        private static void RetirarProductos()
        {
            int cantidad;
            Console.Write("Cantidad de productos a retirar: ");
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Ingrese una cantidad válida: ");
            }
            
            if (cantidad <= totalProductos)
            {
                totalProductos -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad} productos. Total: {totalProductos}");
            }
            else
            {
                Console.WriteLine("No hay suficientes productos en inventario.");
            }
        }

        private static void ConsultarInventario()
        {
            Console.WriteLine($"Inventario actual: {totalProductos} productos");
        }
    }
}
