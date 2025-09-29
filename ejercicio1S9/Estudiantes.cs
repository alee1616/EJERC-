using system;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiantes
{
    internal class Estudiantes  
    {
        public string nombre;
        public int edad;
        public string curso;

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Curso: {curso}");
        }
    }   
}