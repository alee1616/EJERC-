// See https://aka.ms/new-console-template for more information

        Console.WriteLine("Ingrese la calificación del estudiante:");
        int calificacion = int.Parse(Console.ReadLine()); //convierte ese texto a número entero (int.parse) y 
                                                          // lo guarda en la variable calificacion.
                                                          //  int es un tipo de dato (entero).

        // Usamos calificacion / 10 para agrupar por decenas:
        // Ej: 85/10 = 8, 72/10 = 7, 66/10 = 6, 40/10 = 4
        switch (calificacion / 10)
        {
            // Si la división da 10 (100) o 9 (90-99) o 8 (80-89) o 7 (70-79)
            // significa que sacó entre 70 y 100 → Aprobado
            case 10: // Nota = 100
            case 9:  // Nota entre 90 y 99
            case 8:  // Nota entre 80 y 89
            case 7:  // Nota entre 70 y 79
                Console.WriteLine("Aprobado");
                break;

            // Si la división da 6 (60-69) o 5 (50-59)
            // significa que sacó entre 50 y 69 → Recuperación
            case 6:  // Nota entre 60 y 69
            case 5:  // Nota entre 50 y 59
                Console.WriteLine("Recuperación");
                break;

            // Si no cayó en los anteriores casos (0 a 49)
            // entonces → Reprobado
            default:
                Console.WriteLine("Reprobado");
                break;
        }

