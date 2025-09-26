using System;

namespace Marian
{
    public static class Evaluacion9_ValidacionFecha
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 9: VALIDACIÓN DE FECHA ===");
            
            int dia, mes, año;
            
            Console.Write("Ingrese el día: ");
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
            {
                Console.Write("Ingrese un día válido (1-31): ");
            }
            
            Console.Write("Ingrese el mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.Write("Ingrese un mes válido (1-12): ");
            }
            
            Console.Write("Ingrese el año: ");
            while (!int.TryParse(Console.ReadLine(), out año) || año < 1)
            {
                Console.Write("Ingrese un año válido: ");
            }
            
            if (EsFechaValida(dia, mes, año))
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{año} es válida.");
                if (EsBisiesto(año))
                {
                    Console.WriteLine($"El año {año} es bisiesto.");
                }
                else
                {
                    Console.WriteLine($"El año {año} no es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{año} no es válida.");
            }
        }

        private static bool EsFechaValida(int dia, int mes, int año)
        {
            return MesValido(mes) && DiaValido(dia, mes, año);
        }

        private static bool MesValido(int mes)
        {
            return mes >= 1 && mes <= 12;
        }

        private static bool DiaValido(int dia, int mes, int año)
        {
            if (dia < 1) return false;
            
            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            
            if (EsBisiesto(año) && mes == 2)
            {
                return dia <= 29;
            }
            
            return dia <= diasPorMes[mes - 1];
        }

        private static bool EsBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
    }
}
