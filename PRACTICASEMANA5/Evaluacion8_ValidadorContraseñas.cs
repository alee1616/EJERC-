using System;
using System.Linq;

namespace Marian
{
    public static class Evaluacion8_ValidadorContraseñas
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n=== EVALUACIÓN 8: VALIDADOR DE CONTRASEÑAS SEGURAS ===");
            
            string contraseña;
            Console.Write("Ingrese la contraseña a validar: ");
            contraseña = Console.ReadLine();
            
            if (EsContraseñaValida(contraseña))
            {
                Console.WriteLine("La contraseña es válida.");
            }
            else
            {
                Console.WriteLine("La contraseña no cumple con los requisitos de seguridad.");
                MostrarRequisitosContraseña(contraseña);
            }
        }

        private static bool EsContraseñaValida(string contraseña)
        {
            return TieneLongitudMinima(contraseña) &&
                   TieneMayuscula(contraseña) &&
                   TieneMinuscula(contraseña) &&
                   TieneNumero(contraseña) &&
                   TieneCaracterEspecial(contraseña);
        }

        private static bool TieneLongitudMinima(string contraseña)
        {
            return contraseña != null && contraseña.Length >= 8;
        }

        private static bool TieneMayuscula(string contraseña)
        {
            return contraseña != null && contraseña.Any(c => char.IsUpper(c));
        }

        private static bool TieneMinuscula(string contraseña)
        {
            return contraseña != null && contraseña.Any(c => char.IsLower(c));
        }

        private static bool TieneNumero(string contraseña)
        {
            return contraseña != null && contraseña.Any(c => char.IsDigit(c));
        }

        private static bool TieneCaracterEspecial(string contraseña)
        {
            char[] caracteresEspeciales = { '!', '@', '#', '$', '%', '^', '&', '*' };
            return contraseña != null && contraseña.Any(c => caracteresEspeciales.Contains(c));
        }

        private static void MostrarRequisitosContraseña(string contraseña)
        {
            Console.WriteLine("\nRequisitos no cumplidos:");
            if (!TieneLongitudMinima(contraseña))
                Console.WriteLine("- Mínimo 8 caracteres");
            if (!TieneMayuscula(contraseña))
                Console.WriteLine("- Al menos una mayúscula");
            if (!TieneMinuscula(contraseña))
                Console.WriteLine("- Al menos una minúscula");
            if (!TieneNumero(contraseña))
                Console.WriteLine("- Al menos un número");
            if (!TieneCaracterEspecial(contraseña))
                Console.WriteLine("- Al menos un carácter especial (!@#$%^&*)");
        }
    }
}
