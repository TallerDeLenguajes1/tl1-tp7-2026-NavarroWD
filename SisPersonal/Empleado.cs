using System.Reflection.Metadata.Ecma335;

namespace EspacioEmpleado
{
    
    public enum Cargos
    {
        Auxiliar,
        Administrativo, 
        Ingeniero, 
        Especialista,
        Investigador
    }

    public class Empleado
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public char EstadoCivil {get; set;}
        public DateTime FechaIngreso {get; set;}
        public double SueldoBasico {get; set;}
        public Cargos Cargo {get; set;}

        public Empleado(
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            char estadoCivil,
            DateTime fechaIngreso,
            double sueldoBasico,
            Cargos cargo
        )
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }
        public int calcularEdad()
        {
            int edad = 2026 - FechaNacimiento.Year;
            return edad;
        }

        public int calcularAntiguedad()
        {
            int antiguedad = 2026 - FechaIngreso.Year;
            return antiguedad;
        }

        public int calcularJubilacion()
        {
            int faltante = 65 - calcularEdad();
            return faltante;
        }        

        public double calcularAdicional()
        {
            double adicional = 0;
            int antiguedad = calcularAntiguedad();

            if(antiguedad <= 20)
            {
                adicional = SueldoBasico * antiguedad * 0.01;
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if(Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional = adicional * 1.5;
            }    

            if(EstadoCivil == 'C' || EstadoCivil == 'c')
            {
                adicional = adicional + 150000;
            }
            
            return adicional;
        }
        public double CalcularSalario()
        {
            double salario = SueldoBasico + calcularAdicional();
            return salario;
        }
    }
}