using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class DynamicMemoryManagementStackUsingArray
    {
        public void Main()
        {
            //Implementing a stack using array

            bool depurando = true;

            Pila miPila = new Pila(5);

            miPila.Apilar(4);
            miPila.Apilar(5);

            Console.WriteLine(miPila.Desapilar());
            Console.WriteLine(miPila.Desapilar());

            if (depurando)
                Console.ReadLine();
        }
    }

    class Pila
    {
        int valor_actual;
        readonly int cantidad_valores;
        readonly int[] valores_pila;

        public Pila(int cantidad_valores)
        {
            valor_actual = 0;
            this.cantidad_valores = cantidad_valores;

            valores_pila = new int[cantidad_valores];
        }

        public void Apilar(int valor)
        {
            if (valor_actual < cantidad_valores)
            {
                valores_pila[valor_actual] = valor;
                valor_actual++;
            }

        }

        public int Desapilar()
        {
            if (valor_actual > 0)
            {
                valor_actual -= 1;
                return valores_pila[valor_actual];
            }
            return 0;
        }
    }
}
