// See https://aka.ms/new-console-template for more information
int calificación;
Console.WriteLine("Evaluación de la calificación de un estudiante y mostrar si aprobó, está en recuperación o  reprobó.");
Console.WriteLine("///// Ingrese la calificación del estudiante (0-100): //////");
calificación = Convert.ToInt32(Console.ReadLine());
if (calificación >= 70) // Si la calificación es 70 o más, el estudiante aprobó
{
    Console.WriteLine("*** El estudiante aprobó.*** "); // Mensaje de aprobación
}
else if (calificación >= 50 && calificación < 70) // Si la calificación está entre 50 y 69, el estudiante está en recuperación
{
    Console.WriteLine("*** El estudiante está en recuperación.***");
}
else if (calificación < 50) // Si la calificación es menor que 50, el estudiante reprobó
{
    Console.WriteLine("*** El estudiante reprobó.*** ");
}
else
{
    Console.WriteLine(" // Calificación inválida. Por favor ingrese un valor entre 0 y 100. //"); // Mensaje de error para calificaciones fuera del rango válido
}