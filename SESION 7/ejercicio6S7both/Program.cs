// See https://aka.ms/new-console-template for more information
using System; // Importa el espacio de nombres System para usar la consola y tipos de datos

class Program // Define la clase principal del programa
{
    // Método sin retorno, recibe parámetros por valor
    // Este método solo muestra el mayor en pantalla
    
	static void MostrarMayor(int a, int b, int c)
    // recibe tres parámetros de tipo entero
    // y no devuelve ningún valor (void)
    // Los parámetros se pasan por valor, es decir, se envía una copia de cada variable
    // Si se quisiera pasar por referencia se usaría ref o out
    {
        int mayor = a;
        if (b > mayor) mayor = b; // si b es mayor, actualiza mayor
        if (c > mayor) mayor = c; // si c es mayor, actualiza mayor
        Console.WriteLine($"El mayor es: {mayor}"); // muestra el mayor en consola
    }

	// Método con retorno, recibe parámetros por valor
	// Este método calcula y devuelve el mayor
	static int ObtenerMayor(int a, int b, int c)
    // recibe tres parámetros de tipo entero
    // y devuelve un entero (el mayor)
    // Los parámetros se pasan por valor (se envía una copia de cada variable)
    // Si se quisiera pasar por referencia se usaría ref o out
    {
		int mayor = a;
		if (b > mayor) mayor = b;
		if (c > mayor) mayor = c;
		return mayor; // devuelve el mayor
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

			// Usando método sin retorno (se pasa copia de los números)
			MostrarMayor(num1, num2, num3);

			// Usando método con retorno (también por valor)
			int mayor = ObtenerMayor(num1, num2, num3);
            Console.WriteLine($"El mayor es: {mayor}");

			// Comentario: En ambos métodos los parámetros se pasan por valor (copias).
			// Si los métodos modificaran los valores, los originales fuera del método no cambiarían.

			Console.WriteLine("-------------");
		}
		Console.WriteLine("Programa finalizado.");
	}
}
