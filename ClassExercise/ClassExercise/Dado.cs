using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Dado
    {
        //Atributos
        int valor;      //Valor del dado

        //Constructor
        public Dado() { }
        public Dado(int valor)
        {
            this.valor = valor;
        }

        //Propiedades de los atributos
        public int GetValor()
        {
            return this.valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
        }

        //Métodos
        public int Tirar()
        {
            Random rd = new Random();
            int tirada = 0;

            tirada = rd.Next(1, 7);

            return tirada;          
        }

        public string imprimir()
        {
            return $"Valor del dado: {GetValor()}";
        }
    }
}
