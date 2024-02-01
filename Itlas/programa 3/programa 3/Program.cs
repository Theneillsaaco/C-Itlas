namespace Program3
{
    public static class Program
    {
        public static void Main()
        {
            // Declaración de variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            int promedio = 0;

            // Pedir al usuario los valores
            Console.WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto número: ");
            num4 = int.Parse(Console.ReadLine());

            // Calcular la suma
            suma = num1 + num2 + num3 + num4;

            // Calcular el promedio
            promedio = suma / 4;

            // Mostrar la suma y el promedio
            Console.WriteLine($"La suma de los números es: {suma}");
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}