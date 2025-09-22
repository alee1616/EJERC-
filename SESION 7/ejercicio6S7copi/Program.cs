// See https://aka.ms/new-console-template for more information

//modificado para que los valores de los tres números se cambien 
//dentro del método usando ref. Así, verás que los valores 
//originales cambian después de llamar al método:
using System;

class Program
{
    // Método sin retorno, recibe parámetros por referencia
    // Este método asigna el mayor a una variable pasada por referencia
    static void MostrarMayor(ref int a, ref int b, ref int c, ref int mayor)
    {
        mayor = a;
        if (b > mayor) mayor = b;
        if (c > mayor) mayor = c;
        Console.WriteLine($"El mayor es: {mayor}");
    }

    // Método con retorno, recibe parámetros por referencia
    // Este método calcula y devuelve el mayor
    static int ObtenerMayor(ref int a, ref int b, ref int c)
    {
        int mayor = a;
        if (b > mayor) mayor = b;
        if (c > mayor) mayor = c;
        return mayor;
    }

    static void Main()
    {
        Console.WriteLine("//// Programa para determinar el mayor de tres números. \n >>> Ingresa -99 para salir.");
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

            int mayor = 0;

            // Usando método sin retorno, pasa por referencia
            MostrarMayor(ref num1, ref num2, ref num3, ref mayor);

            // Usando método con retorno, pasa por referencia
            int mayor2 = ObtenerMayor(ref num1, ref num2, ref num3);
            Console.WriteLine($"El mayor es: {mayor2}");

            Console.WriteLine("-------------");
        }
        Console.WriteLine("Programa finalizado.");
    }
}