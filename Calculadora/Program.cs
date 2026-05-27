using EspacioCalculadora;

Calculadora calculadora = new Calculadora();
int opcion;
double numero;
do
{
    Console.WriteLine("--- CALCULADORA ---");
    Console.WriteLine("Resultado actual: " + calculadora.Resultado);
    Console.WriteLine("1: Sumar");
    Console.WriteLine("2: Restar");
    Console.WriteLine("3: Multiplicar");
    Console.WriteLine("4: Dividir");
    Console.WriteLine("5: Limpiar");
    Console.WriteLine("0: Salir");
    Console.WriteLine("Ingrese una opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un numero a sumar: ");
            double.TryParse(Console.ReadLine(), out numero);
            calculadora.Sumar(numero);
            break;
        case 2:
            Console.WriteLine("Ingrese un numero a restar: ");
            double.TryParse(Console.ReadLine(), out numero);
            calculadora.Restar(numero);
            break;
        case 3:
            Console.WriteLine("Ingrese un numero a multipliciar: ");
            double.TryParse(Console.ReadLine(), out numero);
            calculadora.Multiplicar(numero);
            break;
        case 4:
            Console.WriteLine("Ingrese un numero a dividir: ");
            double.TryParse(Console.ReadLine(), out numero);
            calculadora.Dividir(numero);
            break;
        case 5:
            Console.WriteLine("Limpiando...");
            calculadora.Limpiar();
            break;
        case 0:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("No valido...");
            break;
    }
    
}while(opcion != 0);

