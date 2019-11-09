using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program
    {       
        static void EscribeArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.Write(arr[arr.Length-1]);
            Console.Write("]");
        }       
      
        static void Main(string[] args)
        {
            int opcion = -1;

            while(opcion != 0)
            {
                Console.WriteLine("===========");
                Console.WriteLine("MENÚ CLASES");
                Console.WriteLine("===========");
                Console.WriteLine("[1] Triángulo isósceles");
                Console.WriteLine("[2] Juego de dados");
                Console.WriteLine("[3] Banco");
                Console.WriteLine("[4] Persona");
                Console.WriteLine("[0] SALIR");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch(opcion)
                {
                    case 1:
                        {
                            //Pedimos datos al usuario
                            Console.WriteLine("<<Datos del triángulo>>");
                            Console.Write("Lado = ");
                            double l = double.Parse(Console.ReadLine());    //Lado
                            Console.Write("Base = ");
                            double b = double.Parse(Console.ReadLine());    //Base

                            //Instanciamos la clase TrianguloIsosceles
                            TrianguloIsosceles t = new TrianguloIsosceles(l, b);

                            int opcionTriangulo = -1;

                            while(opcionTriangulo != 100)
                            {
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("OPCIONES TRIÁNGULO ISÓSCELES");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("[1] Perimetro");
                                Console.WriteLine("[2] Area");
                                Console.WriteLine("[100] SALIR");
                                Console.WriteLine();
                                opcionTriangulo = int.Parse(Console.ReadLine());

                                switch(opcionTriangulo)
                                {
                                    case 1:
                                        {
                                            double perimetro = t.GetPerimetro();
                                            Console.WriteLine($"El perímetro del triángulo es = {perimetro}");
                                        }
                                        break;
                                    case 2:
                                        {
                                            double area = t.GetArea();
                                            Console.WriteLine($"El área del triángulo es = {area}");
                                        }
                                        break;
                                    default:break;
                                }
                            }

                        }
                        break;
                    case 2:
                        {
                            //Instanciamos la clase Juego
                            Dado[] array = new Dado[3];
                            Juego juego = new Juego(array);

                            string res = juego.Jugar();
                            Console.WriteLine(res);
                        }
                        break;
                    case 3:
                        {
                            //Variables
                            double dep = 0.0;

                            //Clientes del Banco
                            Cliente cl1 = new Cliente("23232323-A", "Carlos Méndez Calatraba", 1000.0); 
                            Cliente cl2 = new Cliente("24242424-B", "Mª Isabel Rodriguez Pozo", 2000.0);
                            Cliente cl3 = new Cliente("25252525-C", "Luisa Blanco Carrascosa", 3000.0);

                            //Array contenedor de los clientes del Banco
                            Cliente[] arrayClientes = new Cliente[3];

                            arrayClientes[0] = cl1;
                            arrayClientes[1] = cl2;
                            arrayClientes[2] = cl3;

                            Banco banco = new Banco(arrayClientes);

                            //Ingresamos cantidad en las cuentas de los clientes
                            banco.Operar("23232323-A");
                            /*banco.Operar("24242424-B");
                            banco.Operar("25252525-C");*/

                            //Mostramos depósito actual del Banco
                            dep = banco.DepositoBanco();
                            Console.WriteLine($"Depósito actual: {dep}");

                            //Extraemos cantidad de las cuentas de los clientes
                            banco.Operar("23232323-A");
                            /*banco.Operar("24242424-B");
                            banco.Operar("25252525-C");*/

                            //Mostramos depósito actual del Banco
                            dep = banco.DepositoBanco();
                            Console.WriteLine($"Depósito actual: {dep}");
                        }
                        break;
                    case 4:
                        {
                            //Definimos un objeto de la clase Persona
                            Persona persona = new Persona("Manuel", 64);

                            //Mostramos propiedades del objeto Persona
                            Console.WriteLine(persona.imprimir());

                            //Definimos un objeto de la clase Empleado
                            Empleado empleado = new Empleado("Jose Miguel", 46, 3334.4);

                            //Mostramos propiedades del objeto Empleado
                            Console.WriteLine(empleado.imprimir());
                            Console.WriteLine(empleado.imprimirSueldo());

                        }
                        break;
                    default: Console.WriteLine("El número de opción elegida no se encuentra en el menú"); ; break;
                }
            }
            
        }
    }
}
