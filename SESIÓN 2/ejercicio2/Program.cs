// See https://aka.ms/new-console-template for more information
int diaSemana;// Declara una variable para almacenar el número del día de la semana
        string nombreDia; // Declara una variable para almacenar el nombre del día correspondiente

        System.Console.Write("Ingrese un número entre 1 y 7: "); // Solicita al usuario que ingrese un número
        diaSemana = Convert.ToInt32(System.Console.ReadLine()); // Lee y convierte la entrada a un entero

        switch (diaSemana) // Evalúa el valor de diaSemana
        {
            case 1: // Si es 1, asigna "Lunes"
                nombreDia = "Lunes"; // Asigna el nombre del día correspondiente
                break;
            case 2:
                nombreDia = "Martes";
                break;
            case 3:
                nombreDia = "Miércoles";
                break;
            case 4:
                nombreDia = "Jueves";
                break;
            case 5:
                nombreDia = "Viernes";
                break;
            case 6:
                nombreDia = "Sábado";
                break;
            case 7:
                nombreDia = "Domingo";
                break;
            default: // Si no es ningún caso válido, asigna "Día inválido"
                nombreDia = "Día inválido";
                break; // Termina el bloque switch
        }

        Console.WriteLine(nombreDia); // Muestra el nombre del día o un mensaje de error
    


