// See https://aka.ms/new-console-template for more information

int i, sumapar = 0, sumaimpar = 0; // Declaración de variables para el bucle y las sumas
for (i = 1; i <= 100; i++) // Bucle que itera desde 1 hasta 100
{
    if (i % 2 == 0) // Verifica si el número es par
    {
        sumapar = sumapar + i; // Si es par, se añade a la suma de pares
    }
    else // Si no es par, es impar
    {
        sumaimpar = sumaimpar + i; // Se añade a la suma de impares
    }
}
Console.WriteLine("La suma de los números pares es: " + sumapar); // Muestra la suma de los números pares
Console.WriteLine("La suma de los números impares es: " + sumaimpar); // Muestra la suma de los números impares
