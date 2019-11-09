using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Banco
    {
        //Atributos
        private Cliente[] arrayClientes;

        //Constructores
        public Banco()
        {
            this.arrayClientes = new Cliente[3];
        }

        public Banco(Cliente[] arrayClientes)
        {
            this.arrayClientes = arrayClientes;
        }

        //Métodos
        /// <summary>
        /// Recorre un array de objetos tipo Cliente y busca su coincidencia con el DNI
        /// para poder hacer las operaciones básicas de un banco. Ingresar y Extraer efectivo
        /// de la propia cuenta del cliente.
        /// </summary>
        /// <param name="dni">DNI correspondiente al cliente con cuenta en el banco</param>
        public void Operar(string dni)
        {
            Cliente cliente = new Cliente();
            string op2 = "";
            string op = "";             //Alberga tipo operación a realizar por el cliente
            string operacion = "";      //String que formateará op
            double cantidad = 0.0;

            //Recorremos el array buscando el cliente por su dni
            for (int i = 0; i < this.arrayClientes.Length; i++)
            {
                string strDni = this.arrayClientes[i].GetDni();

                if(strDni == dni)
                {
                    //Preguntamos ¿Qué operación a realizar?
                    Console.WriteLine("¿Ingreso o Extracción?");
                    op = Console.ReadLine();

                    op2 = QuitaAcentos(op);

                    //Pasamos el string a minúsculas para evitar errores
                    operacion = op2.ToLower();
                   
                    //Opción Ingresar
                    
                    if(operacion == "ingreso")
                    {
                        Console.Write("Cantidad: ");
                        cantidad = double.Parse(Console.ReadLine());
                        this.arrayClientes[i].Ingresar(cantidad);
                    }
                    else
                    {
                        //Opción Extraer
                        if (operacion == "extraccion")
                        {
                            Console.Write("Cantidad: ");
                            cantidad = double.Parse(Console.ReadLine());
                            this.arrayClientes[i].Extraer(cantidad);
                        }                        
                    }
                }             
            }
        }

        public double DepositoBanco()
        {          
            double deposito = 0.0;
           
            //Recorremos el array de Clientes
            for (int i = 0; i < this.arrayClientes.Length; i++)
            {
                //Sumamos las cantidades de las cuentas de los clientes (depósito en el banco)
                deposito = deposito + this.arrayClientes[i].GetCantidadAhorrada();
            }

            return deposito;
        }

        //Funciones aparte
        /// <summary>
        /// Función que quita acentos en textos
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        /// <returns>Devuelve texto modificado sin acentos</returns>
        static string QuitaAcentos(string cadena)
        {
            //Declaramos dos string, uno que contenga signos y otro que no los contenga
            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜÑçÇ";
            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUNcC";
            //Creamos condicional que compruebe la coincidencia en tamaño del los string
            //anteriormente creados (esto evita posibles errores a la hora de seguir con el código)
            if (consignos.Length != sinsignos.Length)
            {
                throw new Exception("Revise las cadenas para la sustitución de acentos (longitud/datos)");
            }
            //Creamos variable para los ejemplares con o sin acento, y será del tamaño indicado
            int elementos = consignos.Length;
            //Creamos un string que nos retorna el cambio realizado en cadena
            string retorno = cadena;
            //Bucle for que recorre el número de elementos con o sin encontrados en cadena
            for (int i = 0; i < elementos; i++)
            {
                //Ahora, por cada elemento encontrado hacemos un replace de los caracteres
                retorno = retorno.Replace(consignos[i], sinsignos[i]);
            }
            return retorno;

        }

    }
}
