//Contador de accesos global
// ✓ Declara una variable global que almacene el número de veces que
// se ha ejecutado un método. Cada vez que se llame al método, debe
// incrementar el contador y mostrarlo en pantalla.

using System;

class ContadorAccesosGlobal
{
    // Variable global (se declara fuera del Main y de los métodos)
    static int contadorAccesos = 0; //Variable global, vive mientras el programa se ejecute, de tipo int

    // Método que incrementa y muestra el contador
    static void MetodoEjemplo() // Tipo: procedimiento, porque retorna void.
    {
        contadorAccesos++; // Aumenta en 1 cada vez que se llama
        Console.WriteLine("El método se ha ejecutado " + contadorAccesos + " veces.");
    }
     // Cada vez que se llama a MetodoEjemplo(), se hace contadorAccesos++ (suma 1).
    static void Main()
    {
        // Llamadas de ejemplo al método
        MetodoEjemplo(); // Primera llamada // El contador es 1
        MetodoEjemplo(); // Segunda llamada // El contador es 2     
        MetodoEjemplo(); // Tercera llamada // El contador es 3

        // El contador sigue aumentando
        Console.WriteLine("Accesos totales: " + contadorAccesos);
    }
}

//El enunciado no pide bucles ni input del usuario, 
//solo que cada vez que se llame al método se incremente el contador y lo muestre.

// de igual manera nos pide un bucle para llamar al método varias veces
// como es un ejemplo simple, lo llamamos 3 veces seguidas en el Main.

// Si se quisiera llamar más veces, se podría usar un bucle, por ejemplo:
/*
    static void Main()
    {
        for (int i = 0; i < 5; i++) // Llama al método 5 veces
        {
            MetodoEjemplo(); 
        }
        Console.WriteLine("Accesos totales: " + contadorAccesos;
    }
*/  