namespace Program5
{
    public static class Program
    {
        public static void Main()
        {
            // Declaración de variables
            int num1, num2, num3, suma, promedio;

            // El usuario ingresa las variables 
            Console.WriteLine("Ingresa la nota 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3: ");
            num3 = int.Parse(Console.ReadLine());

            // Calcular el promedio
            suma = num1 + num2 + num3;
            promedio = suma / 3;

            // Verificar si es promovido
            if (promedio > 70)
            {
                Console.WriteLine("El estudiante es Promocionado :D");
            }
            else
            {
                Console.WriteLine("El estudiante no es Promocionado");
            }
        }
    }
}