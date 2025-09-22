
using System; // Importa el espacio de nombres System para usar la consola y tipos de datos

class Program // Define la clase principal del programa
{
	// Método sin retorno, recibe parámetros por valor
	// Este método solo muestra el mayor en pantalla
	static void MostrarMayor(int a, int b, int c)
    // recibe tres parámetros de tipo entero
    // y no devuelve ningún valor (void)
    // Los parámetros se pasan por valor, es decir, se envía una copia de cada variable
    //los int a, b, c son copias de los valores originales
    // Si se quisiera pasar por referencia se usaria la palabra reservada ref o out antes del tipo de dato
    // por ejemplo:
    // static void MostrarMayor(ref int a, ref int b, ref int c)
    // y el método no devolvería nada, ya que el tipo de retorno sería void,
    // se modificaría directamente el valor original pasado al método.
    {
		int mayor = a;
        // inicializa mayor con el valor de a 
        // luego compara con b y c para encontrar el mayor
        // si b es mayor que mayor, actualiza mayor
        // si c es mayor que mayor, actualiza mayor
        // finalmente muestra el mayor en consola
        if (b > mayor) mayor = b;
        // si b es mayor que mayor, actualiza mayor
        if (c > mayor) mayor = c;
        // si c es mayor que mayor, actualiza mayor
		Console.WriteLine($"El mayor es: {mayor}"); // muestra el mayor en consola
	}

	// Método con retorno, recibe parámetros por valor
	// Este método calcula y devuelve el mayor
	static int ObtenerMayor(int a, int b, int c)
    // recibe tres parámetros de tipo entero
    // y devuelve un entero (el mayor)
    // Los parámetros se pasan por valor, es decir, se envía una copia de cada variable
    //los int a, b, c son copias de los valores originales
    // Si se quisiera pasar por referencia se usaria la palabra reservada ref o out antes del tipo de dato
    // por ejemplo:
    // static int ObtenerMayor(ref int a, ref int b, ref int c)
    // y el método devolvería un entero (el mayor),
    // pero se modificaría directamente el valor original pasado al método.
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
			// Leer primer número
			Console.Write("Ingrese el primer número: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			if (num1 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Leer segundo número
			Console.Write("Ingrese el segundo número: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			if (num2 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Leer tercer número
			Console.Write("Ingrese el tercer número: ");
			int num3 = Convert.ToInt32(Console.ReadLine());
			if (num3 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Usando método sin retorno
			// Se pasa por valor, solo se envía una copia de los números
			MostrarMayor( num1, num2, num3);

			// Usando método con retorno
			// También se pasa por valor
			int mayor = ObtenerMayor(num1, num2, num3);
            // llama al método y almacena el resultado
            // muestra el mayor obtenido del método

            Console.WriteLine($"El mayor es: {mayor}");

			// Comentario: En ambos métodos, los parámetros se pasan por valor, es decir, se envía una copia de cada variable.
			// Si los métodos modificaran los valores, los originales fuera del método no cambiarían.

			Console.WriteLine("-------------");
		}
		Console.WriteLine("Programa finalizado.");
	}
}
