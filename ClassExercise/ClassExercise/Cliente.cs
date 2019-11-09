using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Cliente
    {
        //Atributos
        string dni;
        string nombre;
        double cantidadAhorrada;

        //Constructores
        public Cliente(string dni, string nombre, double cantidadAhorrada)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.cantidadAhorrada = cantidadAhorrada;
        }

        public Cliente() { }

        //Propiedades de los atributos (Getter && Setter)
        public string GetDni()
        {
            return dni;
        }
        public void SetDNI(string dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double GetCantidadAhorrada()
        {
            return this.cantidadAhorrada;
        }
        public void SetCantidadAhorrada(double cantidadAhorrada)
        {
            this.cantidadAhorrada = cantidadAhorrada;
        }

        //Métodos
        public void Ingresar(double cantidad)
        {           
            //Sumamos la cantidad a ingresar al saldo actual
            double ingreso = GetCantidadAhorrada() + cantidad;

            //Establacemos nueva cantidadAhorrada
            SetCantidadAhorrada(ingreso);
        }

        public void Extraer(double cantidad)
        {
            //Guardamos el saldo actual
            double saldoActual = GetCantidadAhorrada();

            //Comprobamos que nuestro cliente tiene saldo
            if(saldoActual > 0)
            {
                //Restamos la cantidad del saldo
                saldoActual = saldoActual - cantidad;

                //Establecemos nuevo saldo en la cuenta del cliente
                SetCantidadAhorrada(saldoActual);
            }
            else
            {
                throw new Exception("No hay suficiente saldo");
            }
        }

        public double ConsultarSaldo()
        {
            return GetCantidadAhorrada();
        }
    }
}
