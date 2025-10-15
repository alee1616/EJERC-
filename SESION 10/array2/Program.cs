// Segundo ejemplo: manejo de excepciones al escribir archivos en C#

using System; // Espacio de nombres básico de C#
using System.IO; // Necesario para usar la clase File, StreamWriter y las excepciones de archivos

class EjemploEscritura // Clase principal
{
    static void Main()
    {
        string ruta = "registro.txt"; // Nombre del archivo donde se guardarán los datos, puede ser una ruta completa

        try // Bloque try para código que puede generar excepciones, es comun cuando trabajamos con archivos
        {
            // Validar si el archivo ya existe
            if (File.Exists(ruta)) 
            // el File.Exists es un método que verifica si un archivo existe en la ruta especificada
             // devuelve true si el archivo existe y false si no
             // Si el archivo ya existe
             // ruta es una variable que contiene la ruta del archivo
            // este es un ejemplo más básico de manejo de excepciones
             // con condicionales antes de intentar escribir en un archivo y también usanmos algunas de 
             // las excepciones que mencionamos antes
            {
                Console.WriteLine("El archivo ya existe. Se agregarán nuevos datos...");
            }
            else // Si el archivo no existe
            {
                Console.WriteLine("Creando nuevo archivo..."); // Si no existe, se crea uno nuevo
            }

            // using garantiza que el archivo se cierre automáticamente
            using (StreamWriter escritor = new StreamWriter(ruta, true))
            // StreamWriter es una clase que permite escribir en archivos de texto
            // el segundo parámetro (true) indica que se debe agregar al final del archivo si
            // true → agrega texto sin borrar lo anterior
            {
                escritor.WriteLine("Registro creado en: " + DateTime.Now);
                // Escribimos la fecha y hora actual
                //DateTime.Now nos da la fecha y hora actual del sistema
                escritor.WriteLine("Acción: Inicio de sesión");
                escritor.WriteLine("Usuario: Jesy");
                escritor.WriteLine("----------------------");
            }

            Console.WriteLine("Los datos fueron escritos correctamente.");
        }
        catch (UnauthorizedAccessException) // esta excepción es para cuando el archivo está 
        // protegido o la carpeta requiere permisos de administrador.
        {
            Console.WriteLine("Error: No tienes permiso para escribir en esta ubicación.");
        }
        catch (DirectoryNotFoundException) // esta excepción es para cuando la carpeta no existe
        // y por lo tanto no puede crear el archivo ahí
        {
            Console.WriteLine("Error: La carpeta especificada no existe."); // ex.Message nos da detalles del error
        }
        catch (IOException ex) 
        // IOException es una excepción más general que maneja errores de entrada/salida
        // como problemas al escribir en el disco, falta de espacio, etc.   
        {
            Console.WriteLine("Error de entrada/salida: " + ex.Message); // ex.Message nos da detalles del error
        }
        catch (Exception ex) // este ya es un catch genérico, que captura cualquier otra excepción que 
        // se haya escapado de los anteriores
        {
            Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
        }
        finally // finally lo podemos comparar con un return porque es lo que nos devuelve el resultado final
        {
            Console.WriteLine("Finalizó la operación de escritura.");
        }
    }
}