using System;

namespace Marian
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            
            while (continuar)
            {
                MostrarMenu();
                int opcion = LeerOpcion();
                
                switch (opcion)
                {
                    // Ejercicios Básicos
                    case 1:
                        Ejercicio1_ContadorAccesos.Ejecutar();
                        break;
                    case 2:
                        Ejercicio2_AreaRectangulo.Ejecutar();
                        break;
                    case 3:
                        Ejercicio3_ConversorTemperatura.Ejecutar();
                        break;
                    case 4:
                        Ejercicio4_SumaAcumulada.Ejecutar();
                        break;
                    case 5:
                        Ejercicio5_EdadPersona.Ejecutar();
                        break;
                    case 6:
                        Ejercicio6_JuegoIntentos.Ejecutar();
                        break;
                    case 7:
                        Ejercicio7_PromedioNotas.Ejecutar();
                        break;
                    case 8:
                        Ejercicio8_ControlSesion.Ejecutar();
                        break;
                    case 9:
                        Ejercicio9_PerimetroCirculo.Ejecutar();
                        break;
                    case 10:
                        Ejercicio10_JuegoPuntuacion.Ejecutar();
                        break;
                    
                    // Ejercicios de Evaluación
                    case 11:
                        Evaluacion1_SistemaInventario.Ejecutar();
                        break;
                    case 12:
                        Evaluacion2_CajeroAutomatico.Ejecutar();
                        break;
                    case 13:
                        Evaluacion3_JuegoAdivinanzaMejorado.Ejecutar();
                        break;
                    case 14:
                        Evaluacion4_GestionNotasEstudiantes.Ejecutar();
                        break;
                    case 15:
                        Evaluacion5_CalculadoraCientifica.Ejecutar();
                        break;
                    case 16:
                        Evaluacion6_SistemaRegistroUsuarios.Ejecutar();
                        break;
                    case 17:
                        Evaluacion7_SimuladorTiendaLinea.Ejecutar();
                        break;
                    case 18:
                        Evaluacion8_ValidadorContraseñas.Ejecutar();
                        break;
                    case 19:
                        Evaluacion9_ValidacionFecha.Ejecutar();
                        break;
                    case 20:
                        Evaluacion10_NumeroCapicua.Ejecutar();
                        break;
                    case 0:
                        continuar = false;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                
                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ DE EJERCICIOS ===");
            Console.WriteLine("\n--- EJERCICIOS BÁSICOS ---");
            Console.WriteLine("1. Contador de accesos global");
            Console.WriteLine("2. Área de un rectángulo");
            Console.WriteLine("3. Conversor de temperatura");
            Console.WriteLine("4. Suma acumulada");
            Console.WriteLine("5. Edad de una persona");
            Console.WriteLine("6. Juego de intentos");
            Console.WriteLine("7. Promedio de notas");
            Console.WriteLine("8. Control de sesión");
            Console.WriteLine("9. Perímetro de un círculo");
            Console.WriteLine("10. Juego de puntuación");
            
            Console.WriteLine("\n--- EJERCICIOS DE EVALUACIÓN ---");
            Console.WriteLine("11. Sistema de Inventario");
            Console.WriteLine("12. Simulación de Cajero Automático");
            Console.WriteLine("13. Juego de Adivinanza Mejorado");
            Console.WriteLine("14. Gestión de Notas de Estudiantes");
            Console.WriteLine("15. Calculadora Científica Básica");
            Console.WriteLine("16. Sistema de Registro de Usuarios");
            Console.WriteLine("17. Simulador de Tienda en Línea");
            Console.WriteLine("18. Validador de contraseñas seguras");
            Console.WriteLine("19. Validación de fecha");
            Console.WriteLine("20. Número capicúa");
            
            Console.WriteLine("\n0. Salir");
            Console.Write("\nSeleccione una opción: ");
        }

        static int LeerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }
    }
}