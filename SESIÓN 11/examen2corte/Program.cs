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

// Esta sección es para definir la clase ProgramaSoftware con sus propiedades y métodos.
// que serán utilizados para representar cada programa de software en el catálogo.
public class ProgramaSoftware //primeramente se define la clase ProgramaSoftware que representa un programa de software.
// Clase para representar un programa de software
//public significa que la clase es accesible desde cualquier parte del programa.
{
    // ... (Clase ProgramaSoftware sin cambios)
    // esta es la definición de las propiedades de la clase ProgramaSoftware
    public int Id { get; set; }
    // EL get y set se usan para acceder y modificar las propiedades del objeto
    //funcionan como métodos especiales que permiten obtener (get) y asignar (set) 
    //valores a las propiedades de un objeto.
    // En este caso, Id es una propiedad de la clase ProgramaSoftware que representa
    // el identificador único de cada programa de software.
    //Son las propiedades (atributos) de la clase. Id, Nombre y Version 
    // son los datos que tendrá cada programa de software.
    public string Nombre { get; set; }
    public string Version { get; set; }

    public ProgramaSoftware(int id, string nombre, string version)
    //esta es la funcion constructora que inicializa los objetos
    // de la clase ProgramaSoftware, 
    // asignando los valores proporcionados a las propiedades Id, Nombre y Version.
    // El constructor se llama automáticamente cuando se crea una nueva instancia de la clase.
    // Los parámetros id, nombre y version son los valores que se pasan al constructor
    // para inicializar las propiedades del objeto.
    // por ejemplo, al crear un nuevo ProgramaSoftware con
    // new ProgramaSoftware(1, "Visual Studio", "2022"),
    // se asignan 1 a Id, "Visual Studio" a Nombre y "2022" a Version.
    {
        Id = id;
        Nombre = nombre;
        Version = version;
    }

    public override string ToString()
    // el publico override indica que este método reemplaza
    // una implementación heredada de la clase base (en este caso, Object).
    //en simples palabras, ToString es un método especial que   
    // se utiliza para convertir un objeto en una cadena de texto, los cuales tienen Id, Nombre y Version.
    //sirve para devolver una representación en forma de cadena del objeto ProgramaSoftware.
    // Esto es útil para mostrar información legible sobre el objeto
    // cuando se imprime o se convierte a cadena.
    {
        return $"[ID: {Id}] Nombre: {Nombre}, Versión: {Version}";
        // el return devuelve la cadena formateada y finaliza el método.
        // el $ se dice como cadena interpolada,
        // La cadena utiliza interpolación ($"") para incluir
        // los valores de las propiedades Id, Nombre y Version  
        //La $" al inicio es para usar una cadena interpolada,
        //las variables como numeros o texto se pueden insertar directamente dentro de las llaves {}
        //insertando variables directamente dentro de las llaves {}

    }
}

// ******************************
// Clase Principal del Programa
// ******************************
public class CatalogoSoftwareApp // Clase principal que maneja el catálogo de software
{
    private List<ProgramaSoftware> catalogo;
    // Lista para almacenar los programas de software
    //Declara una variable de instancia privada. List<ProgramaSoftware> 
    // es una lista que solo puede contener objetos del tipo ProgramaSoftware. 
    // Esta lista es donde se almacena todo el catálogo.
    //esta lista contiene id, nombre y version de cada software.
    private int proximoId = 1;
    //Declara un contador para asignar un ID único y 
    // auto-incremental a cada nuevo software (entre comillas) que se agregue. Empieza en 1.

    public CatalogoSoftwareApp()
    //Es el constructor de la clase CatalogoSoftwareApp. 
    // Se ejecuta al iniciar la aplicación. Inicializa la lista catalogo
    // y precarga algunos datos de ejemplo llamando al método AgregarPrograma
    {
        catalogo = new List<ProgramaSoftware>();
        // Inicializa la lista vacía para almacenar los programas de software

        // Datos iniciales
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2022")); 
        // proximoId++ usa el valor actual y luego lo incrementa en 1
        AgregarPrograma(new ProgramaSoftware(proximoId++, "SQL Server", "2019"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "AutoCAD", "2024"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Microsoft Office", "365"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2019"));
    }

    // ********************************
    // Métodos de Gestión del Catálogo
    // ********************************

    private void AgregarPrograma(ProgramaSoftware programa)
    // El private void indica que este método no devuelve ningún valor
    // y solo es accesible dentro de la clase CatalogoSoftwareApp.
    //Crea nuevas instancias de ProgramaSoftware y las agrega a la lista catalogo. 
    // el ProgramaSoftware programa es el parámetro que recibe el método,
    //representando el programa que se va a agregar al catálogo.
    {
        catalogo.Add(programa); // Agrega el programa a la lista del catálogo y finaliza el método.
    }

