using System;



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



class ArbolBinario

{

    public Nodo Raiz;



    public void Insertar(int valor)

    {

        Raiz = InsertarRecursivo(Raiz, valor);

    }



    private Nodo InsertarRecursivo(Nodo raiz, int valor)

    {

        if (raiz == null) return new Nodo(valor);



        if (valor < raiz.Valor)

            raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, valor);

        else

            raiz.Derecho = InsertarRecursivo(raiz.Derecho, valor);



        return raiz;

    }



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



class Program

{

    static void Main()

    {

        ArbolBinario arbol = new ArbolBinario();

        arbol.Insertar(50);

        arbol.Insertar(30);

        arbol.Insertar(70);

        arbol.Insertar(20);

        arbol.Insertar(40);

        arbol.Insertar(60);

        arbol.Insertar(80);



        Console.WriteLine("Recorrido en orden:");

        arbol.RecorrerEnOrden(arbol.Raiz);

    }

}   