using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGit2020
{
    class Secretaria : Empleado
    {
        public Secretaria()
        {

        }

        public Secretaria(string tipoEmpleado, string nombre, char genero, double salario, string tipoSecretaria, string area)
        {
            Nombre = nombre;
            Salario = salario;
            TipoEmpleado = tipoEmpleado;
            Genero = genero;
            TipoSecretaria = tipoSecretaria;
            Area = area;
        }

        public String TipoSecretaria { get; set; }
        public String Area { get; set; }
        public override double CalcularSalario()
        {
            return base.Salario * 1.05;
        }
    }
}
