using System;
using System.Collections.Generic;

namespace ProyectoGit2020
{
    class Program
    {
        static List<Gerente> gerentes = new List<Gerente>();
        List<Vendedor> vendedores = new List<Vendedor>();
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
                    Console.WriteLine("---------Agregar nuevo empleado---------");
                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingeres el genero del empleado:");
                    string Genero = Console.ReadLine();
                    Console.WriteLine("Ingrese el salario base del empleado:");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el tipo de empleado a crear:");
                    Console.WriteLine("\t 1) Gerente");
                    Console.WriteLine("\t 2) Vendedor");
                    Console.Write("Tipo: ");
                    char TipoEmpleado = char.Parse(Console.ReadLine());
                    switch (TipoEmpleado)
                    {
                        case '1':
                            Console.WriteLine("Ingresa el puesto del gerente: ");
                            string Puesto = Console.ReadLine();
                            Gerente gerente = new Gerente("Gerente", Nombre, Salario, Genero, Puesto);
                            gerentes.Add(gerente);
                            break;
                        case '2':
                            Console.WriteLine();
                            foreach (var ger in gerentes)
                            {
                                Console.WriteLine(ger.Nombre);
                            }
                            break;
                        default:
                            Console.WriteLine("Tipo invalido.");
                            break;
                    }
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
