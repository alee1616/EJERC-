// See https://aka.ms/new-console-template for more information

//Ejercicio 1: Calcular el área de un triángulo

using System; // Importa el espacio de nombres System para usar la consola

class Program //   Define la clase principal del programa
{
    //Sus parámetros son por valor, porque no usaste ref ni out. //////
    //1. Método con retorno y con parámetros por valor (función). ////
    //Uso: cuando necesitas un cálculo que devuelva un resultado (área, promedio, etc.). no modifica variables.
    //Tipo: función, porque devuelve un valor (double). ////
    //Parámetros: por valor (baseT, altura se pasan como copia, no se modifican fuera de la función). ////
    static double CalcularAreaTriangulo(double baseT, double altura)
    //el static indica que el método pertenece a la clase Program y se puede llamar sin crear objetos.
    // double = tipo de dato de retorno (número con decimales).
    // Define un método que calcula el área de un triángulo
    // Recibe la base y la altura como parámetros
    // Devuelve el área calculada
    {
        return (baseT * altura) / 2;
        // Fórmula del área del triángulo: (base * altura) / 2
        // Retorna el resultado al llamador
        // El tipo de retorno es double para permitir valores con decimales
    }


    static void Main()
    // es un procedimiento (void)
    //Su tipo de retorno es void → no devuelve nada.
    // Punto de entrada del programa
    // Aquí se llama al método CalcularAreaTriangulo y se muestra el resultado
    // Se pueden cambiar los valores de base y altura para probar con diferentes triángulos
    {
        double area = CalcularAreaTriangulo(10, 5);
        // Llama al método con base=10 y altura=5
        // Almacena el resultado en la variable area
        // Muestra el área calculada en la consola
        Console.WriteLine("Área del triángulo: " + area);
        // Concatenación de cadenas para mostrar el resultado
        // El área debería ser 25 para estos valores
        // Fin del programa
    }
}
// }
// (double baseT, double altura)
// return (baseT * altura) / 2;
// static double CalcularAreaTriangulo
// {
//lo que se cambio fue el nombre de la funcion y los parametros
//se cambio de void a double    
//se agrego return para devolver el valor calculado
//se agrego el metodo Main para ejecutar la funcion y mostrar el resultado
//se agrego el using System; para usar la consola
//se agrego la clase Program para contener los metodos



