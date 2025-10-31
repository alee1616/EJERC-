using System;
using System.Collections.Generic;

// Clase que representa un nodo individual en el árbol
class Nodo
{
    public int Valor;
    // Referencias al subárbol izquierdo y derecho
    public Nodo Izquierdo, Derecho;

    // Constructor para inicializar el nodo con un valor
    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = Derecho = null;
    }
}

// Clase principal que gestiona el Árbol Binario de Búsqueda (BST)
class ArbolBinarioBusqueda
{
    public Nodo Raiz;

    public ArbolBinarioBusqueda()
    {
        Raiz = null;
    }

    // --- 1. OPERACIONES BÁSICAS ---

    // Método público para iniciar la inserción desde la raíz
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    // Método privado y recursivo para encontrar la posición de inserción
    private Nodo InsertarRecursivo(Nodo raiz, int valor)
    {
        // Caso base: si el nodo es nulo, creamos un nuevo nodo aquí
        if (raiz == null)
        {
            return new Nodo(valor);
        }

        // Navegación: si el valor es menor, vamos a la izquierda; si es mayor, a la derecha.
        // No se manejan duplicados para simplificar.
        if (valor < raiz.Valor)
        {
            raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, valor);
        }
        else if (valor > raiz.Valor)
        {
            raiz.Derecho = InsertarRecursivo(raiz.Derecho, valor);
        }

        // Devolvemos el nodo (sub-árbol) sin cambios si no se insertó nada
        return raiz;
    }

    // Método público para buscar un valor en el árbol
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    // Método privado y recursivo para la búsqueda
    private bool BuscarRecursivo(Nodo raiz, int valor)
    {
        // Caso base 1: El árbol está vacío o llegamos a una hoja (no encontrado)
        if (raiz == null)
        {
            return false;
        }

        // Caso base 2: Encontramos el valor
        if (raiz.Valor == valor)
        {
            return true;
        }

        // Navegación:
        if (valor < raiz.Valor)
        {
            // Buscar en el subárbol izquierdo
            return BuscarRecursivo(raiz.Izquierdo, valor);
        }
        else
        {
            // Buscar en el subárbol derecho
            return BuscarRecursivo(raiz.Derecho, valor);
        }
    }

    // Método público para iniciar la eliminación de un valor
    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivo(Raiz, valor);
    }

    // Método privado y recursivo para la eliminación
    private Nodo EliminarRecursivo(Nodo raiz, int valor)
    {
        // Caso 1: El árbol está vacío o el valor no existe
        if (raiz == null)
        {
            return raiz;
        }

        // 1. Buscamos el nodo a eliminar
        if (valor < raiz.Valor)
        {
            raiz.Izquierdo = EliminarRecursivo(raiz.Izquierdo, valor);
        }
        else if (valor > raiz.Valor)
        {
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, valor);
        }
        // 2. Encontramos el nodo a eliminar (raiz.Valor == valor)
        else
        {
            // Caso A: Nodo con un solo hijo o sin hijos
            if (raiz.Izquierdo == null)
            {
                return raiz.Derecho; // Retornamos el hijo derecho (o null si no hay)
            }
            else if (raiz.Derecho == null)
            {
                return raiz.Izquierdo; // Retornamos el hijo izquierdo
            }

            // Caso B: Nodo con dos hijos
            // Encontramos el sucesor in-order (el menor valor en el subárbol derecho)
            raiz.Valor = EncontrarMinimoValor(raiz.Derecho);

            // Eliminamos el sucesor in-order
            raiz.Derecho = EliminarRecursivo(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    // Función auxiliar para encontrar el valor más pequeño en un subárbol
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


    // --- 2. RECORRIDOS ---

    // Recorrido Pre-Orden (Raíz, Izquierda, Derecha)
    public void RecorrerPreOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            RecorrerPreOrden(raiz.Izquierdo);
            RecorrerPreOrden(raiz.Derecho);
        }
    }

    // Recorrido In-Orden (Izquierda, Raíz, Derecha) - Produce valores ordenados en un BST
    public void RecorrerInOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            RecorrerInOrden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            RecorrerInOrden(raiz.Derecho);
        }
    }

    // Recorrido Pos-Orden (Izquierda, Derecha, Raíz)
    public void RecorrerPosOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            RecorrerPosOrden(raiz.Izquierdo);
            RecorrerPosOrden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // --- 3. VALIDACIONES (Simplificada: ¿Es un BST válido?) ---

    // Método público para verificar si el árbol es un BST válido
    public bool EsArbolBinarioBusqueda()
    {
        // Se usa int? para poder pasar null como límites iniciales
        return EsArbolBinarioBusquedaRecursivo(Raiz, null, null);
    }

    // Método privado y recursivo para validar la propiedad BST
    private bool EsArbolBinarioBusquedaRecursivo(Nodo nodo, int? min, int? max)
    {
        // Un árbol vacío siempre es un BST
        if (nodo == null)
        {
            return true;
        }

        // Comprobamos si el nodo actual viola las restricciones de min/max
        if (min.HasValue && nodo.Valor <= min.Value)
        {
            return false;
        }
        if (max.HasValue && nodo.Valor >= max.Value)
        {
            return false;
        }

        // La verificación a la izquierda usa el valor actual como nuevo límite superior (max)
        bool esIzquierdoValido = EsArbolBinarioBusquedaRecursivo(nodo.Izquierdo, min, nodo.Valor);
        
        // La verificación a la derecha usa el valor actual como nuevo límite inferior (min)
        bool esDerechoValido = EsArbolBinarioBusquedaRecursivo(nodo.Derecho, nodo.Valor, max);

        return esIzquierdoValido && esDerechoValido;
    }
}

