double perimetro = 0;
String input = string.Empty;
double lado = 0;

//Perdirle al usuario el valor de las variables
Console.WriteLine("Ingrese la longuitud del lado del cuadrado: ");
input = Console.ReadLine();
if (double .TryParse(input, out lado))
{
    perimetro = CalcularPerimetroCuadrado(lado);
    Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");
}
else
{
    Console.WriteLine("entrada no valida. POr favor, ingrese un numero valido.");
}

static double CalcularPerimetroCuadrado(double lado)
{
    return 4 * lado;
}