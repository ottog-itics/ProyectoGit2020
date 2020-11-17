using System;

namespace ProyectoGit2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del proyecto!");
            Console.WriteLine("Proyecto para la administración de empleados.");
            Console.WriteLine("-------------------- Menú -------------------");
            Console.WriteLine("\t 1) Agregar empleado.");
            Console.WriteLine("\t 2) Listado de empleados.");
            Console.WriteLine("\t 3) Salir");
            Console.WriteLine("Selecciona una opción: ");
            char Opcion = Char.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case '1':
                    Console.WriteLine("---------Agregar empleado---------");
                    break;
                case '2':
                    Console.WriteLine("---------Listado de empleados---------");
                    break;
                case '3':
                    Console.WriteLine("---------Saliendo. Adiós.---------");
                    break;
                default:
                    Console.WriteLine("Opcion invalida..");
                    break;
            }
        }
    }
}
