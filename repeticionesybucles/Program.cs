// See https://aka.ms/new-console-template for more information

// Escriba el programa que lea números del teclado mientras no se digite -99 
//Determinar el mayor y el menor de los números  que fueron ingresados.

int numero, mayor = int.MinValue, menor = int.MaxValue; // Inicializa mayor y menor con los valores extremos posibles
Console.WriteLine(" // Ingrese números para determinar el mayor y el menor. Ingrese -99 para finalizar. //");
while (true) // Bucle infinito que se romperá al ingresar -99
{
    numero = Convert.ToInt32(Console.ReadLine()); // Lee el número ingresado por el usuario
    if (numero == -99) // Condición para salir del bucle
    {
        break; // Sale del bucle si se ingresa -99
    }
    if (numero > mayor) // Actualiza el mayor si el número ingresado es mayor
    {
        mayor = numero; // Asigna el nuevo valor a mayor
    }
    if (numero < menor) // Actualiza el menor si el número ingresado es menor
    {
        menor = numero; // Asigna el nuevo valor a menor
    }
}
Console.WriteLine("El número mayor es: " + mayor); // Muestra el número mayor encontrado
Console.WriteLine("El número menor es: " + menor); // Muestra el número menor encontrado