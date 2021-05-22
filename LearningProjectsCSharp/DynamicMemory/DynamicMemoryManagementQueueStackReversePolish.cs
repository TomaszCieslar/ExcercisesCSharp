using System;
using System.Collections;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class DynamicMemoryManagementQueueStackReversePolish
    {
        public void Main()
        {
            //Create a program that reads from a text file one expression in Reverse Polish Notation like, for example: 

            //3 4 6 5 - +*6 +
            //(Result 21)

            //                Each item will be stored in a queue. 

            //Once the queue has all the items stored, you will have to store them from the queue to a stack(using class Queue and Stack provided in C#). 

            //Finally, you will operate with the stack in order to get the correct result of the expression in RPN, and you will show it by console.

            Console.Write("Introduce el nombre del archivo: ");
            string nombreFichero = Console.ReadLine();

            if (!File.Exists(nombreFichero))
            {
                Console.Write("El archivo no existe");
                return;
            }

            try
            {
                bool depurando = true;

                StreamReader ficheroTexto;
                ficheroTexto = File.OpenText(nombreFichero);
                string line = " ";

                Queue micola = new Queue();

                do
                {
                    line = ficheroTexto.ReadLine();
                    if (line != null)
                        micola.Enqueue(line);
                }
                while (line != null);

                ficheroTexto.Close();

                Stack miPila = new Stack();

                int numero1 = 0, numero2 = 0;

                int cantidadCola = micola.Count;

                string valorCola;
                string[] valores_linea;

                for (int i = 0; i < cantidadCola; i++)
                {
                    valorCola = (string)micola.Dequeue();
                    valores_linea = valorCola.Split(' ');

                    for (int c = 0; c < valores_linea.Length; c++)
                    {
                        switch (valores_linea[c])
                        {
                            case "+":
                                numero1 = Convert.ToInt32(miPila.Pop());
                                numero2 = Convert.ToInt32(miPila.Pop());

                                miPila.Push(numero2 + numero1);

                                break;
                            case "-":
                                numero1 = Convert.ToInt32(miPila.Pop());
                                numero2 = Convert.ToInt32(miPila.Pop());

                                miPila.Push(numero2 - numero1);
                                break;
                            case "*":
                                numero1 = Convert.ToInt32(miPila.Pop());
                                numero2 = Convert.ToInt32(miPila.Pop());

                                miPila.Push(numero2 * numero1);
                                break;
                            case "/":
                                numero1 = Convert.ToInt32(miPila.Pop());
                                numero2 = Convert.ToInt32(miPila.Pop());

                                miPila.Push(numero2 / numero1);
                                break;
                            default:
                                // Almacenamos valores enteros
                                miPila.Push(valores_linea[c]);
                                break;
                        }
                    }

                    for (int j = 0; j < miPila.Count; j++)
                    {
                        Console.WriteLine(miPila.Pop());
                    }
                }

                if (depurando)
                    Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error, " + e.Message);
            }
        }
    }
}
