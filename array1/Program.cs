// Primer ejemplo de manejo de excepciones en C#

using System;        // Espacio de nombres básico de C#
using System.IO;     // Necesario para usar la clase File y las excepciones de archivos

class Program // Clase principal
{
    static void Main() // Static void Main es el punto de entrada de la aplicación y no devuelve nada
    // quiere decir que no retorna ningún valor
    {
        // Este es un ejemplo básico de manejo de excepciones en C#, un bloque try-catch-finally
        try // Bloque try para código que puede generar excepciones
        {
            // Código que puede generar un error
            //en este caso vamos a intentar leer un archivo que puede no existir
            string contenido = File.ReadAllText("datos.txt"); // Intentamos leer un archivo que puede no existir
            Console.WriteLine(contenido); // Si el archivo se lee correctamente, mostramos su contenido

            //string ruta = @"C:\Windows\System32\registro.txt";
            //string ruta = @"C:\no_existe\sub\registro.txt";
            //string ruta = @"C:\Temp\" + new string('a', 300) + ".txt"; // suele caer en IOException/PathTooLongException
            //string ruta = null;
        }
        catch (FileNotFoundException ex) 
        //el FileNotFoundException es un tipo de excepción específico, que se usa para manejar errores
        // relacionados con archivos que no se encuentran
        // Catch lo que hace es básicamente capturar la excepción
        { 
            // Filenotfoundexception, por ejemplo, es uno de esos tipos de excepciones que vienen de
            // System.Exception, y se usa para manejar cuando no encuentra un archivo
            Console.WriteLine("Error: " + ex.Message); // si el problema coincide con
            // el tipo de excepción, se ejecuta este bloque
        }
        catch (UnauthorizedAccessException ex) // esta excepción es para cuando el archivo está 
        // protegido o la carpeta requiere permisos de administrador.
        {
            Console.WriteLine("Error: No tienes permiso para acceder al archivo.");
        }
        catch (Exception ex) // este ya es un catch genérico, que captura cualquier otra excepción que 
        // se haya escapado de los anteriores
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
        finally // finally lo podemos comparar con un return porque es lo que nos devuelve el resultado final   
        {
            Console.WriteLine("Proceso finalizado, se liberaron los recursos.");
        }
    }
}