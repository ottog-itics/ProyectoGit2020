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

        public Secretaria(string tipoSecretaria, string area)
        {
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
