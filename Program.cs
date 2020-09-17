using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7 * 5);

            Console.WriteLine(7 * 5 * 3);

            Console.WriteLine(5 / 2);

            Console.WriteLine(5.0 / 2.0);

            Console.WriteLine(9 % 3);

            Console.WriteLine(9 % 4);

            int edad = 19;

            edad++;

            Console.WriteLine("Tienes una edad de " + edad + " años");

            //Console.WriteLine($"Tienes una edad de {edad} años");

            int edad2 = 19;

            edad2 += 8;

            Console.WriteLine("Tienes una edad de " + edad2 + "años");

            int edad3 = 19;

            edad3--;

            Console.WriteLine("Tienes una edad de " + edad3 + " años");

            int edad4 = 19;

            edad4 -= 5;

            Console.WriteLine("Tienes una edad de " + edad4 + "años");
        }
    }
}
