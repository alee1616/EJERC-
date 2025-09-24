using System;
class VariablesEjemplos
{

    static void Main()
    {
        int numero = 15; //Variable local main
        Console.WriteLine($"Variable local en Main: {numero}");
        MostrarMensaje();
    }
    static void MostrarMensaje()
    {
        string mensaje = "Hola desde otra función";//Variable local MostrarMensaje
        Console.WriteLine(mensaje);
    }
}