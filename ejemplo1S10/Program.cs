

namespace Ejemarreglo
{
    internal class program
    {
        static void Main(string[] args)
        {

            //Declaracion de arreglos
            int[,] arreglo = new int[2, 3];
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
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

//Leyendos los datos del teclado 