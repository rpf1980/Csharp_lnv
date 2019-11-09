using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Empleado : Persona
    {
        //Atributos
        private double sueldo;
        private static string nombre;
        private static int edad;

        //Constructores      
        public Empleado(string nombre, int edad, double sueldo) : base(nombre, edad)
        {
            this.sueldo = sueldo;
        }


        //Propiedades de los atributos ( Getter && Setter )
        public double GetSueldo()
        {
            return this.sueldo;
        }

        //Métodos
        public string imprimirSueldo()
        {
            return $"Sueldo: {GetSueldo()}";
        }
    }
}
