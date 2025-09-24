// See https://aka.ms/new-console-template for more information
using System;
class VariablesEjemplos
{
    static int contador = 0; // ??? Global o Loal
    static void Main()
    {
        int numero = 10; // ??? global o local??
        contador ++;
        Console.WriteLine($"Numero: {numero}, Contador: {contador}");
        OtraFuncion();
    }
    static void OtraFuncion()
    {
        string mensaje = "Hola"; // ??? global o local??
        contador++;
        Console.WriteLine($"Mensaje: {mensaje}, Contador: {contador}");
    }
        
}