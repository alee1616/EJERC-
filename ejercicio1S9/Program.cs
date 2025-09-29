

namespace EjemploClase
{
    internal class Program
    {
        class Triangulo
        {
            private int lado1, lado2, lado3;
            public Triangulo()
            {
                this.lado1 = lado1; // this hace referencia ha que pertenece a esa clase
                this.lado2 = lado2;
                this.lado3 = lado3;
            }

            public void Equilatero()
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
                else
                {
                    Console.WriteLine("El triangulo no es equilatero");
                }
            }

            static void Main(string[] args)
            {
                Triangulo trian = new Triangulo();
                // trian nombre de nuetro objeto
                //new gestiona espacio en memoria
                trian.Equilatero();
            }
        }
    }
}