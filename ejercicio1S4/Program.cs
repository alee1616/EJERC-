// See https://aka.ms/new-console-template for more information
int i = 0;
while (i < 5)
{
    Console.WriteLine("Numero: " + i);
    //i++; <- Incrementar 'i' para evitar un bucle infinito
        }


// El problema con este código es que es un bucle infinito,
// ya que la variable 'i' nunca se incrementa.
// La solución es agregar 'i++' dentro del bucle a como lo indica
// el comentario dentro del bloque de código

