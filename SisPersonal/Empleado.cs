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
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

    }
}