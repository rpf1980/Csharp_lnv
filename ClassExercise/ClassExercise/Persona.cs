using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Persona
    {
        //Atributos
        private string nombre;
        private int edad;

        //Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Propiedades de los atributos (Getter && Setter)
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetEdad()
        {
            return this.edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public string imprimir()
        {
            return $"Nombre: {GetNombre()} \n" +
                   $"Edad: {GetEdad()}";
        }

    }
}
