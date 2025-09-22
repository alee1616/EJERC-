// See https://aka.ms/new-console-template for more information
using System; // Importa el espacio de nombres System para usar la consola y tipos de datos 

class Program // Clase principal
{
    // Procedimiento: recibe tres enteros por valor y muestra el mayor en pantalla
    static void MostrarMayor(int a, int b, int c)
    {
        int mayor = a; 
        if (b > mayor) mayor = b; // si b es mayor, actualiza mayor
        if (c > mayor) mayor = c; // si c es mayor, actualiza mayor
        Console.WriteLine($"El mayor es: {mayor}"); // muestra el mayor
    }

    static void Main()
    {
        Console.WriteLine("//// Programa para determinar el mayor de tres números. \n >>> Ingresa -99 para salir.");

        while (true)
        {
            // Leer números
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == -99) break; 

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == -99) break; 

            Console.Write("Ingrese el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == -99) break; 

            // Llamada al procedimiento que calcula y muestra el mayor
            MostrarMayor(num1, num2, num3);

            Console.WriteLine("-------------");
        }

        Console.WriteLine("Programa finalizado.");
    }
}
