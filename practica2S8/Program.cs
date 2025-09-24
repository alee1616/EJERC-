// Área de un rectángulo con variables locales
//✓ Crea un método que pida la base y altura de un rectángulo, use
//variables locales para calcular el área y la imprima en pantalla.

using System;

class Program
{
    // Método que calcula el área del rectángulo
    static void CalcularAreaRectangulo() // Tipo: procedimiento, porque retorna void, y no recibe parámetros.
    {
        // Variables locales (solo existen dentro de este método)
        Console.Write("Ingresa la base del rectángulo: ");
        double baseRect = Convert.ToInt32(Console.ReadLine()); //baseRect variable local
        // con el convert.toInt32 convertimos de texto a número entero

        Console.Write("Ingresa la altura del rectángulo: ");
        double altura = Convert.ToInt32(Console.ReadLine()); //altura variable local

        double area = baseRect * altura; // cálculo con variables locales

        Console.WriteLine("El área del rectángulo es: " + area);
    }

    static void Main() // Tipo: procedimiento, porque retorna void, y no recibe parámetros relevantes.
    {
        // Llamamos al método
        CalcularAreaRectangulo();
    }
}
