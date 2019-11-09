using System;
using System.Collections.Generic;

namespace MatrizContenedoraV4
{
    class Program
    {
        public static object Collections { get; private set; }

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
        /// Función que integra 9 enteros de un array en una matriz de 3x3
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Matriz con 9 enteros</returns>
        static int[,] RellenaMatriz3x3(int[] array, int fila, int col)
        {
            int[,] matriz = new int[fila, col];

            int k = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {               
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = array[k];
                    k++;
                }
            }

            return matriz;
        }

        /// <summary>
        /// Función que lee enteros por consola y rellena un array con ellos
        /// </summary>
        /// <param name="a">Array de n elementos tipo entero</param>
        static int[] LeeArray(int tama)
        {
            int[] a = new int[tama];

            int i;
            
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Escribe valor: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;

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
        /// Pasa elementos enteros de una lista a una matriz
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>Matriz de enteros</returns>
        static int[,] RellenaMatrizArray(int[,] matriz, int fila, int columna, int[] array)
        {
            matriz = new int[fila, columna];
            int cont;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                cont = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = array[cont];
                    cont++;
                }
            }

            return matriz;
        }

        /// <summary>
        /// Pasa elementos enteros de una lista a una matriz
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>Matriz de enteros</returns>
        static int[,] RellenaMatrizArray(int[] array)
        {
            int[,] matriz = new int[10, 10];
            int cont;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                cont = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = array[cont];
                    cont++;
                }
            }

            return matriz;
        }
    
        /// <summary>
        /// Copia los elementos de una matriz 3x3 en un array de 9
        /// </summary>
        /// <param name="matriz">Matriz de 3x3</param>
        /// <returns>Array de 9 enteros</returns>
        static int[] CopiaMatrizEnArray(int[,] matriz)
        {
            int[] array = new int[9];
            int indice;

            indice = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    array[indice] = matriz[i, j];
                    indice++;
                }
            }

            return array;
        }

        //FUNCIÓN PRUEBA: Quiero entrar en la matriz, pararme en un elemento, y a partir de ahí copia en una lista una submatriz de 3x3
        static int[] DameSubArray(int[,] matriz)
        {
            int[] array = new int[9];
                     
            int elementoMarca = 5;

            int i, j, k, e;
            int cont;
            //Este en sí es la clave de lo que busco
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == elementoMarca)
                    {
                        cont = 0;
                        for (k = i; k < i + 3; k++)
                        {
                            for (e = j; e < j + 3; e++)
                            {
                                array[cont] = matriz[k, e];
                                cont++;
                            }
                        }
                    }                                                         
                }
            }

            return array;
        }
           
        /// <summary>
        /// Busca una matriz dentro de otra y devuelve las coordenadas del elemento 0,0 de la submatriz en la matriz
        /// Dicha función contiene diferentes llamadas a métodos y funciones que van resolviendo el problema planteado
        /// </summary>
        static void MatrizContenedora()
        {
            //Variable
            int[,] matriz10x10 = new int[10, 10];
            int[,] subMatriz;
            int[] arrAux;
            int elemento00Matriz3x3 = 0;
            int[] arraySubMatriz3x3;
            int tamaArray = 0;
            int tamaAuxiliar = 0;
            int[] array3x3EnMatriz10x10 = new int[9];
            int coordX = 0;
            int coordY = 0;
            int fila = 0;
            int col = 0;

            //Inicializamos matriz 10x10 y le damos valores
            RellenaEnOrdenBi(matriz10x10);

            //Mostramos por consola matriz10x10            
            Console.WriteLine();
            EscribeArrayBi(matriz10x10);
            Console.WriteLine();

            //Pedimos al usuario los valores enteros para la submatriz 3x3 y le damos valores
            Console.WriteLine("Tamaño para la subMatriz: ");
            Console.WriteLine("Fila:");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Columna:");
            col = int.Parse(Console.ReadLine());

            tamaAuxiliar = fila * col;
            arrAux = LeeArray(tamaAuxiliar);
            Console.WriteLine();

            subMatriz = RellenaMatriz3x3(arrAux, fila, col);
            EscribeArrayBi(subMatriz);
            Console.WriteLine();

            //Guarada elemento en coordenadas [0,0] de matriz3x3
            //Será el elemento que debemos buscar en matriz10x10 ( ahí comenzaría nuestra submatriz )
            elemento00Matriz3x3 = subMatriz[0, 0];

            //Guarda submatriz matriz3x3
            arraySubMatriz3x3 = CopiaMatrizEnArray(subMatriz);
            //EscribeArray(arraySubMatriz3x3);

            //Recorre matriz10x10 con iteraciones 1 a 1 en sus bucles
            int cont, i, j, k, e;
            for (i = 0; i < matriz10x10.GetLength(0); i++)
            {
                for (j = 0; j < matriz10x10.GetLength(1); j++)
                {
                    if (matriz10x10[i, j] == elemento00Matriz3x3)
                    {
                        coordX = i;
                        coordY = j;
                        cont = 0;
                        for (k = i; k < i + 3; k++)
                        {
                            for (e = j; e < j + 3; e++)
                            {
                                array3x3EnMatriz10x10[cont] = matriz10x10[k, e];
                                cont++;
                            }
                        }
                    }
                }
            }

            //EscribeArray(array3x3EnMatriz10x10);
            Console.WriteLine();

            Console.WriteLine($"Coordenadas de submatriz en matriz: [{coordX},{coordY}]");

        }

        static void Main(string[] args)
        {
            MatrizContenedora();
        }
    }
}
