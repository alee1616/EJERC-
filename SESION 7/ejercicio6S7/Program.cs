
//Determinar el mayor de tres números. Leer datos hasta que se digite le
//número -99.
using System; // Importa el espacio de nombres System para usar la consola y tipos de datos

class Program // Define la clase principal del programa
{
	//confirma que este programa es con retorno (función). porque devuelve un valor (int).
	//También confirma que los parámetros se pasan por valor (no usa ref)
	//Tiene tipo de retorno int (ya no es void).
	//Calcula el mayor dentro de la función.
	//Usa return mayor; para devolver el valor al Main().
	// Método con retorno, recibe parámetros por valor
	// Este método calcula y devuelve el mayor
	//Tipo: función, porque devuelve un valor (int). /////
	//Parámetros: por valor (a, b, c se pasan como copia, no se modifican fuera de la función).
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


	//Tipo: procedimiento, porque retorna void.
	//Parámetro: ninguno relevante en el flujo (el string[] args si lo tuviera sería por valor).
	static void Main()
	{
		Console.WriteLine("//// Programa para determinar el mayor de tres números. \n >>> Ingresa -99 para salir.");
		while (true)
		{
			// Leer primer número
			Console.Write("Ingrese el primer número: ");
			int num1 = Convert.ToInt32(Console.ReadLine()); // convierte la entrada a entero
			if (num1 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Leer segundo número
			Console.Write("Ingrese el segundo número: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			if (num2 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Leer tercer número
			Console.Write("Ingrese el tercer número: ");
			int num3 = Convert.ToInt32(Console.ReadLine());
			if (num3 == -99) break; // si el usuario ingresa -99, sale del bucle

			// Llama al método y almacena el resultado
			// Los parámetros se pasan por valor
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
	