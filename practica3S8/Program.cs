using System;

class Program
{
    // Variable global que indica la escala de conversión
    static string escala; // Variable global (escala), vive mientras el programa se ejecute, de tipo string

    // Método que realiza la conversión según la escala
    static void ConvertirTemp() // Tipo: procedimiento, porque retorna void.
    {
        // se usó if-else para elegir la conversión según la variable global 'escala'
        if (escala == "Celsius a Fahrenheit")
        {
            Console.Write("Ingresa la temperatura en Celsius: ");
            double cls = Convert.ToInt32(Console.ReadLine());
            double frt = (celsius * 9 / 5) + 32;
            Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");
        }
        else if (escala == "Fahrenheit a Celsius")
        {
            Console.Write("Ingresa la temperatura en Fahrenheit: ");
            double frt = Convert.ToInt32(Console.ReadLine());
            double cls = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(fahrenheit + "°F = " + celsius + "°C");
        }
        else
        {
            Console.WriteLine("Escala inválida.");
        }
    }

    static void Main()
    // Tipo: procedimiento, porque retorna void, y no recibe parámetros relevantes.
    //Este es el punto de entrada del programa
    {
        // Pedimos al usuario elegir la conversión
        Console.WriteLine("Elige la conversión:");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.Write("Opción: ");
        string opcion = Console.ReadLine(); // se uso string porque es texto

        if (opcion == "1")
            escala = "Celsius a Fahrenheit";
        else if (opcion == "2")
            escala = "Fahrenheit a Celsius";
        else
        {
            Console.WriteLine("Opción inválida. El programa terminará.");
            return; // termina el programa
        }

        // Llamamos al método para realizar la conversión
        ConvertirTemperatura();
    }
}
