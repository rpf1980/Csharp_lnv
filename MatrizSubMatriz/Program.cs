using System;
using System.Collections.Generic;

namespace MatrizSubMatriz
{
    class Program
    {
        /// <summary>
        /// Rellena un array de valores en orden ascendente, comenzando por el 1
        /// </summary>
        /// <param name="a">Array de cualquier tamaño</param>
        static void RellenaEnOrdenBi(int[,] a)
        {
            int i, j;
            int valor = 1;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = valor;
                    valor++;
                }
            }
        }

        /// <summary>
        /// Rellena un array 3x3 con números de tipo entero
        /// </summary>
        /// <returns>Devuelve matriz 3x3 con valores ingresados por consola</returns>
        static int[,] RellenaMatriz3x3() //Tenemos que pasar por parámetro un array 3x3
        {
            //Variables
            int[,] array = new int[3, 3];
            int i, j;
            int cont = 5;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = cont;
                    cont++;
                }
            }
            return array;
        }

        /// <summary>
        /// Función que escribe lista por consola.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma.</param>
        static void EscribeLista(List<int> l)
        {
            Console.Write("<");
            int i;
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.Write(l[l.Count - 1] + ">");
        }

        /// <summary>
        /// Muestra por consola un array detallado
        /// </summary>
        /// <param name="a">Array de enteros vacío</param>
        static void EscribeArray(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length - 1] + "]");
        }

        /// <summary>
        /// Función que imprime por pantalla array multidimensional de cualquier tamaño.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void EscribeArrayBi(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("| ");
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }

        /// <summary>
        /// Función que copia valores de array desde dos puntos de cota. Te copia los valores desde el inico al final
        /// de la cota
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y corresponde al array</param>
        /// <param name="inicio">Determina segundo parámetro y corresponde al inicio de la cota</param>
        /// <param name="fin">Determina tercer parámetro y corresponde al final de la cota</param>
        /// <returns>Devuelve copia de los elementos de la cota generada en el array</returns>
        static int[] SubArray(int[] a, int inicio, int fin)
        {
            int j, i;

            int cota = fin - inicio + 1;
            int[] b = new int[cota];

            i = 0;
            for (j = inicio; j <= fin; j++)
            {
                b[i] = a[j];
                i++;
            }
            return b;
        }

        static int[] CopiaMatrizEnArray(int[,] matriz, int tama)
        {
            int[] array = new int[tama];
            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    array[cont] = matriz[i, j];
                    cont++;
                }
            }

            return array;
        }

        static string CastingArrayToString(int[] array)
        {
            string str = "";

            for (int i = 0; i < array.Length; i++)
            {
                str = str + array[i].ToString();
            }

            return str;
        }


        static void MatrizContenedora()
        {
            //Variables
            int[,] matriz10x10 = new int[10, 10];
            int[] arrayEnteros = new int[9];
            int[,] matriz3x3;
            int[] arrayCopiaM100;
            int[] arrayCopiaM9;            
            string strArray100 = "";
            string strArray9 = "";
            string strConMarca = "";

            //Inicializamos matriz 10x10 y le damos valores
            RellenaEnOrdenBi(matriz10x10);

            //Mostramos por consola matriz10
            Console.WriteLine("Array bidimensional de 10x10:");
            Console.WriteLine();
            EscribeArrayBi(matriz10x10);

            //Pedimos al usuario los valores enteros para la submatriz 3x3 y le damos valores
            Console.WriteLine("Array bidimensional de 3x3:");
            Console.WriteLine();
            matriz3x3 = RellenaMatriz3x3();
            EscribeArrayBi(matriz3x3);
            Console.WriteLine();

            //Pasamos a un array de 1 dimensión los valores de matriz10x10
            arrayCopiaM100 = CopiaMatrizEnArray(matriz10x10, 100);
            arrayCopiaM9 = CopiaMatrizEnArray(matriz3x3, 9);

            //Pasamos los arrays a string para trabajar mejor con los datos
            strArray100 = CastingArrayToString(arrayCopiaM100);
            strArray9 = CastingArrayToString(arrayCopiaM9);

            //Marcamos la posición del primer elemento de la subcadena
            strConMarca = MarcaSubCadena(strArray100, strArray9);


            //Pasamos a valores enteros nuestro string strConMarca
            

        }

        static List<int> PasaStringToArrayList(string cadena)
        {
            string copiaCadena = cadena;
            List<int> lista = new List<int>();

            for (int i = 0; i < copiaCadena.Length; i++)
            {
                lista.Add(copiaCadena[i]);
            }          
            return lista;
        }
      
        /// <summary>
        /// Función que marca con un caracter negativo el primer caracter de una subcadena
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función y la cadena a analizar</param>
        /// <param name="subcadena">Determina el segundo parámetro de la función y la subcadena</param>
        /// <returns>Devuelve cadena con subcadena modificada</returns>
        static string MarcaSubCadena(string cadena, string subcadena)
        {
            int i;
            
            string cacho;
            for (i = 0; i < cadena.Length - (subcadena.Length - 1); i++)
            {
                cacho = cadena.Substring(i, subcadena.Length);
                if (cacho == subcadena)
                {
                    //cadena[i] = '*';
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "-7");
                }
                
            }

            return cadena;
        }

        static void Main(string[] args)
        {
            MatrizContenedora();


            //*NOTA: 
           // List<int> lista = 

            //int entero = (char)34;  //Para pasar caracter a su código ascii
            
        }
    }
}
