using System;
using System.Collections.Generic;
using System.Linq;

// *****************************************************************************
// Descripción del Programa: Administración de Catálogo de Software Universitario
// *****************************************************************************
/* * Representa un registro de software en el catálogo.
 * Es esencial definir esta estructura para que nuestra lista pueda almacenar
 * elementos con la información necesaria (Id, Nombre, Versión).
 * * El elemento que decidimos usar para el programa fue las listas,
 * Dado que el problema de gestión de un catálogo (agregar, buscar,
 * eliminar por valor) se adapta perfectamente a la naturaleza flexible
 * de la Lista, opté por esa estructura como la más eficiente y directa
 * para la solución
 */

public class ProgramaSoftware
{
    // ... (Clase ProgramaSoftware sin cambios)
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Version { get; set; }

    public ProgramaSoftware(int id, string nombre, string version)
    {
        Id = id;
        Nombre = nombre;
        Version = version;
    }

    public override string ToString()
    {
        return $"[ID: {Id}] Nombre: {Nombre}, Versión: {Version}";
    }
}

// ******************************
// Clase Principal del Programa
// ******************************
public class CatalogoSoftwareApp
{
    private List<ProgramaSoftware> catalogo;
    private int proximoId = 1;

    public CatalogoSoftwareApp()
    {
        catalogo = new List<ProgramaSoftware>();
        // Datos iniciales
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2022"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "SQL Server", "2019"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "AutoCAD", "2024"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Microsoft Office", "365"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2019"));
    }

    // ********************************
    // Métodos de Gestión del Catálogo
    // ********************************

    private void AgregarPrograma(ProgramaSoftware programa)
    {
        catalogo.Add(programa);
    }
    
    // ... (Métodos BuscarSoftwarePorNombre, EliminarPorId, MostrarCatalogoCompleto sin cambios relevantes)
    private List<ProgramaSoftware> BuscarSoftwarePorNombre(string nombreBusqueda)
    {
        return catalogo
            .Where(p => p.Nombre.ToLower().Contains(nombreBusqueda.ToLower()))
            .ToList();
    }
    
    private bool EliminarPorId(int id)
    {
        var programaAEliminar = catalogo.Find(p => p.Id == id);
        if (programaAEliminar != null)
        {
            return catalogo.Remove(programaAEliminar);
        }
        return false;
    }

    public void MostrarCatalogoCompleto()
    {
        if (catalogo.Count == 0)
        {
            Console.WriteLine("El catálogo está vacío. Es hora de agregar software");
            return;
        }

        Console.WriteLine("\n--- Catálogo de Software Completo ---");
        foreach (var programa in catalogo)
        {
            Console.WriteLine(programa);
        }
        Console.WriteLine("------------------------------------\n");
    }

    // *********************************************************
    // Métodos de Interfaz de Usuario (Menú y Lógica de Entrada)
    // *********************************************************

    public void MostrarMenu()
    {
        Console.WriteLine("\n--- Administración del Catálogo de Software ---");
        Console.WriteLine("1. Agregar nuevo Software ");
        Console.WriteLine("2. Eliminar Software obsoleto (por ID) ");
        Console.WriteLine("3. Buscar Software por Nombre ");
        Console.WriteLine("4. Mostrar Catálogo Completo ");
        Console.WriteLine("5. Salir ");
        Console.Write("Seleccione una opción: ");
    }

    private void EjecutarAgregarSoftware()
    {
        Console.WriteLine("\n--- Agregar Nuevo Software ---");
        Console.Write("Nombre del Software (ej: AutoCAD): ");
        // Uso de '?? ""' para asegurar que 'nombre' no es null, eliminando la advertencia.
        string nombre = Console.ReadLine() ?? ""; 
        Console.Write("Versión (ej: 2024): ");
        // Uso de '?? ""' para asegurar que 'version' no es null, eliminando la advertencia.
        string version = Console.ReadLine() ?? "";

        // El ID se gestiona automáticamente para evitar duplicados y errores del usuario.
        var nuevoPrograma = new ProgramaSoftware(proximoId++, nombre, version);
        AgregarPrograma(nuevoPrograma);

        Console.WriteLine($" ¡Software '{nombre} v{version}' (ID: {nuevoPrograma.Id}) agregado con éxito!");
    }

    private void EjecutarEliminarSoftware()
    {
        MostrarCatalogoCompleto();
        Console.Write("Ingrese el ID del software obsoleto a ELIMINAR: ");
        // Aquí no hay advertencia porque int.TryParse maneja correctamente el valor nulo o la cadena vacía.
        if (int.TryParse(Console.ReadLine(), out int idAEliminar))
        {
            if (EliminarPorId(idAEliminar))
            {
                Console.WriteLine($" ¡Software con ID {idAEliminar} eliminado del catálogo!");
            }
            else
            {
                Console.WriteLine($" Error: No se encontró ningún software con el ID {idAEliminar}.");
            }
        }
        else
        {
            Console.WriteLine(" Entrada inválida. Por favor, ingrese un número para el ID.");
        }
    }

    private void EjecutarBuscarSoftware()
    {
        Console.Write("Ingrese el nombre (o parte del nombre) del software a buscar: ");
        // Uso de '?? ""' para asegurar que 'termino' no es null, eliminando la advertencia.
        string termino = Console.ReadLine() ?? "";

        var resultados = BuscarSoftwarePorNombre(termino);

        if (resultados.Any()) 
        {
            Console.WriteLine($"\n--- Resultados de la búsqueda para '{termino}' ({resultados.Count} encontrados) ---");
            foreach (var programa in resultados)
            {
                Console.WriteLine(programa);
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }
        else
        {
            Console.WriteLine($"\n No se encontró software que coincida con '{termino}'.");
        }
    }

    public void Ejecutar()
    {
        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            // Uso de '?? ""' para asegurar que 'opcion' no es null, eliminando la advertencia.
            string opcion = Console.ReadLine() ?? ""; 

            // Intentamos convertir la entrada a entero para usarla en el switch.
            if (int.TryParse(opcion, out int opcionElegida))
            {
                switch (opcionElegida)
                {
                    case 1:
                        EjecutarAgregarSoftware();
                        break;
                    case 2:
                        EjecutarEliminarSoftware();
                        break;
                    case 3:
                        EjecutarBuscarSoftware();
                        break;
                    case 4:
                        MostrarCatalogoCompleto();
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por usar el Administrador de Catálogo! ¡Adiós!");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese el número de la opción.");
            }
            
            if (continuar)
            {
                Console.WriteLine("\nPresione ENTER para continuar...");
                // Aquí también aseguramos que la lectura no sea nula.
                Console.ReadLine(); 
            }
        }
    }
    
    public static void Main(string[] args)
    {
        var app = new CatalogoSoftwareApp();
        app.Ejecutar();
    }
}