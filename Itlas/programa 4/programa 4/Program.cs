

namespace programa4
{
    public static class program
    {
        public static void Main()
        {
            //declaracion de variables
            double  num1, num2, suma, diferencia, producto, divicion;

            //perdile al usuario las variables
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());

            //verificacion de las variables
            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;

                //mostrar resutados
                Console.WriteLine($"la suma es: {suma}");
                Console.WriteLine($"La diferencia es: {diferencia}");
            }
            else
            {
                //si el segundo es mayor o igual
                if (num2 != 0)
                {

                    producto = num1 * num2;
                    divicion = num1 / num2;

                    //mostrar resutados
                    Console.WriteLine($"El producto es: {producto}");
                    Console.WriteLine($"La divicion es: {divicion}");
                }
                else
                {
                    Console.WriteLine("Su numero es invalido o No es posible dividir por cero.");
                }
            }
            
            
        }
    }
}