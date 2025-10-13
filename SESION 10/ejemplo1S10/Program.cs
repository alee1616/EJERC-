
internal class Program
{
    private static void Main(string[] args)
    {
        int fila = 2,
        col = 3;
        int filasuma= 0;
        int suma = 0;
        //Declaracion de arreglos
        int[,] arreglo = new int[fila, col];
        Console.WriteLine("Ingrese los valores del arreglo: ");
        // llenar el arreglo
        for (int f = 0; f < 2; f++) // filas
        {
            for (int c = 0; c < 3; c++) // columnas
            {
                arreglo[f, c] = Convert.ToInt32(Console.ReadLine());
            }

        }
        //Ciclo para mostrar el arreglo
        Console.WriteLine("Imprimiendo el arreglo... ");
        for (int f = 0; f < 2; f++) // filas
        {
            for (int c = 0; c < 3; c++) // columnas
            {
                Console.Write(arreglo[f, c] + "\t");
                suma += arreglo[f, c];
                filasuma += arreglo[f, c];
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}

//Leyendos los datos del teclado 