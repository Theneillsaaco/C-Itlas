namespace program2;
public static class program
{
    static void Main()
    {
        // Declaración de variables
        int num1, num2, num3, num4;
        int suma;
        int producto;

        // Ingreso de datos
        Console.WriteLine("Ingrese el primer número:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto número:");
        num4 = int.Parse(Console.ReadLine());

        // Cálculo de la suma
        suma = num1 + num2;

        // Cálculo del producto
        producto = num3 * num4;

        // Salida de resultados
        Console.WriteLine("La suma de los dos primeros números es: {0}", suma);
        Console.WriteLine("El producto del tercero y el cuarto número es: {0}", producto);
    }
}