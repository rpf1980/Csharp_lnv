using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class TrianguloIsosceles
    {
        //Atributos
        double lado;       //Correspondería a los lados iguales del triángulo isósceles
        double ladoMin;    //Lado desigual del triángulo isósceles       

        //Constructores
        public TrianguloIsosceles(double lado, double ladoMin)
        {
            this.lado = lado;
            this.ladoMin = ladoMin;
        }
      
        //Propiedades de los atributos       
        public double GetLado()
        {
            return this.lado;
        }

        public void SetLado(double lado)
        {
            this.lado = lado;
        }

        public double GetLadoMin()
        {
            return this.ladoMin;
        }

        public void SetLadoMin(double ladoMin)
        {
            this.ladoMin = ladoMin;
        }

        //Métodos
        public double GetAltura()
        {
            double a = GetLado();       //Lado 
            double b = GetLadoMin();    //Base

            return Math.Sqrt(((a * a) - (b * b)) / 4);
        }

        public double GetPerimetro()
        {
            double l = GetLado();       //Lado
            double b = GetLadoMin();    //Base

            double res = (l * l) + b;

            return res;
        }        

        public double GetArea()
        {
            double b = GetLadoMin();    //Base
            double a = GetAltura();     //Altura

            return ((b*a) / 2);
        }
    }
}
