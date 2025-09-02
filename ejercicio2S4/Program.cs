// See https://aka.ms/new-console-template for more information

Console.WriteLine("Escriba su edad: ");
int edad = Convert.ToInt32(Console.ReadLine()); // Leer y convertir a entero

if (edad > 18 && edad < 65)
{
    Console.WriteLine("Edad válida para trabajar.");
}
else
{
    Console.WriteLine("Edad no válida para trabajar.");
}
// Al código le faltaba usar el operador lógico correcto.
// Se usó || (OR), lo cual hacía que la condición casi siempre fuera verdadera.
// Debe usarse && (AND) para comprobar que la edad esté entre 18 y 65 al mismo tiempo.
// Además, es recomendable agregar un else para el caso en que la edad no sea válida.
