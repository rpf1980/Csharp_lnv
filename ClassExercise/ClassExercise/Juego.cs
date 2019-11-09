using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Juego
    {
        //Atributos
        Dado[] arrayDados;

        //Constructor
        public Juego()
        {
            this.arrayDados = new Dado[3];
        }

        public Juego(Dado[] array)
        {
            this.arrayDados = array;
        }

        //Métodos
        public string Jugar()
        {
            //Variables
            string resultado = "";
            string res = "";
            bool gana = false;
            int cont;  //Contador auxiliar que muestra el orden de las tiradas     
            int[] tiradas = new int[3]; //Guardará las tres tiradas, una de cada dado 
            

            //Tirar los dados
            for (int i = 0; i < this.arrayDados.Length; i++)
            {
                Dado d = new Dado();        //Instanciamos objeto dado
                arrayDados[i] = d;          //Los metemos en el aray de dados
                tiradas[i] = d.Tirar();     //Asignamos tirada al objeto y guardamos tirada en array de tiradas
            }

            //Mostrar valor de tiradas
            cont = 1;
            for (int i = 0; i < tiradas.Length; i++)
            {
                res += $"Tirada dado {cont}: {tiradas[i]}" + "\n";
                cont++;
            }

            //Comprueba si las tiradas son iguales                     
            if(IgualesEnArray(tiradas))
            {
                gana = true;
            }

            if(gana)
            {
                resultado += res + "GANAS";
            }
            else
            {
                resultado += res + "PIERDES";
            }

            
            return resultado;
        }

        //Funciones aparte
        /// <summary>
        /// Función que comprueba si todos los elementos de un array son iguales
        /// </summary>
        /// <param name="arr">Array de tipo entero y de n tamaño</param>
        /// <returns>True si todos los elementos son iguales</returns>
        static bool IgualesEnArray(int[] arr)
        {
            bool iguales = false; //Devuelve 
            int contador = 0;
            int guardaPrimerElementoArray = arr[0];
            List<int> lista = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!lista.Contains(arr[i])) //Si el elemento no está en la lista, lo copia
                {
                    contador = contador + 1;
                    lista.Add(arr[i]);
                }
            }

            if (contador == 1)
            {
                iguales = true;
            }

            return iguales;

        }
    }
}
