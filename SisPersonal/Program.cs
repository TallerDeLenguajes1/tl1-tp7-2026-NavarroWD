using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];


empleados[0] = new Empleado(
    "Juan",
    "Perez",
    new DateTime(1987, 5, 13),
    'S',
    new DateTime(2022, 3, 1),
    1300000,
    Cargos.Ingeniero
);

empleados[1] = new Empleado(
    "Jose",
    "Diaz",
    new DateTime(1976, 3, 3),
    'C',
    new DateTime(2012, 2, 11),
    950000,
    Cargos.Administrativo
);

empleados[2] = new Empleado(
    "Maria",
    "Aguero",
    new DateTime(1998, 5, 30),
    'C',
    new DateTime(2015, 11, 15),
    1100000,
    Cargos.Investigador
);

double totalSalarios = 0;

foreach(Empleado emp in empleados)
{
    totalSalarios += emp.CalcularSalario();
}

System.Console.WriteLine("Total salarios: $" + totalSalarios);

Empleado proximoJubilo = empleados[0];

foreach(Empleado emp in empleados)
{
    if(emp.calcularJubilacion() < proximoJubilo.calcularJubilacion())
    {
        proximoJubilo = emp;
    }
}

System.Console.WriteLine("Proximo jubilo: " + proximoJubilo.Apellido + " " + proximoJubilo.Nombre);
System.Console.WriteLine("Edad: " + proximoJubilo.calcularEdad());
System.Console.WriteLine("Salario: " + proximoJubilo.CalcularSalario());
System.Console.WriteLine("Antiguedad: " + proximoJubilo.calcularAntiguedad());
System.Console.WriteLine("Tiempo para jubilarse: " + proximoJubilo.calcularJubilacion());
