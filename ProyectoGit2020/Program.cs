using System;
using System.Collections.Generic;

namespace ProyectoGit2020
{
    class Program
    {
        static List<Gerente> gerentes = new List<Gerente>();
        static List<Vendedor> vendedores = new List<Vendedor>();
        static List<Secretaria> secretarias = new List<Secretaria>();
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
                    char Genero = Convert.ToChar(Console.ReadLine());
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
                            Console.WriteLine("Ingresa ventas: ");
                            double ventas = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa comisiones: ");
                            double comisiones = double.Parse(Console.ReadLine());
                            Vendedor vendedor = new Vendedor("Vendedor", Nombre, ventas, Salario, comisiones);
                            vendedores.Add(vendedor);
                            break;
                        case '3':
                            Console.WriteLine("Ingresa el tipo de secretaria:");
                            string tipoSecretaria = Console.ReadLine();
                            Console.WriteLine("Ingresa el area de trabajo:");
                            string areaTrabajo = Console.ReadLine();
                            Secretaria secretaria = new Secretaria(tipoEmpleado, Nombre, Genero, Salario, tipoSecretaria, areaTrabajo);
                            secretarias.Add(secretaria);
                            break;
                        default:
                            Console.WriteLine("Tipo invalido.");
                            break;
                    }
                    break;
                case '2':
                    Console.WriteLine("---------Listado de empleados---------");
                    Console.WriteLine();
                    foreach (var ger in gerentes)
                    {
                        Console.WriteLine("Datos del gerente:");                       
                        Console.WriteLine($"\tNombre: {ger.Nombre}");
                        Console.WriteLine($"\tTipo gerente: {ger.TipoEmpleado}");
                        Console.WriteLine($"\tPuesto: {ger.PuestoGerente}");
                        Console.WriteLine($"\tSalario: {ger.CalcularSalario()}");
                        Console.WriteLine();
                    }
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
