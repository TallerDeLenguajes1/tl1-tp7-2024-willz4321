using System;
using EspacioCargos;

namespace EspacioEmpleado
{
   public class Empleado {
    
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso_empresa;
        private char estado_civil;
        private double sueldo_basico;
        private Cargos cargo;

        public int CalcularAntiguedad()
        {
            int years = DateTime.Now.Year - fecha_ingreso_empresa.Year;
            if (DateTime.Now.Month < fecha_ingreso_empresa.Month || (DateTime.Now.Month == fecha_ingreso_empresa.Month && DateTime.Now.Day < fecha_ingreso_empresa.Day))
                years--;

            return years;
        }

        public int CalcularEdad()
        {
            int years = DateTime.Now.Year - fecha_nacimiento.Year;
            if (DateTime.Now.Month < fecha_nacimiento.Month || (DateTime.Now.Month == fecha_nacimiento.Month && DateTime.Now.Day < fecha_nacimiento.Day))
                years--;

            return years;
        }

        public int AniosParaJubilacion()
        {
            int edad = CalcularEdad();
            return 65 - edad;
        }
   }
}
