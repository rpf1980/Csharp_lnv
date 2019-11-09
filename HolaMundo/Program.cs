using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100;
            int n2 = 200;
            int suma = n1 + n2;
            int edad = 0;
            int res = 0;

            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad: ");
            edad = int.Parse(Console.ReadLine());

            //Operador condicional ternario
            res = edad > 25 ? edad : 0;
                    
            Console.WriteLine($"Hola {nombre} que tal estás ??, tu edad es {res}");

            Console.WriteLine($"La suma es = {suma}");

        }
    }
}