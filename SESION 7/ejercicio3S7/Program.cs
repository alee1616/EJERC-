// See https://aka.ms/new-console-template for more information

//Ejercicio 3: Validar si un número es par
using System; // Se usa para acceder a funcionalidades básicas de C#, como Console.

class Program // Define la clase principal del programa.
{
    // Función principal, punto de entrada del programa.
    //Es un procedimiento, porque retorna void y solo ejecuta instrucciones.
    static void Main(string[] args)
    //Parámetro: string[] args → se pasa por valor (es un arreglo, pero aquí no se modifica).
    // Define el método Main que es el punto de inicio del programa.
    //Usamos string[] args para permitir argumentos desde la línea de comandos.
    // args es un arreglo de cadenas que puede contener argumentos 
    // pasados al programa desde la línea de comandos.
    //lo recibe por valor, ya que no se usa ref ni out.
    // El tipo de retorno es void porque no devuelve ningún valor.
    {
        Console.WriteLine("Ingrese un número:"); // Solicita al usuario un número.
        int numero = int.Parse(Console.ReadLine());
        // Lee el número ingresado y lo convierte a entero.
        //int numero declara una variable entera llamada numero.
        // El operador = asigna el valor leído a la variable numero.
        // int.Parse convierte la cadena leída a un entero.
        // Console.ReadLine() lee la entrada del usuario desde la consola.

        // Llama a la función EsPar y muestra el resultado.
        // if-else para decidir qué mensaje mostrar.
        if (EsPar(numero)) // Verifica si el número es par usando la función.
        {
            Console.WriteLine("El número es par"); // Informa que el número es par.
        }
        else
        {
            Console.WriteLine("El número es impar"); // Informa que el número es impar.
        }
    }

    // 1 función con parámetros por valor.
    // Subprograma que valida si un número es par.
    //Es una función porque devuelve un valor (bool).
    //Parámetro: por valor (se pasa una copia de numero, no se modifica el original).

    static bool EsPar(int numero)
    // Define la función EsPar que recibe un entero y retorna un booleano.
    // static indica que la función pertenece a la clase y no a una instancia.
    // bool indica que la función retorna un valor booleano (true o false).
    //lo recibe por valor, ya que no se usa ref ni out.
    // El parámetro numero es una copia del valor pasado a la función.
    //lo recibe por valor, ya que no se usa ref ni out.
    // El tipo de retorno es bool porque devuelve true o false.
    {
        return numero % 2 == 0;
        // Devuelve true si el número es divisible por 2, false si no.
        //return indica el valor que la función devolverá.
        // El operador == compara si dos valores son iguales.
        // Si el número es divisible por 2 (resto 0), es par.
        // El operador % calcula el resto de la división.
        // Si el resto es 0, el número es par.
    }
}

//Métodos usados:
//1 Función → EsPar(int numero) (con retorno, parámetros por valor).
//1 Procedimiento → Main(string[] args) (sin retorno).

// }
// return numero % 2 == 0;
// static bool EsPar
// {
// (int numero)


// Comentarios sobre el proceso de ordenamiento y solución del problema:
//
// 1. El problema original presentaba fragmentos de código desordenados:
//    - Había partes de la función EsPar separadas y sin estructura.
//    - El return y la declaración de la función estaban fuera de lugar.
//    - No había un programa principal que llamara a la función.
//
// 2. Para solucionarlo, se organizaron los elementos en el orden correcto:
//    - Se definió primero la clase principal Program.
//    - Se implementó el método Main como punto de entrada del programa.
//    - Dentro de Main, se pidió al usuario un número y se leyó la entrada.
//    - Se llamó a la función EsPar para validar si el número es par.
//    - Se mostró el resultado usando if-else.
//
// 3. La función EsPar se estructuró correctamente:
//    - Se declaró como static bool EsPar(int numero).
//    - Se colocó el return dentro de la función, usando la expresión numero % 2 == 0.
//
// 4. Se agregaron comentarios en cada línea y bloque para explicar:
//    - Qué hace cada instrucción.
//    - Cómo funciona la validación de paridad.
//    - Por qué se usa cada operador y estructura.
//
// 5. El resultado es un subprograma válido y funcional:
//    - El código ahora tiene una estructura clara y lógica.
//    - Se puede ejecutar y cumple con el objetivo de validar si un número es par.
//
// Estos cambios muestran cómo, al ordenar y estructurar correctamente los fragmentos, 
//se obtiene un programa completo, entendible y funcional.