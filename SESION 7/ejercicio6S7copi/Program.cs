// See https://aka.ms/new-console-template for more information
//modificado para que los valores de los tres números se cambien 
//dentro del método usando ref. Así, verás que los valores 
//originales cambian después de llamar al método:
using System;

class Program
{
    // Método que modifica los valores y determina el mayor
    static void ModificarYObtenerMayor(ref int a, ref int b, ref int c, out int mayor)
    {
        // Modificamos los valores
        a += 10; // Suma 10 al primer número
        b *= 2;  // Duplica el segundo número
        c = 0;   // Asigna 0 al tercer número

        // Calcula el mayor de los nuevos valores
        mayor = a;
        if (b > mayor) mayor = b;
        if (c > mayor) mayor = c;
    }

    static void Main()
    {
        Console.WriteLine("Programa para modificar los valores y determinar el mayor. Ingresa -99 para salir.");

        while (true)
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == -99) break;

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == -99) break;

            Console.Write("Ingrese el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == -99) break;

            int mayor;
            ModificarYObtenerMayor(ref num1, ref num2, ref num3, out mayor);

            Console.WriteLine($"El mayor de los valores modificados es: {mayor}");
            Console.WriteLine($"Valores actuales: num1={num1}, num2={num2}, num3={num3}");
            Console.WriteLine("---");
        }

        Console.WriteLine("Programa finalizado.");
    }
}

//Este código modifica los valores dentro del método y muestra los resultados después de cada ciclo.

//