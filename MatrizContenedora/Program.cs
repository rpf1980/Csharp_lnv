using System;
using System.Collections.Generic;

namespace MatrizContenedora
{
   
    class Program
    {
        //Métodos aparte

        /// <summary>
        /// Muestra por consola un array detallado
        /// </summary>
        /// <param name="a">Array de enteros vacío</param>
        static void EscribeArray(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length-1; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length-1] + "]");
        }

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

        static void MatrizContenedora()
        {
            //Variables
            int[,] matriz10x10 = new int[10, 10];
            int[] arrayEnteros = new int[9];
            int[,] matriz3x3;
            int pos00Submatriz = -1;
            bool buscaValor;

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

            //Búsqueda 1:
            //1.0 >> Tomando como referencia la posición 0,0 de la submatriz ( valor 5 de submatriz )
            //debemos comprobar desde ese punto todas las filas y columnas ( 3x3 de nuestra submatriz )

            //1.1 >> Debemos empezar a buscar la submatriz desde esa posición hasta el final de la matriz10x10  

            //Guarda valor en posición 0,0 de submatriz
            pos00Submatriz = matriz3x3[0, 0];

            int i, j; //Índices para iterar matriz10x10
            int k, e; //Índices para iterar matriz3x3
            //Recorre la matriz10x10 y busca pos00Submatriz (es el valor)
            for (i = 0; i < matriz10x10.GetLength(0); i++)
            {
                for (j = 0; j < matriz10x10.GetLength(0); j++)
                {
                    if(matriz10x10[i,j] == pos00Submatriz)
                    {
                        //En este punto debemos ir comprobando filas y columnas de la submatriz en la matriz
                        //Interaciones de bucle 3x3
                        for (k = i; k < i+3; k++)
                        {
                            for (e = j; e < j+3; e++)
                            {

                            }
                        }
                    }
                }
            }

            //Comprobar que pos00Submatriz está en la matriz10x10
            /*if(buscaValor = ValorEncontrado(matriz10x10, pos00Submatriz))
            {
                //Ahora tenemos que recorrerer la matriz10x10 empezando por la posición del valor guardado
                for (int i = ; i < matriz10x10.GetLength(0); i++)
                {

                }
            } */                                   
            //---------------PRUEBAS------------

            //Probaremos una función que pretende retornar las coordenadas de un valor en una matriz

        }

        static int[] CopiaMatrizEnArray(int[,] matriz)
        {
            int[] array = new int[9];
            int k;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                k = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    array[k] = matriz[i, j];
                    k++;
                }
                Console.WriteLine();
            }

            return array;
        }

        static bool compruebaArray10(int[] a)  //case 100
        {
            bool esValido = false;

            List<int> li = new List<int>();

            int i;

            for (i = 0; i < a.Length; i++)  //Pasamos los elementos del array a una lista siempre y cuando la lista no los contengan
            {
                if (!li.Contains(a[i]))
                {
                    li.Add(a[i]);
                }
            }


            if (li.Count == a.Length)  //Si el tamaño de la lista es idéntico al del array, significa que son iguales, ya que no se han repetido
                                        //elementos y no quedarían hueco por copiar en la lista
            {
                esValido = true;
            }

            return esValido;

        }

        /*static bool compruebaSubarray3x3(int[,] matriz)
        {
            bool esValida = true;
            int[] array = new int[9];
            int r; //Indice que itera el array
            int i, j; //Indices para iterar de 3 en 3 las filas y las columnas
            int k, e; //Indices que recorrerán los subarray 3x3

            for (i = 0; i < matriz.GetLength(0); i = i + 3)
            {
                for (j = 0; j < matriz.GetLength(1); j = j + 3)
                {
                    r = 0;
                    for (k = i; k < i + 3; k++)
                    {
                        for (e = j; e < j + 3; e++)
                        {
                            array[r] = matriz[k,e];
                            r++;
                        }
                    }
                    if (!compruebaArray10(array))
                    {
                        esValida = false;
                        i = matriz.GetLength(0);
                        j = matriz.GetLength(1);
                    }
                }
            }
            return esValida;
        }*/

        /// <summary>
        /// Busca un valor entero en una matriz de enteros
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="valor"></param>
        /// <returns>Entero encontrado, 0 si no lo encuentra</returns>
        static int BuscaValorEnMatriz(int[,] matriz, int valor)
        {
            int res = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] == valor)
                    {
                        res = matriz[i, j];
                    }                   
                }
            }

            return res;
        }

        /// <summary>
        /// Busca un entero en una matriz
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="entero"></param>
        /// <returns>Coordenadas en tipo string de la posición del entero</returns>
        static string DevuelvePosDeEntero(int[,] matriz, int entero)
        {
            string pos = "";
            int i, j;
            int posX = -1;
            int posY = -1;

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for(j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] == entero)
                    {
                        posX = i;
                        posY = j;
                    }
                }
            }

            //Devolvemos la posición como un string para verla bonita
            pos = $"[{posX.ToString()},{posY.ToString()}]";

            return pos;
        }

        /// <summary>
        /// Busca valor en matriz
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="valor"></param>
        /// <returns>True si lo encuentra, false si no lo encuentra</returns>
        static bool ValorEncontrado(int[,] matriz, int valor)
        {
            bool res = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        res = true;
                    }
                }
            }

            return res;
        }

        

        static void Main(string[] args)
        {
            MatrizContenedora();

            /*int[,] m3x3 = new int[3, 3];
            int[] array = new int[9];

            m3x3 = RellenaMatriz3x3();

            EscribeArrayBi(m3x3);

            array = CopiaMatrizEnArray(m3x3);
            Console.WriteLine();
            EscribeArray(array);*/
        }
    }
}
