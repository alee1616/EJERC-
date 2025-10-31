using System;

// Definición de la clase Nodo
class Nodo
{
    public int Valor;
    public Nodo Izquierdo, Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = Derecho = null;
    }
}

// Definición de la clase ArbolBinario (incluye Insertar, Eliminar, Buscar, Recorrer)
class ArbolBinario
{
    public Nodo Raiz;

    // --- Inserción ---
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo raiz, int valor)
    {
        if (raiz == null) return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = InsertarRecursivo(raiz.Derecho, valor);

        return raiz;
    }

    // --- Eliminación ---
    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivo(Raiz, valor);
    }

    private Nodo EliminarRecursivo(Nodo raiz, int valor)
    {
        if (raiz == null) return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = EliminarRecursivo(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, valor);
        else
        {
            // Nodo encontrado
            if (raiz.Izquierdo == null)
                return raiz.Derecho;
            else if (raiz.Derecho == null)
                return raiz.Izquierdo;

            // Nodo con 2 hijos
            raiz.Valor = EncontrarMinimoValor(raiz.Derecho);
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    private int EncontrarMinimoValor(Nodo nodo)
    {
        int minValor = nodo.Valor;
        while (nodo.Izquierdo != null)
        {
            minValor = nodo.Izquierdo.Valor;
            nodo = nodo.Izquierdo;
        }
        return minValor;
    }


    // --- Búsqueda ---
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    private bool BuscarRecursivo(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (raiz.Valor == valor)
            return true;

        if (valor < raiz.Valor)
            return BuscarRecursivo(raiz.Izquierdo, valor);
        else
            return BuscarRecursivo(raiz.Derecho, valor);
    }


    // --- Recorrido En Orden ---
    public void RecorrerEnOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            RecorrerEnOrden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            RecorrerEnOrden(raiz.Derecho);
        }
    }
}

// Clase Principal para la interacción del usuario
class Program
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        bool continuar = true;

        // Construcción inicial del árbol
        arbol.Insertar(50);
        arbol.Insertar(30);
        arbol.Insertar(70);
        arbol.Insertar(20);
        arbol.Insertar(40);
        arbol.Insertar(60);
        arbol.Insertar(80);

        Console.WriteLine("Arbol Binario de Busqueda Inicial Creado:");
        Console.Write("Recorrido en Orden: ");
        arbol.RecorrerEnOrden(arbol.Raiz);
        Console.WriteLine("\n-------------------------------------");

        while (continuar)
        {
            Console.WriteLine("\nSeleccione una operacion:");
            Console.WriteLine("1: Insertar un nodo");
            Console.WriteLine("2: Buscar un nodo");
            Console.WriteLine("3: Eliminar un nodo");
            Console.WriteLine("4: Mostrar Arbol (Recorrido Inorden)");
            Console.WriteLine("5: Salir");
            Console.Write("Opcion: ");

            string opcion = Console.ReadLine();
            int valor;
            
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el valor a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        arbol.Insertar(valor);
                        Console.WriteLine($"Valor {valor} insertado.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Intente de nuevo.");
                    }
                    break;

                case "2":
                    Console.Write("Ingrese el valor a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        if (arbol.Buscar(valor))
                            Console.WriteLine($"El valor {valor} SI se encuentra en el arbol.");
                        else
                            Console.WriteLine($"El valor {valor} NO se encuentra en el arbol.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Intente de nuevo.");
                    }
                    break;

                case "3":
                    Console.Write("Ingrese el valor a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        if (arbol.Buscar(valor))
                        {
                            arbol.Eliminar(valor);
                            Console.WriteLine($"Valor {valor} eliminado.");
                        }
                        else
                        {
                            Console.WriteLine($"El valor {valor} no se encontro para ser eliminado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Intente de nuevo.");
                    }
                    break;

                case "4":
                    Console.Write("Recorrido en Orden Actual: ");
                    arbol.RecorrerEnOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case "5":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Por favor, ingrese un numero del 1 al 5.");
                    break;
            }
        }
    }
}