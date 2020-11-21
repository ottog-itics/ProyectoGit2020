using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGit2020
{
    class Vendedor : Empleado
    {
        public Vendedor()
        {
                
        }
        public Vendedor(string tipoEmpleado, string nombre, double ventas, double salario, double comisiones)
        {
            Salario = salario;
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
            Ventas = ventas;
            Comisiones = comisiones;
        }

        public double Ventas { get; set; }
        public double Comisiones { get; set; }

        public override double CalcularSalario()
        {
            double BonoIncentivo = Salario * 0.05;
            double BonoComisiones = Ventas * Comisiones;
            return Salario + BonoComisiones + BonoIncentivo;
        }
    }
}
