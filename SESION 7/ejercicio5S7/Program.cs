// See https://aka.ms/new-console-template for more information

//Descripcion del porgrama: Desarrolla una función en C# que reciba como parámetro una cadena de
//texto ingresada por el usuario y devuelva la cantidad de vocales que
//contiene.

using System; // Importa el espacio de nombres System para usar la consola y tipos de datos

class Program
{
    //Función (con retorno): devuelve el valor → más flexible, puedes usarlo en cálculos, condiciones, etc.
    //confirma que este ejercicio se resolvió solo con función.
    // Función que cuenta las vocales en una cadena de texto
    static int ContarVocales(string texto)
    //Tipo: función, porque devuelve un valor (int). ////
    //Parámetro: por valor (texto se pasa como copia, no se modifica fuera de la función).
    // recibe un parámetro de tipo string y devuelve un entero
    // Ese seria un parametro por valor, ya que se pasa una copia del valor original a la función.
    // el valor original siendo la cadena ingresada por el usuario.
    //lo recibe por valor, ya que no se usa ref ni out.
    // El tipo de retorno es int porque devuelve un número entero (la cantidad de vocales
    // Si se quisiera pasar por referencia se usaria la palabra reservada ref o out antes del tipo de dato
    // por ejemplo: 
    // static void ContarVocales(ref string texto)
    // y la función no devolvería nada, ya que el tipo de retorno sería void,
    // se modificaría directamente el valor original pasado a la función.


    {
        int contador = 0; // inicializa el contador de vocales
        string vocales = "aeiouAEIOU"; // define las vocales a buscar
        foreach (char c in texto) // foreach para recorrer cada caracter en la cadena que puso el usuario
        {       // c es el caracter actual en la iteración para comparar
            if (vocales.Contains(c)) // si encontramos vocales contenidas en donde va iterando c 
            {                        // las va a sumar al contador
                contador++; // incrementa el contador si el caracter es una vocal
            }
        }
        return contador;            // devuelve el total de vocales encontradas
    }

    // Procedimiento (sin retorno): no devuelve valor → menos flexible, solo realiza acciones.
    //confirma que este programa es con retorno (función).
    static void Main()  // Punto de entrada del programa para ejecutar la función de manera ordenada 
    {
        Console.Write("Ingrese una cadena de texto: ");
        string entrada = Console.ReadLine(); // lee la cadena ingresada por el usuario
        int cantidadVocales = ContarVocales(entrada); // llama a la función y almacena el resultado
        Console.WriteLine($"La cantidad de vocales es: {cantidadVocales}"); // muestra el resultado en consola
    }
}

//un parametro es una variable que se declara en la definición de una función o procedimiento
//y se utiliza para recibir valores cuando se llama a esa función o procedimiento.