    // ... (Métodos BuscarSoftwarePorNombre, EliminarPorId, MostrarCatalogoCompleto sin cambios relevantes)
    private List<ProgramaSoftware> BuscarSoftwarePorNombre(string nombreBusqueda)
    // Método para buscar programas por nombre (o parte del nombre), en caso de que no se encuentre nada
    // devuelve una lista vacía.
    {
        return catalogo // return devuelve el resultado de la búsqueda y finaliza el método.
            .Where(p => p.Nombre.ToLower().Contains(nombreBusqueda.ToLower()))
            // where Filtra los programas cuyo nombre contiene el término de búsqueda (sin distinguir mayúsculas/minúsculas)
            //la p=> es una expresión lambda que representa una función anónima. y se lee como "para cada programa p"
            // p representa cada programa en la lista catalogo.
            // ToLower() convierte ambos nombres a minúsculas para una comparación insensible a mayúsculas.
            // Contains verifica si el nombre del programa incluye el término de búsqueda.
            // El método Where devuelve una colección de programas que cumplen con el criterio de búsqueda.
            
            .ToList();
        // Finalmente, ToList() convierte esa colección filtrada en una lista.

    }

    private bool EliminarPorId(int id)
    //private bool indica que este método devuelve un valor booleano (true o false),
    //lo que indica si la eliminación fue exitosa o no.
    // Método para eliminar un programa por su ID. 
    // Devuelve true si se eliminó, false si no se encontró.
    // en simples palabras, este método busca un programa por su ID y lo elimina si lo encuentra.
    {
        var programaAEliminar = catalogo.Find(p => p.Id == id);
        // Busca el programa con el ID especificado
        //var es una palabra clave que permite al compilador inferir el tipo de la variable lo que significa que
        // programaAEliminar tomará el tipo del valor devuelto por catalogo.Find(...)
        // Find busca el primer elemento que cumple con la condición dada.
        //por ejemplo, si id es 3, busca el programa cuyo Id sea 3.
        
        if (programaAEliminar != null)
        //if lo usamos en este caso para verificar si se encontró un programa con el ID dado.
        // Si se encontró el programa, lo elimina y devuelve true
        // != significa "no es igual a"
        // null representa la ausencia de un valor o referencia.
        // Si programaAEliminar no es null, significa que se encontró un programa con el ID dado.
        {
            return catalogo.Remove(programaAEliminar);
            // Elimina el programa y devuelve true si tuvo éxito
            // Remove elimina el elemento especificado de la lista.
            // Si la eliminación es exitosa, devuelve true.
            //remove devuelve un valor booleano que indica si el elemento fue encontrado y eliminado con éxito.
        }
        return false; // Si no se encontró el programa, devuelve false
    }

    public void MostrarCatalogoCompleto() // Método para mostrar todo el catálogo de software
    {
        if (catalogo.Count == 0) 
        // Verifica si el catálogo está vacío
        // el catalogo.Count devuelve el número de elementos en la lista catalogo.
        // Si es 0, significa que no hay programas en el catálogo.
        // Si el catálogo está vacío, muestra un mensaje y finaliza el método.
        // el == 0 verifica si el número de elementos es igual a 0.
        {
            Console.WriteLine("El catálogo está vacío. Es hora de agregar software");
            return;
            // Finaliza el método si el catálogo está vacío.
            //en este caso no hay catálogo vacío, por lo que no se ejecuta el return.
        }

        Console.WriteLine("\n--- Catálogo de Software Completo ---");
        foreach (var programa in catalogo)
        //El forech recorre cada programa en la lista catalogo, significa "para cada"
        //var es una palabra clave que permite al compilador inferir el tipo de la variablek 
        // en este caso, programa va a representar cada objeto ProgramaSoftware en la lista.
        {
            Console.WriteLine(programa); // Muestra la información del programa usando el método ToString()
            // Al pasar el objeto programa a Console.WriteLine,
        }
        Console.WriteLine("------------------------------------\n"); // Línea de separación para mejor legibilidad
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

//se usaron 3 clases que fueron ProgramaSoftware, CatalogoSoftwareApp, 

// una estructura de datos que fue List<ProgramaSoftware> 

//(la estructura central para almacenar el catálogo).

//Main (implícita/clase que contiene el punto de entrada).

//de listas fueron un total de 7 listas usadas en el código.

// Propiedades fueron 3 (get set) Id, Nombre, Version (Definen los datos de cada programa).