class Program
{
    static void Main()
    {
        // -------------------------------------------------------------
        // Presentación de la Aplicación en Consola
        // -------------------------------------------------------------
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==================================================");
        Console.WriteLine("  ÁRBOL BINARIO DE BÚSQUEDA (BST) - TAREA UAM");
        Console.WriteLine("==================================================");
        Console.ResetColor();

        ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

        // Valores de ejemplo para insertar
        int[] valores = { 50, 30, 70, 20, 40, 60, 80 };

        Console.WriteLine($"\n-> 1. Insertando valores: {string.Join(", ", valores)}");
        foreach (int v in valores)
        {
            arbol.Insertar(v);
        }
        
        // --- PRUEBA DE RECORRIDOS ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("  2. PRUEBA DE RECORRIDOS");
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();

        Console.Write("   - Pre-Orden (Raíz, Izq, Der):  ");
        arbol.RecorrerPreOrden(arbol.Raiz);

        Console.Write("\n   - In-Orden (Izq, Raíz, Der):   ");
        arbol.RecorrerInOrden(arbol.Raiz); // Debe mostrarse ordenado

        Console.Write("\n   - Post-Orden (Izq, Der, Raíz): ");
        arbol.RecorrerPosOrden(arbol.Raiz);
        Console.WriteLine();
        
        // --- PRUEBA DE BÚSQUEDA ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("  3. PRUEBA DE BÚSQUEDA");
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();

        int valorABuscar = 40;
        Console.WriteLine($"   - Buscando el valor {valorABuscar}: {(arbol.Buscar(valorABuscar) ? "ENCONTRADO" : "NO ENCONTRADO")}");

        valorABuscar = 99;
        Console.WriteLine($"   - Buscando el valor {valorABuscar}: {(arbol.Buscar(valorABuscar) ? "ENCONTRADO" : "NO ENCONTRADO")}");

        // --- PRUEBA DE ELIMINACIÓN ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("  4. PRUEBA DE ELIMINACIÓN");
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();

        int valorAEliminar = 30; // Un nodo con dos hijos
        Console.WriteLine($"   - Eliminando valor {valorAEliminar}");
        arbol.Eliminar(valorAEliminar);
        Console.Write("   - In-Orden después de eliminar: ");
        arbol.RecorrerInOrden(arbol.Raiz);
        Console.WriteLine();

        valorAEliminar = 80; // Un nodo hoja
        Console.WriteLine($"   - Eliminando valor {valorAEliminar}");
        arbol.Eliminar(valorAEliminar);
        Console.Write("   - In-Orden después de eliminar: ");
        arbol.RecorrerInOrden(arbol.Raiz);
        Console.WriteLine();

        // --- PRUEBA DE VALIDACIÓN ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("  5. PRUEBA DE VALIDACIÓN");
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();
        
        // El árbol actual es un BST válido
        Console.WriteLine($"   - ¿Es un BST válido? : {(arbol.EsArbolBinarioBusqueda() ? "SÍ (Correcto)" : "NO (Incorrecto)")}");
        
        Console.WriteLine("\n==================================================");
        Console.WriteLine("  FIN DEL PROGRAMA");
        Console.WriteLine("==================================================");
    }
}

