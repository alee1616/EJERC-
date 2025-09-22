// See https://aka.ms/new-console-template for more information
using System; // Importa el espacio de nombres System para usar la consola

class Program //   Define la clase principal del programa
{
    static double CalcularAreaTriangulo(double baseT, double altura)
    // Define un método que calcula el área de un triángulo
    // Recibe la base y la altura como parámetros
    // Devuelve el área calculada
    {
        return (baseT * altura) / 2;
        // Fórmula del área del triángulo: (base * altura) / 2
        // Retorna el resultado al llamador
        // El tipo de retorno es double para permitir valores con decimales
    }

    static void Main()
    // Punto de entrada del programa
    // Aquí se llama al método CalcularAreaTriangulo y se muestra el resultado
    // Se pueden cambiar los valores de base y altura para probar con diferentes triángulos
    {
        double area = CalcularAreaTriangulo(10, 5);
        // Llama al método con base=10 y altura=5
        // Almacena el resultado en la variable area
        // Muestra el área calculada en la consola
        Console.WriteLine("Área del triángulo: " + area);
        // Concatenación de cadenas para mostrar el resultado
        // El área debería ser 25 para estos valores
        // Fin del programa
    }
}



