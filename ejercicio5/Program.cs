// See https://aka.ms/new-console-template for more information

        Console.WriteLine("Ingrese un año:");
        int año = int.Parse(Console.ReadLine());

        // Condición de año bisiesto
        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) // Un año es bisiesto si es divisible por 4 pero no por 100, 
                                                                  // a menos que sea divisible por 400. 
        {
            Console.WriteLine("El año " + año + " es bisiesto."); // Si la condición se cumple, el año es bisiesto
        }
        else // Si no se cumple la condición
        {
            Console.WriteLine("El año " + año + " no es bisiesto."); // Si no se cumple, el año no es bisiesto
        }
