// See https://aka.ms/new-console-template for more information

int edad; // Se puede quitar el valor inicial aquí y solo dejar la declaración.
// Se solicita al usuario que ingrese su edad
Console.Write("Ingresa tu edad: ");
        
// Se lee el valor ingresado por el usuario y se convierte a entero
edad = Convert.ToInt32(Console.ReadLine());


if (edad >= 18) // Condición para verificar si es mayor de edad
{
    Console.WriteLine("Es mayor de edad.");
    Console.WriteLine("// Puede votar.// ");
}
else
{
    Console.WriteLine("Es menor de edad.");
}
// En el código original, faltaban las llaves {} después del if y el else.
// Sin llaves, solo la primera línea después del if o else se considera parte de ese bloque.
// Esto provocaba que "Console.WriteLine("Puede votar.");" se ejecutara siempre, aunque la condición no se cumpliera.

// Se agregaron llaves para agrupar correctamente las instrucciones que deben ejecutarse
// solo si la condición se cumple o no se cumple.
