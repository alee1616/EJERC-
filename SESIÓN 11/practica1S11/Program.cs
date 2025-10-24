// ejemplo de funcionamiento de las filas 


Stack<string> palabras = new Stack<string>();

Stack<int> pila = new Stack<int>();
palabras.Push("uno");
palabras.Push("dos");
palabras.Push("tres");

while (pila.Count > 0)
{
    Console.WriteLine(pila.Pop());
}