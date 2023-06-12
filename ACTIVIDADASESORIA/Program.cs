using System;

namespace MIPRIMER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1, num2, result = 0;

            Console.WriteLine("Ingresa una opción");

            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicación");
            Console.WriteLine("4) División");

            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa 2do numero");
            num2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    result = Suma(num1, num2);
                    Console.WriteLine("La suma es: " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("La Resta es: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("La Multiplicación  es: " + result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("La División  es: " + result);
                    break;

            }

        }

        public static int Suma(int Num1, int Num2) 
        {
            int result = Num1 + Num2;
            return result;
        }
        public static int Resta(int Num1, int Num2)
        {
            int result = Num1 - Num2;
            return result;
        }
        public static int Multiplicacion(int Num1, int Num2) 
        {
            int result = Num1 * Num2;
            return result;
        }
        public static int Division(int Num1, int Num2) 
        {
            int result = Num1 / Num2;
            return result;
        }
    }
}
