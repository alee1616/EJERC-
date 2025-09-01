// See https://aka.ms/new-console-template for more information

        int numero; // Declara una variable para almacenar el número ingresado por el usuario
        Console.Write("Ingresa un número: "); // Solicita al usuario que ingrese un número
        numero = Convert.ToInt32(Console.ReadLine()); // Lee y convierte la entrada a un entero

        if (numero > 0) // Verifica si el número es mayor que cero
        {
            Console.WriteLine("El número es positivo."); // Informa que el número es positivo
        }
        else if (numero < 0) // Verifica si el número es menor que cero
        {
            Console.WriteLine("El número es negativo.");
        }
        else // Si no es ni mayor ni menor, entonces es cero
        {
            Console.WriteLine("El número es cero.");
        }
    
