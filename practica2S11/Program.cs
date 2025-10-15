
Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);

Console.WriteLine("Elemento superior: " + numeros.Peek());
numeros.Pop(); 
Console.WriteLine("Elementos restantes: " + numeros.Peek());