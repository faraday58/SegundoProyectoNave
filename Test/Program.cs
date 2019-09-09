using System;
using Usuarios;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.Password = "";
            Console.WriteLine("El password es: " + usuario.Password);
            Console.ReadLine();
        }
    }
}
