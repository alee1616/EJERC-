// ejemplo de funcionamiento de las filas 


string[] palabras = new string[3];

Stack<int> pila = new Stack<int>();
palabras.Push("uno");
palabras.Push("dos");
palabras.Push("tres");

while (pila.Count > 0)
{
    Console.WriteLine(pila.Pop());
}