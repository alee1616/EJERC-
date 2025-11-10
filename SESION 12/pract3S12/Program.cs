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

// Definición de la clase ArbolBinario
class ArbolBinario
{
    public Nodo Raiz;

    // --- 1. Funcionalidad de Inserción (ya existente) ---
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo raiz, int valor)
    {
        if (raiz == null) return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor) // Usamos 'else if' para evitar duplicados si se desea
            raiz.Derecho = InsertarRecursivo(raiz.Derecho, valor);

        return raiz;
    }

    // --- 2. Funcionalidad de Eliminación ---

    // Método público para iniciar la eliminación
    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivo(Raiz, valor);
    }

    // Método privado recursivo para eliminar un nodo
    private Nodo EliminarRecursivo(Nodo raiz, int valor)
    {
        // Caso base: El árbol está vacío o el valor no se encontró
        if (raiz == null) return raiz;

        // Recorrer el árbol para encontrar el nodo a eliminar
        if (valor < raiz.Valor)
            raiz.Izquierdo = EliminarRecursivo(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, valor);
        else
        {
            // ¡Nodo encontrado! Manejamos los 3 casos de eliminación:

            // Caso 1: Nodo con 0 o 1 hijo
            if (raiz.Izquierdo == null)
                return raiz.Derecho; // Retorna el hijo derecho (o null si es hoja)
            else if (raiz.Derecho == null)
                return raiz.Izquierdo; // Retorna el hijo izquierdo

            // Caso 2: Nodo con 2 hijos
            // Encontramos el sucesor inorden (el nodo más pequeño en el subárbol derecho)
            raiz.Valor = EncontrarMinimoValor(raiz.Derecho);

            // Eliminamos el sucesor inorden del subárbol derecho
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    // Método auxiliar para encontrar el valor más pequeño en un subárbol
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


    // --- 3. Funcionalidad de Búsqueda ---

    // Método público para iniciar la búsqueda
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    // Método privado recursivo para buscar un nodo
    private bool BuscarRecursivo(Nodo raiz, int valor)
    {
        // Caso base 1: El árbol está vacío o el valor no se encontró
        if (raiz == null)
            return false;

        // Caso base 2: El nodo con el valor se encontró
        if (raiz.Valor == valor)
            return true;

        // Recorrer el árbol:
        if (valor < raiz.Valor)
            return BuscarRecursivo(raiz.Izquierdo, valor); // Buscar en subárbol izquierdo
        else
            return BuscarRecursivo(raiz.Derecho, valor); // Buscar en subárbol derecho
    }


    // --- 4. Funcionalidad de Recorrido En Orden (ya existente) ---
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

// Clase Principal para la demostración
class Program
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        Console.WriteLine("--- Construyendo el Árbol Binario de Búsqueda (ABB) ---");
        
        arbol.Insertar(50);
        arbol.Insertar(30);
        arbol.Insertar(70);
        arbol.Insertar(20);
        arbol.Insertar(40);
        arbol.Insertar(60);
        arbol.Insertar(80);

        Console.Write("Árbol inicial (Recorrido en Orden): ");
        arbol.RecorrerEnOrden(arbol.Raiz); // Salida: 20 30 40 50 60 70 80 
        Console.WriteLine();
        
        // --- Demostración de Búsqueda ---
        Console.WriteLine("\n--- Demostración de Búsqueda ---");
        int valorABuscar = 40;
        Console.WriteLine($"¿Existe el nodo con valor {valorABuscar}? -> **{arbol.Buscar(valorABuscar)}**"); // Salida: True
        
        valorABuscar = 99;
        Console.WriteLine($"¿Existe el nodo con valor {valorABuscar}? -> **{arbol.Buscar(valorABuscar)}**"); // Salida: False

        // --- Demostración de Eliminación ---
        Console.WriteLine("\n--- Demostración de Eliminación ---");
        
        // 1. Eliminar un nodo hoja (20)
        Console.WriteLine("Eliminando **20** (nodo hoja)...");
        arbol.Eliminar(20);
        Console.Write("Recorrido en orden: ");
        arbol.RecorrerEnOrden(arbol.Raiz); 
        Console.WriteLine();

        // 2. Eliminar un nodo con dos hijos (50 - la raíz)
        Console.WriteLine("Eliminando **50** (nodo con dos hijos)...");
        arbol.Eliminar(50);
        Console.Write("Recorrido en orden: ");
        arbol.RecorrerEnOrden(arbol.Raiz); // Ahora el 60 es la nueva raíz
        Console.WriteLine();
    }
}