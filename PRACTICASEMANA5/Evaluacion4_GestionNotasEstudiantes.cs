using System;
using System.Collections.Generic;
using System.Linq;

namespace Marian
{
    public static class Evaluacion4_GestionNotasEstudiantes
    {
        // Lista global para almacenar las notas
        private static List<double> notasEstudiantes = new List<double>();

        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 4: GESTIÓN DE NOTAS DE ESTUDIANTES ===");
            
            Console.WriteLine("\n1. Agregar nota");
            Console.WriteLine("2. Calcular promedio");
            Console.WriteLine("3. Mostrar nota más alta y más baja");
            Console.WriteLine("4. Mostrar todas las notas");
            Console.Write("Seleccione una opción: ");
            
            int opcion = LeerOpcion();
            
            switch (opcion)
            {
                case 1:
                    AgregarNota();
                    break;
                case 2:
                    CalcularPromedioNotas();
                    break;
                case 3:
                    MostrarNotasExtremas();
                    break;
                case 4:
                    MostrarTodasLasNotas();
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

        private static void AgregarNota()
        {
            double nota;
            Console.Write("Ingrese la nota (0-10): ");
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Ingrese una nota válida (0-10): ");
            }
            
            notasEstudiantes.Add(nota);
            Console.WriteLine($"Nota {nota} agregada. Total de notas: {notasEstudiantes.Count}");
        }

        private static void CalcularPromedioNotas()
        {
            if (notasEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return;
            }
            
            // Variables locales
            double suma = 0;
            foreach (double nota in notasEstudiantes)
            {
                suma += nota;
            }
            
            double promedio = suma / notasEstudiantes.Count;
            Console.WriteLine($"Promedio de notas: {promedio:F2}");
        }

        private static void MostrarNotasExtremas()
        {
            if (notasEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return;
            }
            
            // Variables locales
            double notaMasAlta = notasEstudiantes.Max();
            double notaMasBaja = notasEstudiantes.Min();
            
            Console.WriteLine($"Nota más alta: {notaMasAlta}");
            Console.WriteLine($"Nota más baja: {notaMasBaja}");
        }

        private static void MostrarTodasLasNotas()
        {
            if (notasEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return;
            }
            
            Console.WriteLine("Todas las notas:");
            for (int i = 0; i < notasEstudiantes.Count; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notasEstudiantes[i]}");
            }
        }
    }
}
