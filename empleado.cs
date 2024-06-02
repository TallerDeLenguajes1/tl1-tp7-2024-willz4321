using System;

namespace EspacioCalculadora
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private char estado_civil;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private double sueldo_basico;
        private Cargos cargo;

        public Empleado(string nombre, string apellido, char estadoCivil, DateTime fechaNacimiento, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.estado_civil = estadoCivil;
            this.fecha_nacimiento = fechaNacimiento;
            this.sueldo_basico = sueldoBasico;
            this.cargo = cargo;
            this.fecha_ingreso = fechaIngreso;
        }

        public global::System.String Nombre { get => nombre; set => nombre = value; }
        public global::System.String Apellido { get => apellido; set => apellido = value; }
        public global::System.Char Estado_civil { get => estado_civil; set => estado_civil = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public global::System.Double Sueldo_basico { get => sueldo_basico; set => sueldo_basico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int CalcularAntiguedad()
        {
            int years = DateTime.Now.Year - fecha_ingreso.Year;
            if (DateTime.Now.Month < fecha_ingreso.Month || (DateTime.Now.Month == fecha_ingreso.Month && DateTime.Now.Day < fecha_ingreso.Day))
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
        public int CalcularAñosParaJubilacion()
            {
                const int edadJubilacion = 65;
                return edadJubilacion - CalcularEdad();
            }

        public double CalcularSalario()
        {
            double adicional = 0;

            if (CalcularAntiguedad() <= 20)
            {
                adicional = Sueldo_basico * CalcularAntiguedad() * 0.01;
            }
            else
            {
                adicional = Sueldo_basico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            if (Estado_civil == 'C' || Estado_civil == 'c')
            {
                adicional += 150000;
            }

            double salario = Sueldo_basico + adicional;

            return salario;
        }

    }

}
