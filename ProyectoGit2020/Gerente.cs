using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGit2020
{
    class Gerente:Empleado
    {
        private const double BONO_GERENTE = 0.15;

        public Gerente()
        {

        }
        public Gerente(string tipoEmpleado, string nombre, double salario)
        {
            Salario = salario;
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
        }

        public override double CalcularSalario()
        {
            double BonoIncentivo = Salario * 0.05;
            double BonoGenerente = Salario * BONO_GERENTE;
            return Salario + BonoIncentivo + BonoGenerente;
        }

    }
}
