namespace Program5
{
    public static class Program
    {
        public static void Main()
        {
            // Declaración de variables
            int num1 = 0;

            // El usuario ingresa el número
            Console.WriteLine("Ingrese un número positivo de uno o dos dígitos: ");
            num1 = int.Parse(Console.ReadLine());

            //Verificar si el numero tiene uno o dos digitos
            if (num1 >= 1 && num1 <= 9 )
            {
                Console.WriteLine("su numero tiene un digito");
            }
            else
            {
                if (num1 >= 10 && num1 <= 99 )
                {
                    Console.WriteLine("Su numero tiene dos digitos");
                } 
                else
                {
                    Console.WriteLine("El número no es válido (fuera del rango permitido) :(");
                }
            }

        }
    }
}