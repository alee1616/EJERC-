// See https://aka.ms/new-console-template for more information
int numero = 10;
bool esMayor;
 Console.Write("Ingrese un número: ");
 numero = Convert.ToInt32(Console.ReadLine());

esMayor = (numero > 5);
// Error encontrado: aquí se usó '=' (asignación) en lugar de un operador de comparación.
// esMayor = (numero = 5);
// SOLUCIÓN: usar '>' para comprobar si es mayor que 5

Console.WriteLine("¿Es mayor que 5? " + esMayor);
